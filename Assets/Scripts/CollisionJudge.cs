using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionJudge : MonoBehaviour
{   
    InputField inputField;
    public int score;

    void Start()
    {
        inputField = GameObject.Find("ScoreField").GetComponent<InputField>();
        inputField.text = "0";
        score = 0;
    }

    void OnCollisionEnter(Collision collision)
    {   
        score += 50;
        inputField.text = score.ToString();
        Debug.Log("Collision is occured");
    }
}
