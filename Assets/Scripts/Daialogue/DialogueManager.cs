using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    
    public Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialugoe dialogue)
    {
        Debug.Log("string conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDiaogue();
            return ;            
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
    void EndDiaogue()
    {
        Debug.Log("end of Conversation");
    }
}
