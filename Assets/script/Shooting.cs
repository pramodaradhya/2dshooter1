using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public Playsound playSound;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            playSound.Play(0);
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * bulletForce, ForceMode2D.Impulse);
        playSound.Play(0);

    }
}
