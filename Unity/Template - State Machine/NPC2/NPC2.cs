using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : StateMachine<NPC2.NPC2State>
{
    public enum NPC2State
    {
        First,
        Second,
        Third,
    }

    public override void InitializeStates()
    {
        // Add each state developed for NPC2

        states.Add(NPC2State.First, new NPC2State_First(this));
        states.Add(NPC2State.Second, new NPC2State_Second(this));
        states.Add(NPC2State.Third, new NPC2State_Third(this));
        currentState = states[NPC2State.First];
    }

    public override Enum GetCurrentState()
    {
        return currentState.stateKey;
    } 
} 
