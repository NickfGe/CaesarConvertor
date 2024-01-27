using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Caesar : MonoBehaviour
{
    public static Caesar Instance;
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else Destroy(this);
    }

    public string Encrypt(string input, int key)
    {
        char[] originalCharacters = input.ToCharArray();
        char[] ciphedCharacters = new char[originalCharacters.Length];

        for (int i = 0; i < originalCharacters.Length; i++)
        {
            char originalChar = originalCharacters[i];

            if (char.IsLetter(originalChar))
            {
                // Diferenciar entre Upper y Lower
                string actualLetter = char.IsUpper(originalChar) ? alphabet : alphabet.ToLower();

                int originalIndex = actualLetter.IndexOf(originalChar);

                int ciphedIndex = (originalIndex + key) % alphabet.Length;      // Aplicar el desplazamiento y manejar el desbordamiento

                if (ciphedIndex < 0) ciphedIndex += alphabet.Length;

                ciphedCharacters[i] = actualLetter[ciphedIndex];
            }
            else ciphedCharacters[i] = originalChar;    // Mantener caracteres no alfabéticos sin cambios
        }

        return new string(ciphedCharacters);
    }

    public string Decrypt(string input, int key) 
    {
        return Encrypt(input, -key);
    }
}
