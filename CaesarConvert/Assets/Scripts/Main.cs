using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void EncryptScene() { SceneManager.LoadScene("Encrypt"); }
    public void DecryptScene() { SceneManager.LoadScene("Decrypt"); }
}
