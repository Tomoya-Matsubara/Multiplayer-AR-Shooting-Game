using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionJudge : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision is occured");
    }
}
