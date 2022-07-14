using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectionStatusVariables : MonoBehaviour
{
    public bool isMarkerDetected = false;
    private float time = 3f;
    public GameObject messageObject;
    public GameObject centerPanel;
    private bool countDownStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countDownStart)
        {
            FadeOutMessage();
            CountDonw();
        }
    }

    // Called when the marker is detected
    public void MarkerDetected()
    {
        countDownStart = true;
        centerPanel.SetActive(true);
        Debug.Log($"Marker detected");
    }

    void FadeOutMessage()
    {
        Color color = messageObject.transform.GetComponent<Image>().color;
        if (color.a <= 0) 
            return;

        color.a -= 1;

        messageObject.transform.GetComponent<Image>().color = color;

        GameObject textObject = messageObject.transform.GetChild(0).gameObject;
        TextMeshProUGUI text = textObject.GetComponent<TextMeshProUGUI>();
        color = text.color;
        color.a -= 1;
        text.color = color;
    }

    void CountDonw()
    {
        time -= Time.deltaTime;

        GameObject textObject = centerPanel.transform.GetChild(0).gameObject;
        TextMeshProUGUI text = textObject.GetComponent<TextMeshProUGUI>();

        if (time >= 2)
            text.text = "3";
        else if (time >= 1)
            text.text = "2";
        else if (time >= 0)
            text.text = "1";
        else if (time <= 0)
        {
            centerPanel.SetActive(false);
            isMarkerDetected = true;
        }

    }
}
