using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBullet : MonoBehaviour
{
    public static int bulletnumber;
    public void change()
    {
        if (bulletnumber == 0)
        {
            bulletnumber = 1;
        }
        else if (bulletnumber == 1)
        {
            bulletnumber = 2;
        }
        else if (bulletnumber == 2)
        {
            bulletnumber = 0;
        }
    }
}
