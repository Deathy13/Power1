using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialugoeTrigger : MonoBehaviour
{
    public Dialugoe dialugoe;
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialugoe);
    }
}
