using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 1f;
    [SerializeField] private Health playerHealth;


    // Update is called once per frame
    void Update()
    {
        if(playerHealth.playerLive != false)
        transform.Translate(Vector3.down*cameraSpeed*Time.deltaTime);
    }
}
