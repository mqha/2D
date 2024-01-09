using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 1f;
    [SerializeField] private PlayerController player;


    // Update is called once per frame
    void Update()
    {
        if(player != null)
        transform.Translate(Vector3.down*cameraSpeed*Time.deltaTime);
    }
}
