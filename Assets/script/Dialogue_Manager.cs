using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{
    [SerializeField] mouvement Mouvement;

    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dialoguetext;

    public Animator animator;

    private Queue<string> sentences;

    public static Dialogue_Manager Instance;


    private void Awake()
    {
        if(Instance!= null)
        {
            Debug.LogWarning("il y a plus d'une instance de Dialogue dans la scéne");
            return;
        }
        Instance = this;

        sentences = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("BoolOpen", true);

        nametext.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

       
        Mouvement.CanMouv = false;
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialoguetext.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {

        animator.SetBool("BoolOpen", false); 
        Mouvement.CanMouv = true;
        Debug.Log("Fin du dialogue");
    }
}
