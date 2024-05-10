using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Dialogue_trigger : MonoBehaviour

{
    public Dialogue dialogue;

    public bool isInRange;

    private TextMeshProUGUI InteractUI;
  


    private void Awake()
    {
        InteractUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<TextMeshProUGUI>(); 
    }

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

            InteractUI.enabled = true;

           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;

            InteractUI.enabled = false;

            

        }
    }

    private void TriggerDialogue()
    {
        Dialogue_Manager.Instance.StartDialogue(dialogue);
    }

}
