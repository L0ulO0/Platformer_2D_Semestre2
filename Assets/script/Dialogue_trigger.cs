using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using System;

public class Dialogue_trigger : MonoBehaviour

{
    public Mouvement Mouvement;

    public Dialogue dialogue;

    public bool isInRange;

    private TextMeshProUGUI InteractUI;


    private GameObject NextButton;

    private Input_manette input_manette;


    private void Awake()
    {
        input_manette = new Input_manette();
        InteractUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<TextMeshProUGUI>(); 
    }

    //private void OnEnable()
    //{
    //    input_manette.Mouvement.Interact.Enable();

    //    input_manette.Mouvement.Interact.performed += Interact;
    //}

    //public void Interact(InputAction.CallbackContext context)
    //{
    //    Mouvement.CanMouv = false;
    //    TriggerDialogue();
    //}

    //private void OnDisable()
    //{
    //    input_manette.Mouvement.Interact.Disable();
    //}
    void Update()
    {
        
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
