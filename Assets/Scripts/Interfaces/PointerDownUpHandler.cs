using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class PointerDownUpHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        text.color = Color.blue;

        Debug.Log($"El puntero ha hecho click en el objeto: {eventData.pointerCurrentRaycast.gameObject.name}");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        text.color = Color.green;

        Debug.Log($"El puntero ha soltado el click en el objeto: {eventData.pointerCurrentRaycast.gameObject.name}");
    }
}
