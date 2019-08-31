using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public Charecter charecter;
    [TextArea(2, 5)]
    public string text;

}


[CreateAssetMenu(fileName = "new Conversation",menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public Charecter speakerLeft;
    public Charecter speakerRight;
    public Line[] lines;
}
