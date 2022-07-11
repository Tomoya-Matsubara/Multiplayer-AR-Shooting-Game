using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionJudge : MonoBehaviour
{   
    public bool is_collide = false;

    void OnCollisionEnter(Collision collision)
    {   
        this.is_collide = true;
    }
}