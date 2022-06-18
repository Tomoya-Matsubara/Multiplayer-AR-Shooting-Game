using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutTarget : MonoBehaviour
{
    public float lifespan = 5f;
    private float currentTime = 0f;

    private DetectionStatusVariables detectionStatusVariables;

    // Start is called before the first frame update
    void Start()
    {
        detectionStatusVariables = GameObject.Find("ImageTarget").GetComponent<DetectionStatusVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!detectionStatusVariables.isMarkerDetected)
        {
            return;
        }

        currentTime += Time.deltaTime;

        // Start fade out animation
        if (currentTime > lifespan)
        {
            Transform target = transform.Find("target");
            bool canDestroy = false;
            foreach (Transform child in target)
            {
                child.GetComponent<Renderer>().material.color -= new Color32(0, 0, 0, 1);
                print(child.GetComponent<Renderer>().material.color);
    
                if (child.GetComponent<Renderer>().material.color.a <= 0)
                {
                    canDestroy = true;
                }
            }

            if (canDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}
