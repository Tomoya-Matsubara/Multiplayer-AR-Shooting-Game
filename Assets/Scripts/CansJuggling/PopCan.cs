using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopCan : MonoBehaviour
{
    private Rigidbody rigidBody;
    public bool alive = true;
    public bool gravity = true;

    public bool countDown = false;
    public GameObject remainingText;
    private RemainingManager remainingManager;

    public GameObject arCamera;
    private DetectionStatusVariables detectionStatusVariables;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        // rigidBody.velocity += Vector3.down * 50;

        remainingManager = remainingText.GetComponent<RemainingManager>();
        detectionStatusVariables = arCamera.GetComponent<DetectionStatusVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detectionStatusVariables.isMarkerDetected)
        {
            rigidBody.useGravity = true;
            gravity = true;
        }
        
        if (gravity)
        {
            float force = 2f;
            rigidBody.AddForce(Vector3.down * force);
        }

        if (gameObject.transform.position.y <= -500)
        {
            alive = false;
            gameObject.SetActive(false);

            if (!countDown)
            {
                remainingManager.DecreaseCount();
                countDown = true;
            }
        }
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     // Destroy(collision.gameObject);
    // }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        rigidBody.velocity = Vector3.zero;
        
        float force = 50f;
        Vector3 direction = new Vector3(Random.value, force, Random.value);
        rigidBody.AddForce(direction, ForceMode.Impulse);

        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)) / 10;
        GetComponent<Rigidbody>().AddTorque(direction * Mathf.PI, ForceMode.VelocityChange);
    }
}
