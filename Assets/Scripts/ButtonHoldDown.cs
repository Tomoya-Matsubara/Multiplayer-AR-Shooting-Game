using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    public GameObject Bulletprefab;
    public GameObject smallBulletprefab;
    public GameObject largeBulletprefab;
    float force = 1000f;

    // ボタンを押したときtrue、離したときfalseになるフラグ
    private bool buttonDownFlag = false;
    private int timecount;
    private void Update()
    {
        if (buttonDownFlag)
        {
            timecount += 1;
            // ボタンが押しっぱなしの状態の時にのみ「Hold」を表示する。
            Debug.Log("Hold");
            if (ChangeBullet.bulletnumber == 0)
            {
                if (timecount % 5 == 0)
                {
                    lauchButton1();
                }
            }
            else if(ChangeBullet.bulletnumber == 1)
            {
                if(timecount % 15 == 0)
                {
                    lauchButton2();
                }
            }
            else if(ChangeBullet.bulletnumber == 2)
            {
                if(timecount % 40 == 0)
                {
                    lauchButton3();
                }
            }
        }
    }
    // ボタンを押したときの処理
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // ボタンを離したときの処理
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }

    public void lauchButton1() //Shootボタンが押されたら
    {
        GameObject Bullet = Instantiate(smallBulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
    public void lauchButton2() //Shootボタンが押されたら
    {
        GameObject Bullet = Instantiate(Bulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
    public void lauchButton3() //Shootボタンが押されたら
    {
        GameObject Bullet = Instantiate(largeBulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
}
