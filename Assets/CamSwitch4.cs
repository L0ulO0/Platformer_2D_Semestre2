using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch4 : MonoBehaviour
{

    [SerializeField] GameObject triggercam5;
    [SerializeField] GameObject triggercam6;
 
    [SerializeField] CinemachineVirtualCamera Cam5;
    [SerializeField] CinemachineVirtualCamera Cam6;

    private bool camswitch2 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (!camswitch2)
        {
            triggercam6.SetActive(true);
            triggercam5.SetActive(false);
            Cam5.Priority = 1;
            Cam6.Priority = 100;

            camswitch2 = true;

        }
        else if (camswitch2)
        {
            triggercam6.SetActive(false);
            triggercam5.SetActive(true);
            Cam5.Priority = 100;
            Cam6.Priority = 1;

            camswitch2 = false;

        }
    }
   
}
