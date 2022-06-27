using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{   
    private Rigidbody rb;
    private float speed = 100f;
    private Vector3 direction = new Vector3(0,-1,-2);
    private float max_dis = 300f;
    private Vector3 pos_start = new Vector3(0,150,200);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = direction*speed;
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 pos_curr = transform.position;
        float dis = Vector3.Distance(pos_start, pos_curr);
        if (dis > max_dis)
        {
            Destroy(this.gameObject);
        }
    }
}