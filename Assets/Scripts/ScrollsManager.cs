using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollsManager : MonoBehaviour
{
    public RectTransform myContent;
    public ScrollRect myScrollView;
    public RectTransform targetElemnent;


    // Start is called before the first frame update
    void Start()
    {
        FocusOnElement(targetElemnent);
    }

    void FocusOnElement(RectTransform element)
    {
        // Obtener la posición del elemento en el espacio contenido
        // InverseTransformDirection => posicion del elemento al espacio local
        Vector2 contentPosition = myContent.InverseTransformDirection(element.position);

        // Calcular el desplazamiento necesario para centrar el elemento
        Vector2 targetPosition =
            new Vector2
            (
                // para centrar el eje X
                // contentPosition.x - myScrollView.viewport.rect.width / 2 + element.rect.width / 2
                0,
                contentPosition.y - myScrollView.viewport.rect.height / 2 + element.rect.height / 2
            );

        // Ajustar la posicion del contenido para enfocar el elemento
        myContent.anchoredPosition = -targetPosition;
    }
}
