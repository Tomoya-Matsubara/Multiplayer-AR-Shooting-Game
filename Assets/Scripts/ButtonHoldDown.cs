using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoldDown : MonoBehaviour
{
    public GameObject Bulletprefab;
    public GameObject smallBulletprefab;
    public GameObject largeBulletprefab;
    float force = 1000f;

    // �{�^�����������Ƃ�true�A�������Ƃ�false�ɂȂ�t���O
    private bool buttonDownFlag = false;
    private int timecount;
    private void Update()
    {
        if (buttonDownFlag)
        {
            timecount += 1;
            // �{�^�����������ςȂ��̏�Ԃ̎��ɂ̂݁uHold�v��\������B
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
    // �{�^�����������Ƃ��̏���
    public void OnButtonDown()
    {
        Debug.Log("Down");
        buttonDownFlag = true;
    }
    // �{�^���𗣂����Ƃ��̏���
    public void OnButtonUp()
    {
        Debug.Log("Up");
        buttonDownFlag = false;
    }

    public void lauchButton1() //Shoot�{�^���������ꂽ��
    {
        GameObject Bullet = Instantiate(smallBulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
    public void lauchButton2() //Shoot�{�^���������ꂽ��
    {
        GameObject Bullet = Instantiate(Bulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
    public void lauchButton3() //Shoot�{�^���������ꂽ��
    {
        GameObject Bullet = Instantiate(largeBulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
}
