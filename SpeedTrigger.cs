using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTrg : MonoBehaviour
{
    [SerializeField] float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}