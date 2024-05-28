using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch5 : MonoBehaviour
{

 
    [SerializeField] GameObject triggercam6;
 

    [SerializeField] CinemachineVirtualCamera Cam6;

    private bool camswitch2 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player")
        {

            triggercam6.SetActive(true);
            Cam6.Priority = 100;

        }
    }
   
}
