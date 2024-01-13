using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    [SerializeField] private float spikeDelayTime = 1;
    [SerializeField] private float spikeSpeed = 1;
    [SerializeField] private bool spikeMove = false;


    
    
    void Start()
    {
        StartCoroutine(SpikeAction());
    }

    IEnumerator SpikeAction()
    {
        while (true)
        {
            if (spikeMove)
            {
                transform.Translate(Vector3.up * spikeSpeed * Time.deltaTime);
            }
            else
                transform.Translate(Vector3.down * spikeSpeed * Time.deltaTime);

        yield return null;
        }
    }

    
    private void SpikeMove()
    {
        spikeMove = !spikeMove;
        Invoke("SpikeMove", spikeDelayTime);
    }


}
