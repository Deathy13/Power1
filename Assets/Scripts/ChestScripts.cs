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
    public int ID;


    private void Awake()
    {
        cameraSC = GameObject.Find("Main Camera").GetComponent<CameraSC>();
        uimanger = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void start()
    {
        chest.SetActive(false);
        
        


    }


    void Update()
    {       
        ChestVisble1();        
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
    void ChestVisble1()
    {
        if (cameraSC.chestSelected)
        {
            
            secondLight.SetActive(true);           
            chest.SetActive(true);
            uimanger.revil = true;
            uimanger.idOfChest = ID;

        }
        else
        {
            secondLight.SetActive(false);
            chest.SetActive(false);

        }
    }
  

}
