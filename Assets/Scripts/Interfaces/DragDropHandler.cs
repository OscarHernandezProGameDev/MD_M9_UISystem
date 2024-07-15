using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropHandler : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private Vector2 originalPosition;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        Debug.Log($"Potential drag initialized on: {gameObject.name}");

        // Actualizar la posición original del objeto
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log($"Drag started on: {gameObject.name}");

        canvasGroup.alpha = 0.6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log($"Dragging started on: {gameObject.name}");

        // canvas.scaleFactor => para ajusta el cambio posición a la escala de la pantalla y permite que el movimiento sea consistente
        // sea que sea la resolució de la pantalla
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log($"Dragging ended on: {gameObject.name}");

        canvasGroup.alpha = 1;
        // Actualizar la posición del objeto
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log($"Object Dropped on: {gameObject.name}");
    }
}
