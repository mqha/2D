using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int maxHealth;
    private float currentHealth;

    public System.Action onDead;
    public System.Action onLive;

    public Health(int maxHealth)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }

    private void Die()
    {

        Destroy(gameObject);
        onDead?.Invoke();
    }



    //[SerializeField] private float startHealth;
    //Character playerStartHealth;

    //public System.Action onDead;
    //public System.Action onLive;
    //public float currentHealth { get; private set; }
    //private Animator anim;

    //public bool playerLive = true;


    //private void Awake()
    //{

    //    currentHealth = startHealth;
    //    anim = GetComponent<Animator>();
    //}

    //public void TakeDamage(float _damage)
    //{
    //    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startHealth);


    //    if(currentHealth > 0)
    //    {
    //        anim.SetTrigger("Hurt");
    //    }
    //    else
    //    {
    //        playerLive = false;
    //        Die();

    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Trap"))
    //    {
    //        playerLive = false;
    //        Die();
    //    }
    //    else

    //    if (collision.CompareTag("EndGame") || player == null)
    //    {
    //        playerLive = false;
    //        WinGame();
    //    }
    //}

    //protected virtual void Die()
    //{
    //    anim.SetTrigger("Die");
    //    Destroy(gameObject);
    //    onDead?.Invoke();
    //}

    //protected virtual void WinGame()
    //{
    //    Destroy(gameObject);
    //    onLive?.Invoke();
    //}
}
