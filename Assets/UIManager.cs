using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject choice;
    public DialogDisplay dialog;

    public bool revil;
    public int idOfChest;

    public void Update()
    {
        if (revil)
        {
            choice.SetActive(true);
        }
    }

    public void CloseWindow()
    {
        choice.SetActive(false);
    }
    public void ShowDialoge()
    {
        choice.SetActive(false);
        dialog.AdvanceConversation();
    }
    public void FowrwardConversation()
    {
        dialog.AdvanceConversation();
    }

}
