using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinematique_Out : MonoBehaviour
{
    public float changeTime;


    private void Update()
    {

        changeTime -= Time.deltaTime;

        if (changeTime < -0)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
