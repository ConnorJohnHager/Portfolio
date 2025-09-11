using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NPC2;

public class NPC2State_First : BaseState<NPC2State> 
{
    public NPC2 theNPC;
    public NPC2State_First(StateMachine<NPC2State> npc) : base(npc, NPC2State.First)
    {
        theNPC = npc.gameObject.GetComponent<NPC2>();
    }
    public override void EnterState()
    {
        // Add code
    }
    public override void ExitState()
    {
        // Add code
    }
    public override void UpdateState()
    {
        // Add code
    }
    public override NPC2State GetNextState()
    {
        return nextState;
    }
    public override void OnTriggerEnter(Collider other)
    {
        // Add code
    }
    public override void OnTriggerStay(Collider other)
    {
        // Add code
    }
    public override void OnTriggerExit(Collider other)
    {
        // Add code
    }
}
