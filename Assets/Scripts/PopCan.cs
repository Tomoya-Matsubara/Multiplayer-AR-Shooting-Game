using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopCan : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity += Vector3.down * 50;
    }

    // Update is called once per frame
    void Update()
    {
        float force = 1f;
        rigidBody.AddForce(Vector3.down * force);
    }

    void OnCollisionEnter(Collision collision)
    {
        float force = 10000f;
        rigidBody.AddForce(Vector3.up * force, ForceMode.VelocityChange);
    }

    void OnTriggerEnter(Collider other)
    {
        rigidBody.velocity = Vector3.zero;
        
        float force = 50f;
        rigidBody.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
