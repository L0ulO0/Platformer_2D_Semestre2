using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_trigger : MonoBehaviour
{
    public Dialogue dialogue;

    public bool isInRange; 

    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E)) 
        {
            TriggerDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    private void TriggerDialogue()
    {
        Dialogue_Manager.Instance.StartDialogue(dialogue);
    }

}
