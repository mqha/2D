using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    private PlayerController playerController;


    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    void Update()
    {
        if (playerController != null)
        {
            transform.Translate(Vector3.down * cameraSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * 0 * Time.deltaTime);
        }
            
    }
}
