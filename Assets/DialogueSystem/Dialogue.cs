using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Scriptable Objects/Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    [Multiline]
    private string content;

    internal void Display(TMP_Text textBox)
    {
        textBox.text = content;
    }
}
