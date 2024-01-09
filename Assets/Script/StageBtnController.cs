using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageBtnController : MonoBehaviour
{
    public void OnHomeBtnClicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnReturnBtnClicked()
    {
        SceneManager.LoadScene("Stage1");
    }
}
