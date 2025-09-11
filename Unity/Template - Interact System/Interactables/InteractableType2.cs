using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableType2 : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText; // Assign interact message 
    public void Interact(Transform interactorTransform)
    {
        // Add code
    }
    public string GetInteractText()
    {
        return interactText;
    }
    public Transform GetTransform()
    {
        return transform;
    }
}
