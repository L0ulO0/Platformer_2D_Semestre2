using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDetection : MonoBehaviour

   
{

    [SerializeField] IAenemi IAenemi;
    [SerializeField] GameObject Enemy; 


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("AAA");

        IAenemi.ispatroling = false; 
        transform.position = Vector2.MoveTowards(transform.position, IAenemi.targetPlayer.position, IAenemi.speed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IAenemi.ispatroling = true; 
    }
}
