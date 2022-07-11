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
        
        if (currentTime > lifespan)
        {
            Transform target = transform.Find("target");
            bool canDestroy = false;
            foreach (Transform child in target)
            {
                child.GetComponent<Renderer>().material.color -= new Color32(0, 0, 0, 1);
                print(child.GetComponent<Renderer>().material.color);
    
                if (child.GetComponent<Renderer>().material.color.a <= 0)
                {
                    canDestroy = true;
                }
            }

            if (canDestroy)
            {
                Destroy(gameObject);
            }
        }
        Debug.Log("Collision is occured");
    }
}