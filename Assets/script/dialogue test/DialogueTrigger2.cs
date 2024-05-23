using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueTrigger2 : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager2 dialogueManager;
    public GameObject dialogueTrigger;
    public GameObject dialogueUI;

    public Mouvement Mouvement;
    public bool inTrigger;

    public bool dialogueStarted = false;
    [SerializeField] private GameObject player;    // To check if the player is in da collider

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }

    public void Interact(InputAction.CallbackContext context)
    {
            if (context.performed && inTrigger)
            {
                if (dialogueStarted == false)
                {
                    dialogueUI.SetActive(true);
                    TriggerDialogue();
                }
                else
                {
                    dialogueManager.DisplayNextSentences();
                }
            }
    }
    void TriggerDialogue()
    {
        dialogueStarted = true;
        dialogueManager.animator.SetBool("BoolOpen", true);
        DialogueManager.instance.StartDialogue(dialogue);
    }
}
