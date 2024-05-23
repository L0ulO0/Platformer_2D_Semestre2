using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

public class DialogueManager : MonoBehaviour
{
    public DialogueTrigger DialogueTrigger;
    public Animator animator;
    public TMP_Text nameText;
    public TMP_Text DialogueText;
    private Queue<string> sentences;

    public static DialogueManager instance;

    private void Awake()
    {
        instance = this;
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        // CAN MOVE TO FALSE
        animator.SetBool("BoolOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }



    public void DisplayNextSentences()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


        IEnumerator TypeSentence(string sentence)
        {
            DialogueText.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                DialogueText.text += letter;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }
    public void EndDialogue()
    {
        // CAN MOVE A TRUE
        animator.SetBool("BoolOpen", false);
        DialogueTrigger.dialogueUI.SetActive(false);
        DialogueTrigger.dialogueStarted = false;
    }
}