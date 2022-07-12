using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int change)
    {
        score += change;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = $"Score: {score}";
    }
}
