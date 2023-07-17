using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogueComponent dialogue;

    public void triggerDialogue()
    {
        FindObjectOfType<dialogueManager>().startDialogue(dialogue);
    }
}
