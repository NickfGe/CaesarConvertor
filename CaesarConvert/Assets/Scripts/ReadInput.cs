using System;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public Text input;
    public Text key;
    public InputField output;

    public void CaesarEncrypt()
    {
        output.text = Caesar.Instance.Encrypt(input.text, Convert.ToInt32(key.text));
    }

    public void CaesarDecrypt()
    {
        output.text = Caesar.Instance.Decrypt(input.text, Convert.ToInt32(key.text));
    }
}
