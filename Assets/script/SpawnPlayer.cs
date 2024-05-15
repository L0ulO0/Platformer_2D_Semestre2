using UnityEngine;

public class SpawnPlayer : MonoBehaviour


    
{

    [SerializeField] checkpoint PlayerSpawn;
    private void Awake()
    {
        // checkpoint.PlayerSpawn.position = transform.position;
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }

}
