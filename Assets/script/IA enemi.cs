using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IAenemi : MonoBehaviour
{
    public float speed;
    [SerializeField] SpriteRenderer enemySprite;


    // PATROUILLE ENEMI //

    [SerializeField] Transform[] waypoints; // tableau des waypoint de l'enemi
    private int waypointIndex = 0;
    private Transform targetPatrol;// waypoint ou passe l'enemi
    private float spriteDirection = 0; // orientation du player

    private Vector2 playerDirection;

    public Collider2D triggerEnemyDetection;
    public Transform targetPlayer;
    public bool ispatroling;

    /// 

    [SerializeField] GameObject Player;
    [SerializeField] private Vector2 currentPosition;
    [SerializeField] float distance;

    [SerializeField] Mouvement Mouvement; 

    /* [SerializeField] GameObject Player;
     [SerializeField] private Transform PlayerPosition;

     [SerializeField] private Vector2 currentPosition;
     [SerializeField] float distance = 10;
     [SerializeField] float speed = 12;

     [SerializeField] mouvement Mouvement;*/



    // Start is called before the first frame update
    void Start()
    {

        // int du 1er waypoint de la patrouille 

        targetPatrol = waypoints[1];
        ispatroling = true; 


       /* PlayerPosition = Player.GetComponent<Transform>();
        currentPosition = GetComponent<Transform>().position;*/
    }

    // Update is called once per frame
    void Update()
    {

        Enemimoove();
       /* if (Mouvement.sheHide == false)
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
         }*/
     
    }

    public void Enemimoove()
    {
        if (ispatroling)
        {
            GetWaypointDirection();

            transform.Translate(playerDirection * speed * Time.deltaTime, Space.World); 

            if (Vector2.Distance(transform.position, targetPatrol.position) < 0.1f)// enemie a sa destination? 
            {
               // enemi passe de point en point ( quand il arrive au dernier il fait le chemin inverse )
               if(playerDirection.x >0)
                {
                    waypointIndex += 1; 

                    if(waypointIndex <= waypoints.Length - 1)
                    {
                        targetPatrol = waypoints[waypointIndex];
                    }

                    else
                    {
                        waypointIndex -= 1 ;
                        targetPatrol = waypoints[waypointIndex];
                    }

                }

                else if (playerDirection.x <0)
                {
                    waypointIndex -= 1; 

                    if(waypointIndex >= 0)
                    {
                        targetPatrol = waypoints[waypointIndex];
                    }

                    else
                    {
                        waypointIndex += 1; 
                        targetPatrol = waypoints[waypointIndex];
                    }
                }
            }
        }
    }

    private void GetPlayerDirection()// orientation de l'enemi
    {
        // vers le player
        playerDirection = (Player.transform.position - transform.position).normalized;

        if (playerDirection.x > 0)
        {
            spriteDirection = 1; 
        }

        else
        {
            spriteDirection = -1;
        }

        transform.localScale = new Vector3(spriteDirection, 1, 1);
    }

    private void GetWaypointDirection()
    {
        playerDirection = (targetPatrol.position - transform.position).normalized;

        if ( playerDirection.x > 0)
        {
            spriteDirection = 1;
        }
        else
        {
            spriteDirection = -1;
        }
        transform.localScale = new Vector3(spriteDirection, 1, 1);
    }

    // trigger de l'enemi pour follow le player

    private void OnTriggerStay2D(Collider2D collision)
    {
        ispatroling = false;
        GetPlayerDirection();
        transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);

    }

    // l'enemi recommence a pattrouiller quand il ne detecte plus le player

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ispatroling = true;
        GetWaypointDirection();
    }
}
