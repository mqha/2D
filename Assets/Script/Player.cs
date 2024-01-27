using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SkinManager skinManager;

    private float moveSpeed = 5f;

    private Rigidbody2D playerbody;

    private float horizontal = 0f;

    public System.Action onDead;
    public System.Action onLive;

    private void Start()
    {
        playerbody = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * moveSpeed * Time.deltaTime * horizontal;


        Flip();
    }

    private void Flip()
    {
        if ((horizontal > 0 && transform.localScale.x < 0) || (horizontal < 0 && transform.localScale.x > 0))
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
        }
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

    
