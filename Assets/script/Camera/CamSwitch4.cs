using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch4 : MonoBehaviour
{

    [SerializeField] GameObject triggercam5;
 
 
    [SerializeField] CinemachineVirtualCamera Cam5;
  

    private void OnTriggerEnter2D(Collider2D collision)
    {



        

       
            triggercam5.SetActive(true);
            Cam5.Priority = 100;
         

     

        
    }
   
}
