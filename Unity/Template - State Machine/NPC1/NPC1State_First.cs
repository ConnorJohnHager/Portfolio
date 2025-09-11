using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NPC1;

public class NPC1State_First : BaseState<NPC1State> 
{
    public NPC1 theNPC;
    public NPC1State_First(StateMachine<NPC1State> npc) : base(npc, NPC1State.First)
    {
        theNPC = npc.gameObject.GetComponent<NPC1>();
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
    public override NPC1State GetNextState()
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
