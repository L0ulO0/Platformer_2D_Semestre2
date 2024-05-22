using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Screem_Trigger : MonoBehaviour
{
    private AudioClip Screem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Screem");
    }
}
