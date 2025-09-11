using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observed : MonoBehaviour
{
    [SerializeField] private List<Observer> observers = new List<Observer>();
    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }
    public void NotifyObservers()
    {
        if (observers.Count > 0)
        {
            foreach (Observer observer in observers)
            {
                observer.OnNotify();
            }
        }
    }
    public void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }
}
