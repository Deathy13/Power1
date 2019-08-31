using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSC : MonoBehaviour


{

    public Camera mainCamera;
    public bool itHitHrid;
    public bool chestSelected;

    // Start is called before the first frame update
    void Awake()
    {
        mainCamera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Grid")
        {
            Debug.Log("I on Grid");

        }
        if (Input.GetMouseButtonDown(0))
        {
            
            
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Chest")
            {
                chestSelected = true;
            }
        }
    }
}
