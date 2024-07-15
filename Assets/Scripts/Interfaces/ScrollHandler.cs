using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEditor;

public class ScrollHandler : MonoBehaviour, IScrollHandler
{
    private RectTransform rectTransform;
    private int currentNumber;

    public TextMeshProUGUI textComponent;
    public float scrollSpeed = 10f;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Start()
    {
        if (textComponent is not null)
            int.TryParse(textComponent.text, out currentNumber);
    }

    public void OnScroll(PointerEventData eventData)
    {
        float scrollDelta = eventData.scrollDelta.y;

        if (textComponent is not null)
        {
            currentNumber += Mathf.RoundToInt(scrollDelta * scrollSpeed);
            textComponent.text = currentNumber.ToString();
        }
        else
        {
            print("Detecta el scroll");

            rectTransform.anchoredPosition -= new Vector2(0, scrollDelta * scrollSpeed);
        }
    }
}
