using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    const int GRID_X = 8;
    const int GRID_Y = 8;

    // public Grid[,] grid = new Grid[GRID_X][GRID_Y];
    
    public LinkedList<Character> characters;
    public LinkedList<Secret> secrets;
    //LinkedList<int> list = new LinkedList<int>();
    // list.AddLast(6);
    // Start is called before the first frame update
    void Start()
    {
        // grid[x,y];
        // Load characters
        // Load secrets
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
