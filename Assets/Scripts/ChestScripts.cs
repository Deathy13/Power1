using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class ChestScripts : MonoBehaviour
{
    public GameObject chest;
    public GameObject firstLight;
    public GameObject secondLight;    
    public CameraSC cameraSC;    
    public UIManager uimanger;
    public GameObject particalSystem;
    public Animator anim;
    public int ID;

    void Start()
    {
        cameraSC = GameObject.Find("Main Camera").GetComponent<CameraSC>();
        uimanger = GameObject.Find("UIManager").GetComponent<UIManager>();
        secondLight.SetActive(false);
        chest.SetActive(false);
    }

    void OnMouseEnter()
    {
        Debug.Log("IToch chest");
        firstLight.SetActive(true);

    }
    void OnMouseExit()
    {
       
        firstLight.SetActive(false);
    }
   public void ChestVisble()
    {
        secondLight.SetActive(true);
        chest.SetActive(true);
        uimanger.OpenWindow();
        uimanger.idOfChest = ID;
        uimanger.chest = this;
    }
  public void ReviledTheChest()
    {
        ChestVisble();
        anim.SetBool("ChestOpen", true);
        particalSystem.SetActive(true);
    }

}
