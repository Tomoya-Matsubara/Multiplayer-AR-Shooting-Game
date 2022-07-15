using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CansConstant : MonoBehaviour
{
    public static int nCans = 1;
    public static bool clear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SetNumberOfCans(int n)
    {
        nCans = n;
    }

    public static void Clear()
    {
        clear = true;
    }

    public static void GameOver()
    {
        clear = false;
    }
}
