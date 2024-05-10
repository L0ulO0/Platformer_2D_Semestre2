
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private Transform PlayerSpawn;

    private void Awake()
    {
        PlayerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn ").transform;
    }

   private void OnTriggerEnter2D (Collider2D collision)
    {

    }
}
