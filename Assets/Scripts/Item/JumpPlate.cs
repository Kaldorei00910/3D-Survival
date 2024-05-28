using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpPlate : MonoBehaviour
{
    Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other.name);
            rb = other.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 200, ForceMode.Impulse);
        }

    }

}
