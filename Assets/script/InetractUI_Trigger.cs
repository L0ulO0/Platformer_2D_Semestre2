using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InetractUI_Trigger : MonoBehaviour
{

    private TextMeshProUGUI InteractUI_Hide;
    public bool isInRange;

    private void Awake()
    {
        InteractUI_Hide = GameObject.FindGameObjectWithTag("InteractUI_Hide").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;

            InteractUI_Hide.enabled = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;

            InteractUI_Hide.enabled = false;



        }
    }
}
