using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch7 : MonoBehaviour
{


    [SerializeField] GameObject triggercam4;
 
  
    [SerializeField] CinemachineVirtualCamera Cam4;

    private void OnTriggerEnter2D(Collider2D collision)
    {



        
            triggercam4.SetActive(true);
      
         
            Cam4.Priority = 100;

         

    }
   
}
