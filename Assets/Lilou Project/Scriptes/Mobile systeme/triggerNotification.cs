using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerNotification : MonoBehaviour
{

//AUDIO
    [SerializeField] AudioClip sfx;
    [SerializeField] float volume;
    [SerializeField] AudioSource audio;
    [SerializeField] bool alreadyPlayed = false;

    //UI

    [SerializeField] float flickDelay = 0.3f;
    [SerializeField] float flickStop = 5f;
    [SerializeField] CanvasGroup flickCanvas;
    [SerializeField] GameObject flickCanvasGameObject;
    [SerializeField] bool isFlickering;

    // sms bool
    public bool canReadSms1;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!alreadyPlayed)
        {
            audio.PlayOneShot(sfx, volume);
            StartFlicker();
            alreadyPlayed = true;
            canReadSms1 = true;
        }
 

    }

    private void StartFlicker()
    {

        flickCanvas.alpha = 1f;
        flickCanvasGameObject.SetActive(true);
        isFlickering = true;
        StartCoroutine(ContinuousFlicker());
        StartCoroutine(StopFlicker());
    }
    private IEnumerator ContinuousFlicker()
    {

        while (isFlickering)
        {
            yield return new WaitForSeconds(1);
            flickCanvas.alpha = 0f;
            yield return new WaitForSeconds(1);
            flickCanvas.alpha = 1f;

        } 
        if (isFlickering == false)
        {
            flickCanvas.alpha = 0f;
        }

    }

    private IEnumerator StopFlicker()
    {
        Debug.Log("coco");
        yield return new WaitForSeconds(flickStop);
        flickCanvasGameObject.SetActive(false);
        isFlickering = false;

    }


}
