using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageScene : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnGoButtonClicked()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void SelectStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void SelectStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void SelectStage3()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void OnLeaderboardclick()
    {
        SceneManager.LoadScene(6);
    }


}
