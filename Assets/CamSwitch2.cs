using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch2 : MonoBehaviour
{

    [SerializeField] GameObject triggercam3;
    [SerializeField] GameObject triggercam4;
 
    [SerializeField] CinemachineVirtualCamera Cam3;
    [SerializeField] CinemachineVirtualCamera Cam4;

    private bool camswitch2 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (!camswitch2)
        {
            triggercam4.SetActive(true);
            triggercam3.SetActive(false);
            Cam3.Priority = 1;
            Cam4.Priority = 100;

            camswitch2 = true;

        }
        else if (camswitch2)
        {
            triggercam4.SetActive(false);
            triggercam3.SetActive(true);
            Cam3.Priority = 100;
            Cam4.Priority = 1;

            camswitch2 = false;

        }
    }
   
}
