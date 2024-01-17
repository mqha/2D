using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startHealth;
    [SerializeField] private GameObject player;

    public System.Action onDead;
    public System.Action onLive;
    public float currentHealth { get; private set; }
    private Animator anim;

    public bool playerLive = true;


    private void Awake()
    {
        currentHealth = startHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startHealth);


        if(currentHealth > 0)
        {
            anim.SetTrigger("Hurt");
        }
        else
        {
            playerLive = false;
            Die();
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            playerLive = false;
            Die();
        }
        else

        if (collision.CompareTag("EndGame") || player == null)
        {
            playerLive = false;
            WinGame();
        }
    }

    protected virtual void Die()
    {
        anim.SetTrigger("Die");
        Destroy(gameObject);
        onDead?.Invoke();
    }

    protected virtual void WinGame()
    {
        Destroy(gameObject);
        onLive?.Invoke();
    }
}
