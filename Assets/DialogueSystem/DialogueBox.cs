using System;
using TMPro;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;
    internal void SetText(string content)
    {
        text.text = content;
    }
}
