using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private float horizontal = 0f;
    private float vertical = 0f;


    private Rigidbody2D rigidbody2D;


    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.position += Vector3.right * moveSpeed * Time.deltaTime * horizontal;
    }
}
