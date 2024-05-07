using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IAenemi : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] private Transform PlayerPosition;

    [SerializeField] private Vector2 currentPosition;
    [SerializeField] float distance = 10;
    [SerializeField] float speed = 12;

    [SerializeField] mouvement Mouvement;



    // Start is called before the first frame update
    void Start()
    {
        PlayerPosition = Player.GetComponent<Transform>();
        currentPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mouvement.sheHide == false)
        {
              if (Vector2.Distance(transform.position , PlayerPosition.position) < distance && CompareTag("Player"))
              {
             transform.position = Vector2.MoveTowards(transform.position, PlayerPosition.position, speed * Time.deltaTime);
              }

              else
              {
                  if (Vector2.Distance(transform.position, currentPosition) <= 0)
                  {

                  }

                  else
                  {
                     transform.position = Vector2.MoveTowards(transform.position, currentPosition, speed * Time.deltaTime); 
                  }


              }
        }

         else
         {
             // code de marche 
         }
     
    }
}
