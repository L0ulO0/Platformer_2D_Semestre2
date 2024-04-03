using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    [SerializeField] Collider2D CheckpointCollider;
    [SerializeField] public Vector2 lastCheckPointPos;

    static GameMaster instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        else
        {
            Destroy(gameObject); 
        }
    }
}
