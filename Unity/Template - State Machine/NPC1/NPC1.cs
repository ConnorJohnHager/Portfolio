using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : StateMachine<NPC1.NPC1State>
{
    public enum NPC1State
    {
        First,
        Second,
        Third,
    }

    public override void InitializeStates()
    {
        // Add each state developed for NPC1

        states.Add(NPC1State.First, new NPC1State_First(this));
        states.Add(NPC1State.Second, new NPC1State_Second(this));
        states.Add(NPC1State.Third, new NPC1State_Third(this));
        currentState = states[NPC1State.First];
    }

    public override Enum GetCurrentState()
    {
        return currentState.stateKey;
    }
} 
