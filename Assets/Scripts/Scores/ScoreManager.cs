using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateScore(int change)
    {
        score += change;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
