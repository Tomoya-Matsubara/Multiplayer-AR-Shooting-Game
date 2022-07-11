using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public void Shoot(Vector3 dir) //shoot a bullet
    {
        GetComponent<Rigidbody>().AddForce(dir);
        Destroy(gameObject, 3);
    }

    void Update()
    {
        Debug.Log($"{transform.position}");
    }
}
