using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageBtnController : MonoBehaviour
{
    [SerializeField] private GameObject gamePauseUI;

        private void Start()
    {
        gamePauseUI.SetActive(false);
    }

    public void OnHomeBtnClicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnReturnBtnClicked()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void Stage2BtnClicker()
    {
        SceneManager.LoadScene(4);
    }

    public void Stage3BtnClicker()
    {
        SceneManager.LoadScene(5);
    }

    public void PauseGame()
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
