using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    const int GRID_X = 8;
    const int GRID_Y = 8;

    public GameObject grid;
    public GameObject secret;
    public Transform gridPlace;

    // public Grid[,] grid = new Grid[GRID_X, GRID_Y];
    
    public LinkedList<Character> characters;
    public LinkedList<Secret> secrets;
    //LinkedList<int> list = new LinkedList<int>();
    // list.AddLast(6);
    // Start is called before the first frame update
    void Start()
    {
        DrawGrid(GRID_X, GRID_Y);
        DrawSecrets();
        // Load characters
        // Load secrets
    }

    void DrawGrid(int x, int y)
    {
        for (int i = 0; i < x; i++) {
            for (int j = 0; j < y; j++) {
                GameObject g = Instantiate(grid, gridPlace.position + new Vector3(i, 0, j), Quaternion.identity);
                g.transform.parent = gridPlace.transform;
            }
        }

        gridPlace.transform.Rotate(0, -45, 0);
    }

    void DrawSecrets()
    {
        GameObject g = Instantiate(secret, gridPlace.position, Quaternion.identity);
        g.transform.parent = gridPlace.transform;

        GameObject g1 = Instantiate(secret, gridPlace.position + new Vector3(1, 0, 1), Quaternion.identity);
        g1.transform.parent = gridPlace.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
