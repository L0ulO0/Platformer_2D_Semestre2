using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2_loader : MonoBehaviour
{
   

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("SCN_Niveau2");
        Debug.Log("load");
    }
}
