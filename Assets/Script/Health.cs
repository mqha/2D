using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]  private float startHealth;

    public System.Action onDead;
    public System.Action onLive;
    public float currentHealth { get; private set; }
    private Animator anim;


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
            anim.SetTrigger("Die");
            Destroy(gameObject);
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            Die();
        }
        else

        if (collision.CompareTag("EndGame"))
        {
            WinGame();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
        onDead?.Invoke();
    }

    protected virtual void WinGame()
    {
        Destroy(gameObject);
        onLive?.Invoke();
    }



}
