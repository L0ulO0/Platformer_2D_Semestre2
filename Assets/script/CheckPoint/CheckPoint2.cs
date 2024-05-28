using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class checkpoint2 : MonoBehaviour
{
    [SerializeField] private Vector2 Respawn;

    [SerializeField] Transform IA;
    [SerializeField] Transform RespawnIA;


    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        /* if (other.gameObject.CompareTag("CheckPoint"))
         {


             Respawn = transform.position;
             Debug.Log(" REZZ");


         }*/


        if (other.tag =="Player")
        {
                // PlayerSpawn.position = transform.position;
                Debug.Log("New Spawn");
                SceneManager.LoadScene("SCN_Niveau2");
        }
    }

}
