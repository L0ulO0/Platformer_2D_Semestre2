using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_Manager : MonoBehaviour
{

    public Text nametext;
    public Text dialoguetext;

    public static Dialogue_Manager Instance;
    private void Awake()
    {
        if(Instance!= null)
        {
            Debug.LogWarning("il y a plus d'une instance de Dialogue dans la scéne");
            return;
        }
        Instance = this;
    }
}
