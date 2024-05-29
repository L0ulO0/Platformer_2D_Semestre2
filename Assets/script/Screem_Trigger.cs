using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Screem_Trigger : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip sfx;
    [SerializeField] float volume;
    [SerializeField] bool alreadyPlayed = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!alreadyPlayed)
        {
            audio.PlayOneShot(sfx, volume);
            Debug.Log("Screem");
        }
    }
}
