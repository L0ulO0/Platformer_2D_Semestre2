using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phoneSystem : MonoBehaviour
{

    [SerializeField] GameObject phone;
    [SerializeField] bool phoneOpen = false;

    [SerializeField] Mouvement mouvement;

    // trigger notification

    [SerializeField] triggerNotification triggernotification;

     // Button menu

    [SerializeField] GameObject pictureButton;
    [SerializeField] GameObject smsButton;
    [SerializeField] GameObject callButton;


    // SMS

    [SerializeField] GameObject SMS1;
    [SerializeField] GameObject SMS2;


    // element
    [SerializeField] GameObject picture;
 

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Phone();

    }

    public void Phone()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            if(phoneOpen)
            {
                PhoneClose();
            }
            else
            {
                PhoneOpen();
            }
          
        }
    }

    void PhoneOpen()
    {
        mouvement.CanMouv = false;
        phone.SetActive(true);
        Time.timeScale = 0;
        phoneOpen = true;
        pictureButton.SetActive(true);
        smsButton.SetActive(true);
        callButton.SetActive(true);

    }

    void PhoneClose()
    {
        mouvement.CanMouv = true;
        phone.SetActive(false);
        Time.timeScale = 1;
        phoneOpen = false;
        picture.SetActive(false);
        SMS1.SetActive(false);
        SMS2.SetActive(false);
    }

    public void OpenPicture()
    {
        picture.SetActive(true);
        pictureButton.SetActive(false);
        smsButton.SetActive(false);
        callButton.SetActive(false);
    }


    public void OpenSms()
    {
        picture.SetActive(true);
        pictureButton.SetActive(false);
        smsButton.SetActive(false);
        callButton.SetActive(false);
    }


    public void OpenCalll()
    {
        picture.SetActive(true);
        pictureButton.SetActive(false);
        smsButton.SetActive(false);
        callButton.SetActive(false);
    }

    public void Sms()
    {
        SMS1.SetActive(true);
        pictureButton.SetActive(false);
        smsButton.SetActive(false);
        callButton.SetActive(false);

        if (triggernotification.canReadSms1 == true)
        {
            SMS2.SetActive(true);
        }

        

    }





}
