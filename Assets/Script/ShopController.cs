using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopController : MonoBehaviour
{
    [SerializeField] private Image selectedSkin;
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private SkinManager skinManager;

    private void Update()
    {
        coinsText.text = PlayerPrefs.GetInt("PlayerCoins").ToString();
        selectedSkin.sprite = skinManager.GetSelectedSkin().sprite;
    }

    public void LoadMenu() => SceneManager.LoadScene("Stage1");
}
