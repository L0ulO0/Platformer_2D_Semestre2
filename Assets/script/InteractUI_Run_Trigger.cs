using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractUI_Run_Trigger : MonoBehaviour
{
    private TextMeshProUGUI Interact_run;
    public bool isInRange;

    private void Awake()
    {
        Interact_run = GameObject.FindGameObjectWithTag("InteractUI2").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;

            Interact_run.enabled = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;

            Interact_run.enabled = false;



        }
    }
}
