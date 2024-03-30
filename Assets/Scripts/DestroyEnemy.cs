using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public static int enemyDestroyed = 0;
    public int maxHealth = 3;   
    public int currentHealthWrong;
    public int currentHealthCorrect;
    public string enemyTag;

    private GameObject head;
    public GameObject healthBar;

    //Refrence ke scrip Healthbar
    public HealthBar healthBarWrong;
    public HealthBar healthBarCorrect;

    public int score;


    void Start()
    {
        score = 0;
        currentHealthWrong = 0;
        currentHealthCorrect = 0;
        // Memanggil method SetMaxHealth Daari script healthbar
        healthBarWrong.SetMaxHealth(maxHealth);
        healthBarCorrect.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        head = GameObject.FindWithTag("Player");
        //Menu Selalu melihat ke arah player
        healthBar.transform.LookAt(head.transform.position);
        //Agar Menu tidak berbalik/inverted
        healthBar.transform.forward *= -1;
      

        
    }


    private void OnTriggerEnter(Collider other) 
    {

        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Itu adalah Player");
        }
        
        // Jika benar
        else if (other.gameObject.CompareTag(enemyTag))
        {
            TakeDamageCorrect(1);
            Destroy(other.gameObject);

            if (currentHealthCorrect >= 3)
            {
                Debug.Log("Hancurrrr Benar");
                Destroy(gameObject);
                ScoreUI.score += 10;
                enemyDestroyed +=1;
                Debug.Log(enemyDestroyed);
                

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
                ScoreUI.score -= 10;
                enemyDestroyed +=1;
                Debug.Log(enemyDestroyed);
                

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
