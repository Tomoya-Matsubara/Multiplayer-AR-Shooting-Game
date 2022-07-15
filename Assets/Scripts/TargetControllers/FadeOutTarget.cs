using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutTarget : MonoBehaviour
{
    public byte r = 240;
    public byte g = 217;
    public byte  b = 135;
    public byte a = 255;
    public float metallic = 0.27f;
    public float smoothness = 1.0f;

    public float lifespan = 5f;
    private float currentTime = 0f;

    public bool rareTarget = false;

    private DetectionStatusVariables detectionStatusVariables;

    // Start is called before the first frame update
    void Start()
    {
        detectionStatusVariables = GameObject.Find("ImageTarget").GetComponent<DetectionStatusVariables>();

        // Make the target object with a probability of 10%
        if (Random.value <= 0.1)
        {
            rareTarget = true;
            lifespan = 2f;
            Transform target = transform.Find("target");
            float offset = 0f;

            foreach (Transform child in target)
            {
                Material material = child.GetComponent<Renderer>().material;
                material.color = new Color32(r, g, b, a);
                material.SetFloat("_Metallic", metallic + offset); 
                material.SetFloat("_Smoothness", smoothness);

                offset += 0.1f;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!detectionStatusVariables.isMarkerDetected)
            return;

        currentTime += Time.deltaTime;

        // Start fade out animation
        if (currentTime > lifespan)
        {
            Transform target = transform.Find("target");
            bool canDestroy = false;
            foreach (Transform child in target)
            {
                // Rare target fades out faster
                int fadeOutSpeed = rareTarget? 2 : 1;
                child.GetComponent<Renderer>().material.color -= new Color32(0, 0, 0, (byte) fadeOutSpeed);
    
                if (child.GetComponent<Renderer>().material.color.a <= 0)
                    canDestroy = true;
            }

            if (canDestroy)
                Destroy(gameObject);
        }
    }
}
