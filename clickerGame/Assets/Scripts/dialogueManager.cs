using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dialogueManager : MonoBehaviour
{
    public menuManager menuManager;
    public TextMeshProUGUI dialogueNameElement;
    public TextMeshProUGUI dialogueTextElement;
    public GameObject dialogueGameObject;


    private Queue<string> dialogueLines;

    private void Start()
    {
        dialogueLines = new Queue<string>();
    }
    public void startDialogue(dialogueComponent dialogue)
    {
        menuManager.isMenuOpened = true;
        dialogueLines.Clear();

        foreach (var sentence in dialogue.speakerLines)
        {
            dialogueLines.Enqueue(sentence);
        }

        dialogueNameElement.text = dialogue.speakerName;
        displayNextSentence();
        dialogueGameObject.SetActive(true);
    }
    public void displayNextSentence()
    {
        if (dialogueLines.Count <= 0)
        {
            endDialogue();
        }
        else
        {
            string currentSentence = dialogueLines.Dequeue();
            dialogueTextElement.text = currentSentence;
        }
    }
    private void endDialogue()
    {
        Debug.Log("Ending dialogue.");
        menuManager.isMenuOpened = false;
        dialogueGameObject.SetActive(false);
    }
}
