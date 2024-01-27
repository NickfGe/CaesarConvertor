using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clipboard : MonoBehaviour
{
    public static Clipboard Instance;
    public InputField input;
    public InputField output;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else Destroy(this);
    }

    public void Copy()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = output.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }

    public void Paste()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.multiline = true;
        textEditor.Paste();
        input.text = textEditor.text;
    }
}
