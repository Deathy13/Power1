using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revolation : MonoBehaviour
{
    public Secrets[] secrets;
    
    public Text title;
    public Text discription;
    public UIManager uIManager;
    public int currentSecret = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //currentSecret = uIManager.idOfChest;
        
        title.text = secrets[currentSecret].title;
        discription.text = secrets[currentSecret].discription;
    }
}
