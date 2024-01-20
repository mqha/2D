using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    [SerializeField] private Health playerController;
    [SerializeField] private GameObject cameraMove;


    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerController.onDead += OnGameOver;
        playerController.onLive += OnGameWin;
    }



    public void OnGameOver()
    {
        gameOverUI.SetActive(true);

    }

    public void OnGameWin()
    {
        gameWinUI.SetActive(true);

    }

}
