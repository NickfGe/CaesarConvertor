using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caesar : MonoBehaviour
{
    public static Caesar Instance;

    private void Awake()
    {
        Instance = this;
    }

    public string Encrypt(string text, int keyValue)
    {
        string alphabet = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        int alphabetLenght = alphabet.Length;

        char[] originalCharacters = text.ToUpper().ToCharArray();
        char[] ciphedCharacters = new char[originalCharacters.Length];

        for (int i = 0; i < originalCharacters.Length; i++)
        {
            char originalChar = originalCharacters[i];

            if (char.IsLetter(originalChar))
            {
                int originalIndex = alphabet.IndexOf(originalChar);

                // Aplicar el desplazamiento y manejar el desbordamiento
                int ciphedIndex = (originalIndex + keyValue) % alphabetLenght;

                if (ciphedIndex < 0) ciphedIndex += alphabetLenght;

                ciphedCharacters[i] = alphabet[ciphedIndex];
            }
            else ciphedCharacters[i] = originalChar;
        }
        return new string(ciphedCharacters);
    }

    public string Decrypt(string ciphedText, int keyValue) { return Encrypt(ciphedText, -keyValue); }
}
