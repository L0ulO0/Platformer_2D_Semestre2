using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch3 : MonoBehaviour
{

    [SerializeField] GameObject triggercam6;
 
  
    [SerializeField] CinemachineVirtualCamera Cam6;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {



       
            triggercam6.SetActive(true);
    
         
            Cam6.Priority = 100;

          

        
      
     

         

      
    }
   
}
