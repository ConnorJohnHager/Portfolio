using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // CAN CHANGE: Trigger
        {
            IInteractable interactable = GetInteractable();
            if ( interactable != null)
            {
                interactable.Interact(transform);
            }
        }
    }

    public IInteractable GetInteractable()
    {
        List<IInteractable> interactableList = new List<IInteractable>();
        float interactRange = 1f; // CAN CHANGE: Value
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange); // CAN CHANGE: Physics and Position
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteractable interactable))
            {
                interactableList.Add(interactable);
            }
        }

        IInteractable closestInteractable = null;
        foreach (IInteractable interactable in interactableList)
        {
            if (closestInteractable == null)
            {
                closestInteractable = interactable;
            }
            else
            {
                if (Vector3.Distance(transform.position, interactable.GetTransform().position) <
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position))
                {
                    closestInteractable = interactable;
                }
            }
        }

        return closestInteractable;
    }
}
