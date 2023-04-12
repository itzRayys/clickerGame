using UnityEngine;
using UnityEngine.EventSystems;

public class buttonTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject buttonText;


    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonText.SetActive(true);
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonText.SetActive(false);
    }
}
