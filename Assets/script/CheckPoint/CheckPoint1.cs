
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint1 : MonoBehaviour
{
    [SerializeField] private Vector2 Respawn;

   // [SerializeField] Transform IA;
   // [SerializeField] Transform RespawnIA;


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
       if (other.gameObject.CompareTag("Thorn") || other.gameObject.CompareTag("Prefab_ia"))
        {
           // PlayerSpawn.position = transform.position;
            Debug.Log("New Spawn");
            SceneManager.LoadScene("SCN_Niveau1");
        }

    }

}
