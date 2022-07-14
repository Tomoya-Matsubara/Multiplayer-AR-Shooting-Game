using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float maxTime = 200f;
    public float currentTime;
    private TextMeshProUGUI timeText;

    private DetectionStatusVariables detectionStatusVariables;

    public bool targetShoot = true;

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
            return;

        currentTime -= Time.deltaTime;
        if (currentTime < 0)
            currentTime = 0;
        
        timeText.text = $"Time: {(int) currentTime}";

        if (currentTime == 0)
            ChangeScene();
        
    }

    void ChangeScene()
    {
        if (targetShoot)
            SceneManager.LoadScene("ResultScene");
        else
        {
            CansConstant.Clear();
            SceneManager.LoadScene("CansResultScene");
        }
    }
}
