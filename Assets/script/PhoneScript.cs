using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScript : MonoBehaviour
{

    [SerializeField] GameObject MainPhone;
    [SerializeField] GameObject Message1;
   // [SerializeField] GameObject Message2;
    [SerializeField] GameObject Galerie;
    [SerializeField] GameObject options;
    [SerializeField] GameObject parametre;
    [SerializeField] GameObject backButton;

    public void MessageButton()
    {
        MainPhone.SetActive(false);
        Message1.SetActive(true);
        
       // if(other.Comparetag) comparer le compare tag pour afficher le message ou non

    }

    public void GalerieButton()
    {
        MainPhone.SetActive(false);
        Galerie.SetActive(true);
    }

    public void OptionsButton()
    {
        MainPhone.SetActive(false);
        options.SetActive(true);    
    }

    public void ParametreButton()
    {
        MainPhone.SetActive(false);
        parametre.SetActive(true);
    }

   /*/ public void BackButton()
    {
        MainPhone.SetActive(true);
        Message1 .SetActive(false);
        Message2.SetActive(false);
        options.SetActive(false);
        Galerie .SetActive(false);
        parametre .SetActive(false);
    }*/
}
