
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    [SerializeField] SpawnPlayer spawnplayer; 
    [SerializeField] private Vector2 Respawn;

    [SerializeField] Transform IA;
    [SerializeField] Transform RespawnIA;


    void Start()
    {
        spawnplayer.transform.position = transform.position;
        //Respawn = transform.position;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("CheckPoint"))
        {


            Respawn = transform.position;
            Debug.Log(" REZZ");


        }
        else if (other.gameObject.CompareTag("Thorn") || other.gameObject.CompareTag("Prefab_ia"))
        {

            transform.position = Respawn;

            Debug.Log(" REZZ");
            IA.transform.position = RespawnIA.transform.position; 
          

        }

    }

}
