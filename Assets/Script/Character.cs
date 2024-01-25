using System;
using UnityEngine;

public class Character
{
    public Health health;

    public enum Direction
    {
        LEFT,
        RIGHT,
    }

    public Direction direction { get; set; }

    protected int hp { get; set; }
    protected float speed { get; set; }


    protected Rigidbody2D body { get; set; }
    protected Animator animator { get; set; }
    protected BoxCollider2D boxCollider2D { get; set; }

    protected Transform transform { get; set; }

    protected float horizontal;

    protected float gravityScale { get; set; }

    internal void Update()
    {
        body.gravityScale = gravityScale;
        InputHandle();
        Flip();
    }

    private void InputHandle()
    {

        horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0f, 0f);

        transform.position += movement * speed * Time.deltaTime;

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

    public Character(GameObject gameObject)
    {
        hp = 3;
        gravityScale = 4;
        body = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        transform = gameObject.transform;

    }




}
