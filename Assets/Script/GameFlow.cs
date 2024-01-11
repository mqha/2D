using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject bgMusic;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject cameraMove;


    void Start()
    {
        gameOverUI.SetActive(false);
        playerController.onDead += OnGameOver;
    }

    
    public void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
}
