using System.Collections;
using System.Collections.Generic;
using UnityEditor.Events;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] private Button myButton;

    void Start()
    {
        UnityEventTools.RemovePersistentListener(myButton.onClick, 1);
        myButton.onClick.AddListener(Action4);
        myButton.onClick.AddListener(Action5);
        myButton.onClick.AddListener(() => Action(10));
        myButton.onClick.RemoveListener(Action4);
    }

    public void Action1()
    {
        print("Action 1");
    }

    public void Action2()
    {
        print("Action 2");
    }

    public void Action3()
    {
        print("Action 3");
    }

    public void Action4()
    {
        print("Action 4");
    }

    public void Action5()
    {
        print("Action 5");
    }

    public void Action(int number)
    {
        print($"Action: {number}");
    }
}
