using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    private int coins;

    [SerializeField] private TMP_Text coinDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void OnGUI()
    {
        coinDisplay.text = coins.ToString();
    }

    public void ChangeCoins(int amout)
    {
        coins += amout;
    }

}
