using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Bulletprefab;
    float force = 1000f;


    public void lauchButton() //Shoot�{�^���������ꂽ��
    {
        GameObject Bullet = Instantiate(Bulletprefab, transform.position, transform.rotation) as GameObject;
        Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
    }
}