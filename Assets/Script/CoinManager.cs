using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered = false;

    private GameManager coinCounter;

    private void Start()
    {
        coinCounter = GameManager.instance;
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
