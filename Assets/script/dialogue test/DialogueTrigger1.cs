using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue1 dialogue;
    public DialogueManager1 dialogueManager;
    public GameObject dialogueTrigger;
    public GameObject dialogueUI;
    private TextMeshProUGUI InteractUI;

    public Mouvement Mouvement;
    public bool inTrigger;

    public bool dialogueStarted = false;
    [SerializeField] private GameObject player;    // To check if the player is in da collider


    private void Awake()
    {

        InteractUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<TextMeshProUGUI>();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            inTrigger = true;
            InteractUI.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            inTrigger = false;
            InteractUI.enabled = false;
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
        DialogueManager1.instance.StartDialogue(dialogue);
    }
}
