using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerEnterExitHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;
    private Color originalColor = Color.white;
    private Color darkestColor;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        darkestColor = image.color;
        image.color = originalColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = darkestColor;
    }
}
