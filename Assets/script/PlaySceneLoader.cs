using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_Start : MonoBehaviour
{

    [SerializeField] GameObject MainCanvas;
    [SerializeField] GameObject OptionCanvas;
    [SerializeField] GameObject Pancarte;
    public void PlayButton()
    {

        SceneManager.LoadScene("Cineamtique_1");
        Debug.Log("load");
    }

    public void Option()
    {
        MainCanvas.SetActive(false);
        Pancarte.SetActive(false);
        OptionCanvas.SetActive(true);
    }

    public void Back()
    {
       // MainCanvas.SetActive(true);
       // Pancarte.SetActive(true);
        //OptionCanvas.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
