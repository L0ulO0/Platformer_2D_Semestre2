using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch2 : MonoBehaviour
{

    [SerializeField] GameObject triggercam3;

 
    [SerializeField] CinemachineVirtualCamera Cam3;


 
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.tag == "Player")
        {
            triggercam3.SetActive(true);
            Cam3.Priority = 100;


        }
       
    }
   
}
