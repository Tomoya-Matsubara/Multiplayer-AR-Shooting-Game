using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSelectManager : MonoBehaviour
{
    public int ID;
    // public GameObject bulletManagerObject;
    // private BulletManager bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        // bulletManager = bulletManagerObject.GetComponent<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BulletManager.bulletID == ID)
        {
            gameObject.GetComponent<Image>().color = new Color32((byte) 255, (byte) 222, (byte) 45, (byte) 100);
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color32((byte) 255, (byte) 255, (byte) 255, (byte) 100);
        }
    }

    public void SetBulletID()
    {
        BulletManager.bulletID = ID;
    }
}
