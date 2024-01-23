using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered = false;

    [SerializeField] private GameObject coinExplosion;

    private GameManager coinCounter;

    private void Start()
    {
        coinCounter = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoint();
            hasTriggered = true;
            coinCounter.ChangeCoins(value);
            CoinExplosion();
            AudioManager.Instance.PlaySFX("Coin");
            
        }
    }

    private void CoinExplosion()
    {
        var explosion = Instantiate(coinExplosion, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);

    }
}
