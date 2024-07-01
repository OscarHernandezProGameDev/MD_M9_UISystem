using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagesManager : MonoBehaviour
{
    [SerializeField] private Image ImageExample;
    [SerializeField] private Sprite display, logo, coins;

    void Start()
    {
        ImageExample.sprite = logo;
    }
}
