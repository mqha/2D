using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedMove = 10f;

    private float horizontal = 0f;

    private Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0f, 0f);

        transform.position += movement * speedMove * Time.deltaTime;

        Flip(horizontal);
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
        Debug.Log("Win");
    }
}
