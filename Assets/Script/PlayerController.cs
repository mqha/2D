using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Character player;

    public System.Action onDead;
    public System.Action onLive;


    void Start()
    {
        player = Init.player;
    }


    void Update()
    {
        player.Update();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            
            Die();
            Destroy(gameObject);
        }
        else if (collision.CompareTag("EndGame"))
        {
            WinGame();
            Destroy(gameObject);
        }
    }

    protected virtual void WinGame()
    {
        Destroy(gameObject);
        onLive?.Invoke();
    }

    protected virtual void Die()
    {

        Destroy(gameObject);
        onDead?.Invoke();
    }



}
