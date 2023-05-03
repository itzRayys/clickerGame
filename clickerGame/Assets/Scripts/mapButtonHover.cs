using UnityEngine;
using UnityEngine.EventSystems;

public class mapButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [Header("Button Things")]
    public GameObject buttonText;
    public GameObject buttonImageGlow;
    public RectTransform buttonImageTransform;
    public GameObject buttonYouAreHere;



    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonText.SetActive(true);
        buttonImageGlow.SetActive(true);
        buttonImageTransform.localScale = new Vector2(1.1f, 1.1f);
    }
    public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonText.SetActive(false);
        buttonImageGlow.SetActive(false);
        buttonImageTransform.localScale = new Vector2(1f, 1f);
    }
}
