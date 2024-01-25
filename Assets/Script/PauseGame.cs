using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject gamePauseUI;

    private void Start()
    {
        gamePauseUI.SetActive(false);
    }

    public void PausingGame()
    {
        gamePauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        gamePauseUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
