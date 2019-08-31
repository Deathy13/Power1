using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret : Entity
{
    string script;
    
    bool hidden   = true;
    bool revealed = false; 

    public Secret(string script, string id, int x, int y) : base(id, x, y)
    {
        this.script = script;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
