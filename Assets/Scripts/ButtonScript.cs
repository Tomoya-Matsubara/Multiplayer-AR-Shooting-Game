using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject BulletPrefab;
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
                chargeTime = 0.5f;
                break;
            case 1:
                bulletPrefab = LargeBulletPrefab;
                chargeTime = 1f;
                break;
            case 2:
                bulletPrefab = SmallBulletPrefab;
                break;
            default:
                bulletPrefab = NormalBulletPrefab;
                chargeTime = 0.2f;
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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.Log($"Camera ray: {ray}");
            // Debug.Log("Tapped!");

            // Instantiate the bullet
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.localScale = 100 * Vector3.one;
            bullet.transform.SetParent(BulletsContainer.transform, false);

            // Shoot the bullet
            bullet.GetComponent<BulletScript>().Shoot(ray.direction * force * 100);

            // Once the bullet has been shoot, reset the remaining time
            remainingTime = chargeTime;
        }
    }
}