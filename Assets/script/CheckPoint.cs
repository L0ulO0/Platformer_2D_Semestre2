
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    [SerializeField] private Vector2 Respawn;

    [SerializeField] Transform IA;
    [SerializeField] Transform RespawnIA;


    void Start()
    { 

        Respawn = transform.position;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("CheckPoint"))
        {


            Respawn = transform.position;


        }
        else if (other.gameObject.CompareTag("Thorn") || other.gameObject.CompareTag("Prefab_ia"))
        {

            transform.position = Respawn;

            IA.transform.position = RespawnIA.transform.position; 
          

        }

    }

}
