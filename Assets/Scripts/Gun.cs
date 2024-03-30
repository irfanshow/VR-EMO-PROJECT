using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    // private Rigidbody rb;
    public float bulletSpeed;
    public GameObject fpsCam;
    public AudioSource sfxShot;

    public GameObject bulletPrefab;
    public Transform firePosition; // Posisi Awal Tembakan
    // Update is called once per frame

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);

    }


    void FireBullet(ActivateEventArgs args)
    {
            sfxShot.Play();
            GameObject bullet = Instantiate(bulletPrefab,firePosition.transform.position,transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed ,ForceMode.VelocityChange);
            Destroy(bullet,1);
    }

    void Shoot()
    {
        //Raycast == Menembakkan sebuah ray tidak terihat dari object awal ke titik tertentu
        //Weapon shoot
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
