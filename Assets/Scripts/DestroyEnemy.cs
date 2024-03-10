using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public int maxHealth = 3;   
    public int currentHealthWrong;
    public int currentHealthCorrect;
    public string enemyTag;

    public Transform head;
    public GameObject healthBar;

    //Refrence ke scrip Healthbar
    public HealthBar healthBarWrong;
    public HealthBar healthBarCorrect;


    void Start()
    {
        currentHealthWrong = 0;
        currentHealthCorrect = 0;
        // Memanggil method SetMaxHealth Daari script healthbar
        healthBarWrong.SetMaxHealth(maxHealth);
        healthBarCorrect.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        //Menu Selalu melihat ke arah player
        healthBar.transform.LookAt(head.transform.position);
        //Agar Menu tidak berbalik/inverted
        healthBar.transform.forward *= -1;
    }


    private void OnTriggerEnter(Collider other) 
    {

        // Jika benar
        if (other.gameObject.CompareTag(enemyTag))
        {
            TakeDamageCorrect(1);
            Destroy(other.gameObject);

            if (currentHealthCorrect >= 3)
            {
                Debug.Log("Hancurrrr Benar");
                Destroy(gameObject);
            }
            
            
        }
        // Jika salah
        else 
        {
            
            if (!other.gameObject.CompareTag(enemyTag))
            {
                TakeDamageWrong(1);
                Destroy(other.gameObject);
            }
            
            
            if (currentHealthWrong >= 3)
            {
                Debug.Log("Hancurrrr SALAHH");
                Destroy(gameObject);
            }
        }
    }

    void TakeDamageWrong(int damage)
    {
        currentHealthWrong += damage;
        healthBarWrong.SetHealth(currentHealthWrong);
    }

    void TakeDamageCorrect(int damage)
    {
        currentHealthCorrect += damage;
        healthBarCorrect.SetHealth(currentHealthCorrect);
    }



    // private void OnCollisionEnter(Collision other)
    // {

    // if (other.gameObject.CompareTag(enemyTag))
    //     {
    //         Destroy(other.gameObject);
    //         Destroy(gameObject);
    //     }
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    // if (other.CompareTag("Enemy"))
    //     {
    //         Destroy(other.gameObject);
    //         Destroy(other.gameObject);
    //     }
    // }
}
