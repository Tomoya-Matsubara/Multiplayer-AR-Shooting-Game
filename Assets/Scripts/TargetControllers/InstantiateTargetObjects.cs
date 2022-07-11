using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTargetObjects : MonoBehaviour
{

    public GameObject targetObject;
    private float currentTime = 0f;
    private bool isMarkerDetected = false;

    private DetectionStatusVariables detectionStatusVariables;

    // Start is called before the first frame update
    void Start()
    {
        detectionStatusVariables = GameObject.Find("ImageTarget").GetComponent<DetectionStatusVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (!detectionStatusVariables.isMarkerDetected)
        {
            return;
        }

        if (currentTime >= 2) {
            // Debug.Log($"Current Position: {transform.position}");

            float x = Random.Range(-500f, 500f);;
            float y = 100 + Random.Range(-500f, 500f);
            float z = Random.Range(-500f, 500f);;

            GameObject target = Instantiate(targetObject, new Vector3(x, y, z), Quaternion.identity);
            float angle = Random.Range(-45f, 45f);
            target.transform.rotation = Quaternion.Euler(angle, 0, 0);

            target.transform.SetParent(gameObject.transform, false);

            currentTime = 0;
        }
        
    }
}
