using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int coins; 

    [SerializeField] private TMP_Text coinDisplay;

    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    private PlayerController playerController;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void Start()
    {
        LoadCoins();
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerController = FindObjectOfType<PlayerController>();
        
    }
    private void Update()
    {
        playerController.onDead += OnGameOver;
        playerController.onLive += OnGameWin;

    }

    private void OnGUI()
    {
        coinDisplay.text = coins.ToString();
    }

    public void ChangeCoins(int amout)
    {
        coins += amout;
        SaveCoins();
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("PlayerCoins", coins);
        PlayerPrefs.Save();
    }

    private void LoadCoins()
    {
        coins = PlayerPrefs.GetInt("PlayerCoins", 0);
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