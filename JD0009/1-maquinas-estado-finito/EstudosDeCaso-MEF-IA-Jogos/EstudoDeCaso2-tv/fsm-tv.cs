/*%****************************************************************************80
!  Code: 
!   fsm-tv.cs
!
!  Purpose:
!   Sample example with Finite State Machine (FSM) - TV case 
!
!  Modified:
!   Mar 15 2021 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs mef-tv.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   - The simbol ()=>  is Anonymous function (i.e: is like this the inline function); 
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
        public enum States{ UNPOWERED, STANDBY, ON };
        
        public enum Events{ PlugIn, TurnOn, TurnOff, RemovePower };

        public States State { get; set; }
       
        private Action[,] fsm;

        public FiniteStateMachine()
        {
          this.fsm = new Action[3, 4] { 
          //PlugIn,                            TurnOn,                        TurnOff,                             RemovePower
          {()=>{this.State = States.STANDBY;}, this.DoNothing,                this.DoNothing,                      this.DoNothing },                       //UNPOWERED
          {this.DoNothing,                     ()=>{this.State = States.ON;}, this.DoNothing,                      ()=>{this.State = States.UNPOWERED;} }, //STANDBY
          {this.DoNothing,                     this.DoNothing,                ()=>{this.State = States.STANDBY;},  ()=>{this.State = States.UNPOWERED;} }};//ON
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

        Console.WriteLine(fsm.State);//Unpowered
        fsm.ProcessEvent(FiniteStateMachine.Events.PlugIn);
        
        Console.WriteLine(fsm.State);//Standby
        fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
        
        Console.WriteLine(fsm.State);//On
        fsm.ProcessEvent(FiniteStateMachine.Events.TurnOff);
        
        Console.WriteLine(fsm.State);//Standby
        fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
        
        Console.WriteLine(fsm.State);//On
        fsm.ProcessEvent(FiniteStateMachine.Events.RemovePower);
        
        Console.WriteLine(fsm.State);//Unpowered
        
    }/*main*/
  
  }/*class Program*/

}/*namespace fsm*/