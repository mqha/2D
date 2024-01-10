using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;

    private CoinCounter coinCounter;

    private void Start()
    {
        coinCounter = CoinCounter.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasTriggered = true;
            coinCounter.ChangeCoins(value);
            Destroy(gameObject);
        }
    }
}
