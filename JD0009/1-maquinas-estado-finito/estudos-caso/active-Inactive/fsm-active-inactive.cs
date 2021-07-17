/*%****************************************************************************80
!  Code: 
!   fsm-active-inactive.cs
!
!  Purpose:
!   Sample example with Finite State Machine (FSM) - Active and Incative case 
!
!  Modified:
!   Mar 15 2021 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs mef-active-inactive.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!    - Dictionary Structure in C# for this implementation
!
!****************************************************************************80*/

using System;
using System.Collections.Generic;

namespace myApp
{
    public enum ProcessState{ INACTIVE, ACTIVE, PAUSED, TERMINATED }
    public enum Command{ Begin, End, Pause, Exit }

    public class Process
    {
        class StateTransition
        {
            ProcessState CurrentState;
            Command Command;

            public StateTransition(ProcessState currentState, Command command)
            {
                CurrentState = currentState;
                Command = command;
            }

            public override int GetHashCode()
            {
                return 17 + 31 * CurrentState.GetHashCode() + 31 * Command.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                StateTransition other = obj as StateTransition;
                return other != null && this.CurrentState == other.CurrentState && this.Command == other.Command;
            }
        }

        Dictionary<StateTransition, ProcessState> transitions;
        public ProcessState CurrentState { get; private set; }

        public Process()
        {
            CurrentState = ProcessState.INACTIVE;

            transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(ProcessState.INACTIVE, Command.Exit),  ProcessState.TERMINATED },
                { new StateTransition(ProcessState.INACTIVE, Command.Begin), ProcessState.ACTIVE },
                { new StateTransition(ProcessState.ACTIVE,   Command.End),   ProcessState.INACTIVE },
                { new StateTransition(ProcessState.ACTIVE,   Command.Pause), ProcessState.PAUSED },
                { new StateTransition(ProcessState.PAUSED,   Command.End),   ProcessState.INACTIVE }
            };
        }

        public ProcessState GetNext(Command command)
        {
            StateTransition transition = new StateTransition(CurrentState, command);
            ProcessState nextState;
            
            if (!transitions.TryGetValue(transition, out nextState))
                throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
            return nextState;
        }

        public ProcessState MoveNext(Command command)
        {
            CurrentState = GetNext(command);
            return CurrentState;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            
            Console.WriteLine("Current State = " + p.CurrentState);
            
            Console.WriteLine("Command.Begin: Current State = " + p.MoveNext(Command.Begin));
            Console.WriteLine("Command.Pause: Current State = " + p.MoveNext(Command.Pause));
            Console.WriteLine("Command.End: Current State = "   + p.MoveNext(Command.End));
            Console.WriteLine("Command.Exit: Current State = "  + p.MoveNext(Command.Exit));         
        }
    }
}