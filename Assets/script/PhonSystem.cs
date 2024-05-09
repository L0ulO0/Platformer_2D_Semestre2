using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhonSystem : MonoBehaviour
{

    [SerializeField] GameObject phone;
    [SerializeField] bool phoneOpen = false;

    [SerializeField] mouvement mouvement;
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
        if(Input.GetKeyDown(KeyCode.Keypad7))
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
    }

    void PhoneClose()
    {
        mouvement.CanMouv = true;
        phone.SetActive(false);
        Time.timeScale = 1;
        phoneOpen = false;
    }
}
