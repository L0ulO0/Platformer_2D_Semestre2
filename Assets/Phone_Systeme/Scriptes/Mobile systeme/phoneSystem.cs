using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static Cinemachine.CinemachineOrbitalTransposer;

public class phoneSystem : MonoBehaviour
{

    [SerializeField] GameObject phone;
    [SerializeField] GameObject phoneSMS;
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
    //[SerializeField] GameObject SMS3;


    // element
    [SerializeField] GameObject picture;

    // input manette
    private Input_manette input_manette;

    private void Awake()
    {
        input_manette = new Input_manette();
    }

    private void OnEnable()
    {
        input_manette.Mouvement.Phone.Enable();

        input_manette.Mouvement.Phone.performed += Phone;
    }

    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Phone();

    }

    private void Phone (InputAction.CallbackContext context)
    { 
       // if (Input.GetKeyDown(KeyCode.Z))
        //{
            if(phoneOpen)
            {
                PhoneClose();
            }
            else
            {
                PhoneOpen();
            }
          
        //}
    }

    private void OnDisable()
    {

        input_manette.Mouvement.Phone.Disable();
    }


    void PhoneOpen()
    {
        mouvement.CanMouv = false;
        phone.SetActive(true);
        phoneSMS.SetActive(false);
        Time.timeScale = 0;
        phoneOpen = true;
        pictureButton.SetActive(true);
        smsButton.SetActive(true);
        callButton.SetActive(true);

    }

    void PhoneClose()
    {
        phoneSMS.SetActive(false);
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
        phone.SetActive(false);
        phoneSMS.SetActive(true);
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
        phone.SetActive(false);
        phoneSMS.SetActive(true);
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
