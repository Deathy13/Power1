using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeakerUI : MonoBehaviour
{

    public Image portrait;
    public Text fullName;
    public Text dialog;

    private Charecter speaker;
    public Charecter Speker
    {
        get { return speaker; }
        set
        {
            speaker = value;
            portrait.sprite = speaker.portait;
            fullName.text = speaker.fullName;
        }
    }

    public string Dialog
    {
        set { dialog.text = value; }
    }
    public bool HasSperker()
    {
        return speaker != null;
    }
    public bool SpeakerIs(Charecter character)
    {
        return speaker == character;
    }
    public void show()
    {
        gameObject.SetActive(true);
    }
    public void hide()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
   
}
