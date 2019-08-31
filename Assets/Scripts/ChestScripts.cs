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
    public GameObject choise1;
    public UIManager uimanger;
    public GameObject particalSystem;

    // Start is called before the first frame update

    //UnityEvent m_MyEvent = new UnityEvent();


    void Start()
    {
        chest.SetActive(false);
        cameraSC = GameObject.Find("Main Camera").GetComponent<CameraSC>();        
        uimanger = GameObject.Find("UIManager").GetComponent<UIManager>();
       // m_MyEvent.AddListener(ShowMenu);

    }

    //public void ShowMenu(event)
    //{
    //    if (Event.show)
    //    {
    //        UIShowUp = false;
    //    } else
    //    {
    //        UIShowUp = true;
    //    }
    //
    //}

    // Update is called once per frame
    void Update()
    {       
        ChestVisble1();        
    }
    void OnMouseEnter()
    {
        cameraSC.itHitGrid = true;
        
        if(cameraSC.itHitGrid)
        {
            Debug.Log("isMouseEnteris on chest");
            firstLight.SetActive(true);
        }
        else
        {
            firstLight.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        cameraSC.itHitGrid = false;
    }







    void ChestVisble1()
    {
        if (cameraSC.chestSelected && uimanger.secret1 == false)
        {
            
            secondLight.SetActive(true);

            chest.SetActive(true);
            choise1.SetActive(true);
            
        }
        else
        {
            firstLight.SetActive(false);
             
        }
    }


    public void RevelSecrets1()
    {
        choise1.SetActive(false);
        uimanger.secret1 = true;
        cameraSC.chestSelected = false;
        particalSystem.SetActive(true);
    }
    public void NotRevelSecrets1()
    {
        choise1.SetActive(false);
        cameraSC.chestSelected = false;
    }

}
