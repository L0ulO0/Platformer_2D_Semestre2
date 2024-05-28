using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviour


    
{

    [SerializeField] checkpoint PlayerSpawn;
    private void Awake()
    {
        // checkpoint.PlayerSpawn.position = transform.position;
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }

}
