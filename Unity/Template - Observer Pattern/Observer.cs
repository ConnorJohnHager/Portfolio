using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    public Observed observed; // Assign the Observed
    public void Start()
    {
        observed.AddObserver(this);
    }
    public void OnNotify()
    {
        // Add code
    }
}
