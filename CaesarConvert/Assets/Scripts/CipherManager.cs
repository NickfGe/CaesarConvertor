using UnityEngine;
using System;
using UnityEngine.UI;

public class CipherManager : MonoBehaviour
{
    public InputField input;
    public InputField key;
    public InputField output;

    public void Cipher()
    {
        output.text = Caesar.Instance.Encrypt(input.text, Convert.ToInt32(key));
    }

    public void Uncipher()
    {
        output.text = Caesar.Instance.Decrypt(input.text, Convert.ToInt32(key));
    }

    public void Copy()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = input.text;
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
