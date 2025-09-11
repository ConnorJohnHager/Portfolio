using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerUI; // Assign Interact UI
    [SerializeField] private TextMeshPro textbox; // Assign textbox from the Interact UI
    [SerializeField] private Interactor interactor; // Assign Interactor

    private void Update()
    {
        if (interactor.GetInteractable() != null)
        {
            Show(interactor.GetInteractable());
        }
        else
        {
            Hide();
        }
    }

    private void Show(IInteractable interactable)
    {
        containerUI.SetActive(true);
        textbox.text = interactable.GetInteractText();
    }

    private void Hide()
    {
        containerUI.SetActive(false);
    }
}
