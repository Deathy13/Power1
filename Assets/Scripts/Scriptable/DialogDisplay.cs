using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    public SpeakerUI speakerUILeft;
    public SpeakerUI speakerUIRight;

    private int activeLineIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        speakerUILeft = speakerUILeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerUIRight.GetComponent<SpeakerUI>();

        speakerUILeft.Speker = conversation.speakerLeft;
        speakerUIRight.Speker = conversation.speakerRight;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            AdvanceConversation();
        }
    }
    void AdvanceConversation()
    {
        if(activeLineIndex <conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUILeft.hide();
            speakerUIRight.hide();
            activeLineIndex = 0;
        }
        
    }
    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Charecter character = line.charecter;
        if(speakerUILeft.SpeakerIs(character))
        {
            SetDialog(speakerUILeft, speakerUIRight, line.text);
        }
        else
        {
            SetDialog(speakerUIRight, speakerUILeft, line.text);
        }
    }
    void SetDialog(
        SpeakerUI activeSpeakerUI,
        SpeakerUI inactiveSpeakerUI,
        string text)
    {
        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.show();
        inactiveSpeakerUI.hide();
    }
}
