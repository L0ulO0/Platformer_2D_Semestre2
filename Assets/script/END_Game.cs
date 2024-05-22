using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END_Game : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Cineamtique_2");
        Debug.Log("load");
    }
}
