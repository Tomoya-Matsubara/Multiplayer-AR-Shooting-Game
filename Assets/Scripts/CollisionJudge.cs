using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionJudge : MonoBehaviour
{   
    private bool startFadOut = false;

    void Start()
    {
        
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
        }
    }
}