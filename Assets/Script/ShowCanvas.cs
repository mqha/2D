using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    [SerializeField]public GameObject canvasToShow;

    void Start()
    {
        canvasToShow.SetActive(false);
    }

    public void ShowCanvasMusic()
    {
        canvasToShow.SetActive(true);
    }

    public void HideCanvasMusic()
    {
        canvasToShow.SetActive(false);
    }
}
