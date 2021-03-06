using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Finished");
            other.GetComponent<Movement>().enabled = false;
        }
    }
}