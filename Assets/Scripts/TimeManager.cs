using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float maxTime = 20f;
    private float currentTime;
    private TextMeshProUGUI timeText;

    private DetectionStatusVariables detectionStatusVariables;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        timeText = gameObject.GetComponent<TextMeshProUGUI>();
        timeText.text = $"Time: {(int) currentTime}";
        detectionStatusVariables = GameObject.Find("ImageTarget").GetComponent<DetectionStatusVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!detectionStatusVariables.isMarkerDetected)
        {
            return;
        }

        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            currentTime = 0;
        }
        timeText.text = $"Time: {(int) currentTime}";

        if (currentTime == 0)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
