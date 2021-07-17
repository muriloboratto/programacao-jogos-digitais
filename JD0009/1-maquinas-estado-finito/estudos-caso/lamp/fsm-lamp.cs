/*%****************************************************************************80
!  Code: 
!   fsm-lamp.cs
!
!  Purpose:
!   Sample example with Finite State Machine (FSM) - Lamp case 
!
!  Modified:
!   Mar 15 2021 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs fsm-lamp.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   - The simbol ()=>  is anonime function; 
!
!****************************************************************************80*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fsm
{

  class FiniteStateMachine
  {
        public enum States{ ON, OFF, ERROR };
        
        public enum Events{ TurnOn, TurnOff, Broke };

        public States State { get; set; }
       
        private Action[,] fsm;

        public FiniteStateMachine()
        {
          this.fsm = new Action[3, 3] { 
          //turn on,                          turn off,                          broke                            
          {this.DoNothing,                    ()=>{this.State = States.OFF;},    ()=>{this.State = States.ERROR;}},//On
          {()=>{this.State = States.ON;},     this.DoNothing,                    this.DoNothing },                //Off
          {this.DoNothing,                    this.DoNothing,                    this.DoNothing }};               //Error
        }

        public void ProcessEvent(Events theEvent)
        {
           this.fsm[(int)this.State, (int)theEvent].Invoke();
        }

        private void DoNothing() {return;}
        
  }/*class FiniteStateMachine*/
  

  class Program
  {
    static void Main(string[] args)
    {
        var fsm = new FiniteStateMachine();

        Console.WriteLine(fsm.State); //ON
        fsm.ProcessEvent(FiniteStateMachine.Events.TurnOff);
        
        Console.WriteLine(fsm.State); //OFF
        fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
        
        Console.WriteLine(fsm.State); //ON
        fsm.ProcessEvent(FiniteStateMachine.Events.Broke);

        Console.WriteLine(fsm.State); //ERROR
              
    }/*main*/
  
  }/*class Program*/

}/*namespace fsm*/