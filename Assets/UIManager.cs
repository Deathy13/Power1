using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    
    public bool secret1;
    public bool secret2;
    public bool secret3;

    public void Update()
    {
        if(secret1)
        {
            Debug.Log("Secrets");
        }
    }

}
