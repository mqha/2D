using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{

     Text counterText;
    
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    
    void Update()
    {
        if (counterText.text != CoinManager.totalCoins.ToString())
        {
            counterText.text = CoinManager.totalCoins.ToString();
        }
    }
}
