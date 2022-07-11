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

    public void lauchButton() //Shoot�{�^���������ꂽ��
    {
        // GameObject Bullet = Instantiate(Bulletprefab, transform.position, transform.rotation);
        // Bullet.GetComponent<BulletScript>().Shoot(Bullet.transform.forward * force);
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
            Debug.Log($"Camera ray: {ray}");
            Debug.Log("Tapped!");

            // Instantiate the bullet
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            bullet.transform.localScale = 100 * Vector3.one;
            bullet.transform.SetParent(BulletsContainer.transform, false);

            // Shoot the bullet
            bullet.GetComponent<BulletScript>().Shoot(ray.direction * force * 100);

            // Once the bullet has been shoot, reset the remaining time
            remainingTime = chargeTime;
        }
    }
}