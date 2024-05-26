using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    [SerializeField] Mouvement Mouvement;

    [SerializeField] Transform IA;
    [SerializeField] Transform RespawnIA;
    private Transform ThePlayerSpawner;

    private void Awake()
    {
        ThePlayerSpawner = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("Hello");
            collision.transform.position = GameObject.FindGameObjectWithTag("PlayerSpawn").transform.position;

            IA.transform.position = RespawnIA.transform.position;

            collision.transform.position = ThePlayerSpawner.position;

           

        }
    }
}
