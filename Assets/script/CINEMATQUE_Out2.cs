using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CINEMATQUE_Out2 : MonoBehaviour
{
    public float changeTime;


    private void Update()
    {

        changeTime -= Time.deltaTime;

        if (changeTime < -0)
        {
            SceneManager.LoadScene("SCN_NiveauTuto");
        }

    }
}
