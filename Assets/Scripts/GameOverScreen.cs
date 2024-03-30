using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public Transform head;
    
    public TextMeshProUGUI scoreGameOver;
    public TextMeshProUGUI hasil;
    public TextMeshProUGUI sisaMusuh;
    public TextMeshProUGUI sisaWaktu;
    [SerializeField]float spawnDistance;
    public GameObject inGameUI;
    // Start is called before the first frame update
    public void showGameOver()
    {
        inGameUI.SetActive(false);
        gameObject.SetActive(true);
        //Muncul didepan player ditambah jarak tertentu
        gameObject.transform.position = head.transform.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
        //Melihat arah player
        gameObject.transform.LookAt(head.transform.position);
        //Agar Menu tidak berbalik/inverted
        gameObject.transform.forward *= -1;


        if (ScoreUI.score > 0)
        {
            hasil.text = "Berhasil";
        }
        else if (ScoreUI.score <= 0)
        {
            hasil.text = "Gagal";
        }


        //Menunjukkan total skor akhir
        scoreGameOver.text = ScoreUI.score.ToString();

        //Menunjukkan sisa musuh
        sisaMusuh.text = "Sisa Musuh : " + Counter.enemyCounter.ToString();
        
        //Menunjukkan sisa waktu
        timeGameOver();

    }


    void timeGameOver()
    {
        if(Timer.timeRemaining > 0)
        {
            Timer.timeRemaining -= Time.deltaTime;
        }
        else{
            Timer.timeRemaining = 0;
        }

        int minutes = Mathf.FloorToInt(Timer.timeRemaining/60);
        int seconds = Mathf.FloorToInt(Timer.timeRemaining%60);
        sisaWaktu.text = "Sisa Musuh : " + string.Format ("{0:00}:{1:00}", minutes, seconds);

    }

}
