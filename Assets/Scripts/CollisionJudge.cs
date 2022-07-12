using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionJudge : MonoBehaviour
{   
    private bool startFadOut = false;
    private ScoreManager scoreManager;
    private FadeOutTarget fadeOutTarget;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreText").GetComponent<ScoreManager>();
        fadeOutTarget = gameObject.GetComponent<FadeOutTarget>();
        Debug.Log(fadeOutTarget);
    }

    void OnCollisionEnter(Collision collision)
    {   
        startFadOut = true;
    }

    void Update()
    {
        if (startFadOut)
        {
            FadeOut();
        }
    }

    void FadeOut()
    {
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
            if (fadeOutTarget.rareTarget)
            {
                scoreManager.UpdateScore(500);
            }
            else
            {
                scoreManager.UpdateScore(50);
            }
        }
    }
}