using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_Start : MonoBehaviour
{
    public void PlayButton()
    {

        SceneManager.LoadScene("SCN_Niveau1");
        Debug.Log("load");
    }
}
