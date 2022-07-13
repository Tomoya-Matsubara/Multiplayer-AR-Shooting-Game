using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // public GameObject BulletPrefab;
    float force = 1000f;
    public float chargeTime = 0.5f;
    private float remainingTime = 0.0f;
    public GameObject BulletsContainer;

    public GameObject NormalBulletPrefab;
    public GameObject LargeBulletPrefab;
    public GameObject SmallBulletPrefab;
    private GameObject bulletPrefab;

    public void lauchButton() //Shoot�{�^���������ꂽ��
    {
        // GameObject Bullet = Instantiate(Bulletprefab, transform.position, transform.rotation);
        // Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
        
    }

    void Start()
    {
        switch (BulletManager.bulletID)
        {
            case 0: 
                bulletPrefab = NormalBulletPrefab;
                force = 100_000;
                chargeTime = 0.5f;
                break;
            case 1:
                bulletPrefab = LargeBulletPrefab;
                force = 90_000;
                chargeTime = 1f;
                break;
            case 2:
                bulletPrefab = SmallBulletPrefab;
                force = 100_000;
                chargeTime = 0.2f;
                break;
            default:
                bulletPrefab = NormalBulletPrefab;
                break;
        }
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;

        // Have to wait for charging for `chargeTime`
        if (remainingTime > 0.0f)
        {
            return;
        }

        if (Input.GetMouseButton(0)) 
        {
            Vector3 position = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(position);
            Shoot(ray);

            // Once the bullet has been shoot, reset the remaining time
            remainingTime = chargeTime;

            if (BulletManager.bulletID == 2)
            {
                ray = Camera.main.ScreenPointToRay(position + Vector3.right * 100);
                Shoot(ray);

                ray = Camera.main.ScreenPointToRay(position + Vector3.left * 100);
                Shoot(ray);

                ray = Camera.main.ScreenPointToRay(position + Vector3.up * 10);
                Shoot(ray);

                ray = Camera.main.ScreenPointToRay(position + Vector3.down * 10);
                Shoot(ray);
            }
        }
    }

    void Shoot(Ray ray)
    {
        // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.transform.SetParent(BulletsContainer.transform, false);

        // Shoot the bullet
        bullet.GetComponent<BulletScript>().Shoot(ray.direction * force);
    }
}