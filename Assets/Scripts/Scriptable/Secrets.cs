using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Secrets", menuName = "Secrets")]
public class Secrets : ScriptableObject
{
    public int id;
    public string title;
    [TextArea(2, 5)]
    public string discription;
}
