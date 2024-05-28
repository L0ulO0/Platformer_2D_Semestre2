using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch : MonoBehaviour
{
    [SerializeField] GameObject triggercam1;
    [SerializeField] GameObject triggercam2;

    [SerializeField] CinemachineVirtualCamera Cam1;
    [SerializeField] CinemachineVirtualCamera Cam2;
  
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            

                triggercam2.SetActive(true);
                triggercam1.SetActive(false);
                Cam1.Priority = 1;
                Cam2.Priority = 100;

               

            
        }

      
        
     
    }


}
