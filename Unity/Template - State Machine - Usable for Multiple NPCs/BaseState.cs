using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class BaseState<EState> where EState : Enum
{
    public GameObject Obj;
    public Rigidbody Rb; // Optional
    public Collider Col; // Optional
    public Animator Anim; // Optional
    public NavMeshAgent Agent; // Optional
    public BaseState(StateMachine<EState> _sm, EState key)
    {
        Obj = _sm.gameObject;
        Rb = Obj.GetComponent<Rigidbody>(); // Optional
        Col = Obj.GetComponent<Collider>(); // Optional
        Anim = Obj.GetComponent<Animator>(); // Optional
        Agent = Obj.GetComponent<NavMeshAgent>(); // Optional
        stateKey = key;
    }
    public EState stateKey { get; private set; }
    public EState nextState;
    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
    public abstract EState GetNextState();
    public abstract void OnTriggerEnter(Collider other); // Optional
    public abstract void OnTriggerStay(Collider other); // Optional
    public abstract void OnTriggerExit(Collider other); // Optional
}

