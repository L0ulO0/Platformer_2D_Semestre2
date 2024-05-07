using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPont2 : MonoBehaviour
{

    private GameMaster GM;
    //[SerializeField] public Vector2 lastCheckPointPos;

    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster> () ;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GM.lastCheckPointPos = transform.position;  
        }
    }



}
