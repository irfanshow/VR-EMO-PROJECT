using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform head;
    public GameObject menu;
    public static int enemyCounter;
    public GameOverScreen GameOverScreen;
   

    public TextMeshProUGUI showCount;
    void Start()
    {
        // enemyTotal= GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCounter= GameObject.FindGameObjectsWithTag("Enemy").Length ;
        
        showCount.text = enemyCounter.ToString() + " / " + "15";
        
        if(DestroyEnemy.enemyDestroyed >= 3)
        {
            Time.timeScale = 0 ;
            GameOverScreen.showGameOver();
        }

    }
}
