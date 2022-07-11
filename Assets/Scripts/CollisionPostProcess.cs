using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPostProcess : MonoBehaviour
{   
    InputField inputField;
    public int score;
    bool normal = true;
    bool add_score = false;

    void Start()
    {
        inputField = GameObject.Find("ScoreField").GetComponent<InputField>();
        inputField.text = "0";
        score = 0;
    }

    void Update()
    {   
        Transform target = transform.Find("target");

        foreach (Transform child in target)
        {
            Material material = child.GetComponent<Renderer>().material;
            if (child.GetComponent<CollisionJudge>().is_collide){
                child.GetComponent<CollisionJudge>().is_collide = false;
                add_score = true;
                Debug.Log(material.GetFloat("_Smoothness"));
                if (material.GetFloat("_Smoothness")==1){
                    normal = false;
                } else{
                    normal = true;
                }
            }
        }
        
        if (add_score){
            if (normal){
                score+=50;
            } else{
                score+=100;
            }
            add_score = false;
            Destroy(gameObject);
            Debug.Log(score);
            inputField.text = score.ToString();
        }
    }
}