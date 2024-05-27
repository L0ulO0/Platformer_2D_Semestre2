using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch6 : MonoBehaviour
{
    [SerializeField] GameObject triggercam1;
  

    [SerializeField] CinemachineVirtualCamera Cam1;
  

   

    private void OnTriggerEnter2D(Collider2D collision)
    {




       
        triggercam1.SetActive(true);
        Cam1.Priority = 100;
      

   







    }
}
