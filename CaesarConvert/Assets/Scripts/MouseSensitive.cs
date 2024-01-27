using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MouseSensitive : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private int Id;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Id == 0) SceneManager.LoadScene("Encrypt");
        if (Id == 1) SceneManager.LoadScene("Decrypt");
        if (Id == 2) Application.Quit();
        if (Id == 3) SceneManager.LoadScene("Main");
        if (Id == 10) return;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.transform.localScale = new Vector3(1.12f, 1.12f, 1.12f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }
}
