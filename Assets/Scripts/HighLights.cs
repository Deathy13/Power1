using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLights : MonoBehaviour
{
    public GameObject highLight;
    public bool onHighLight;

    // Start is called before the first frame update
    void Start()
    {
        highLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Highlight();
    }
    void Highlight()
    {
        if (onHighLight)
        {
            highLight.SetActive(true);
        }
        else
        {
            highLight.SetActive(false);
        }
    }
    void OnMouseEnter()
    {
        onHighLight = true;
        Debug.Log("isMouseEnter");
    }
    void OnMouseExit()
    {
        onHighLight = false;
    }
}
