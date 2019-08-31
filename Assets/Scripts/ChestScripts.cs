using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScripts : MonoBehaviour
{
    public GameObject chest;
    public GameObject chestLights;
    public GameObject secondLight;
    public GameObject menu;

    public Camera m_Camera;

    public bool isVisible;
    public bool secretsIsReviled;
    // Start is called before the first frame update
    void Start()
    {
        chest.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        ChestVisble();
        Selected();
    }
    void ChestVisble()
    {
        if (isVisible)
        {
            chestLights.SetActive(true);
        }
        else
        {
            chestLights.SetActive(false);
        }
    }
    void OnMouseEnter()
    {
        isVisible = true;
        Debug.Log("isMouseEnteris on chest");
    }
    void OnMouseExit()
    {
        isVisible = false;
    }


    void Selected()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Chest")
            {
                Debug.Log("ClickChest");
                chest.SetActive(true);
                secondLight.SetActive(true);
                if (!secretsIsReviled)
                {
                    menu.SetActive(true);
                }

            }
        }

    }
    void secretSelected()
    {
        
        chest.SetActive(true);
        secondLight.SetActive(true);
        if (!secretsIsReviled)
        {
            menu.SetActive(true);
        }
        menu.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Chest")
            {
                Debug.Log("ClickChest");
                
                if (!secretsIsReviled)
                {
                    
                }

            }
        }

    }
    public void ShowSecrets()
    {
        secretsIsReviled = true;
        menu.SetActive(false);
    }
    public void DontShowSecrets()
    {
        menu.SetActive(false);
    }
}
