using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedMove = 10f;

    private float horizontal = 0f;

    private Rigidbody2D rb2D;

    private Animator animator;

    private bool isRunning = false;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0f, 0f);

        transform.position += movement * speedMove * Time.deltaTime;

        Flip(horizontal);

        isRunning = horizontal != 0;
        SetAnimation();

    }

    private void Flip(float horizontal)
    {
        if((horizontal > 0 && transform.localScale.x < 0)||(horizontal < 0 && transform.localScale.x > 0))
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1");
    }

    private void SetAnimation()
    {
        animator.SetBool("Run", isRunning);
    }

}
