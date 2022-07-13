using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionJudge : MonoBehaviour
{   
    private bool startFadeOut = false;
    private bool addScore = false;
    private FadeOutTarget fadeOutTarget;

    void Start()
    {
        fadeOutTarget = gameObject.GetComponent<FadeOutTarget>();
        Debug.Log(fadeOutTarget);
    }

    void OnCollisionEnter(Collision collision)
    {   
        startFadeOut = true;
    }

    void Update()
    {
        if (startFadeOut)
        {
            FadeOut();
        }
    }

    void FadeOut()
    {
        if (!addScore)
        {
            if (fadeOutTarget.rareTarget)
            {
                ScoreManager.UpdateScore(500);
            }
            else
            {
                ScoreManager.UpdateScore(50);
            }
            addScore = true;
        }        

        Transform target = transform.Find("target");
        bool canDestroy = false;
        foreach (Transform child in target)
        {
            child.GetComponent<Renderer>().material.color -= new Color32(0, 0, 0, 2);

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
}