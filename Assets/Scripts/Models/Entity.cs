using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public string id;
    public int x;
    public int y;

    public Entity(string id, int x, int y)
    {
        this.id = id;
        this.x  = x;
        this.y  = y;
    }


    public string getId()
    {
        return id;
    }

    // public string function getType()
    // {
    //     // TODO
    //     return "asd";
    // }

    public int[] getPositionArray()
    {
        int[] position = {x, y};

        return position;
    }

    public void getRelatedEntities()
    {
        // Returns a collection of things
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
