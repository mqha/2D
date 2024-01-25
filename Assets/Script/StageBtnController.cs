using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageBtnController : MonoBehaviour
{
    



    public void OnHomeBtnClicked()
    {
        SceneManager.LoadScene("MainMenu");
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


}
