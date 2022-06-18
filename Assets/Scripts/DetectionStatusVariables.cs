using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionStatusVariables : MonoBehaviour
{
    public bool isMarkerDetected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called when the marker is detected
    public void MarkerDetected()
    {
        isMarkerDetected = true;
        Debug.Log($"Marker detected");
    }
}
