using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{

    public TextMeshPro nametext;
    public TextMeshPro dialoguetext;

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
