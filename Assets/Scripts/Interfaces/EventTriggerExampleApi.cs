using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerExampleApi : MonoBehaviour
{
private EventTrigger EventTrigger;

    // Start is called before the first frame update
    void Start()
    {
        EventTrigger=gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener(data=>OnPointerEnter((PointerEventData)data));
        EventTrigger.triggers.Add(entry);

        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerExit;
        entry.callback.AddListener(data=>OnPointerExit((PointerEventData)data));
        EventTrigger.triggers.Add(entry);
    }

    void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
    }

    void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
    }
}
