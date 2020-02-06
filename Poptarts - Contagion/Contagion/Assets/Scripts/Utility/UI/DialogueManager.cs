using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Queue<string> sentences;

    public GameObject start;
    public GameObject yes;
    public GameObject no;
    public GameObject contin;
    public static bool tutorial;

    public Animator animator;

    // Start is called before the first frame update
    void Start() {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;
        sentences.Clear();
        if (SceneManager.GetActiveScene().name.Equals("LabMenu") || SceneManager.GetActiveScene().name.Equals("Lab")) {
            //start.SetActive(false);
        }

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        if (SceneManager.GetActiveScene().name.Equals("LabMenu") && sentences.Count == 0)
        {
            //contin.SetActive(false);
            yes.SetActive(true);
            //no.SetActive(true);

        }
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    public void EndDialogue() {
        animator.SetBool("IsOpen", false);
        //Debug.Log("End of conversation");
    }

}
