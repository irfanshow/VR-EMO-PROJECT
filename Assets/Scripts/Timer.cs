using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public Transform head;
    public GameObject menu;
    [SerializeField] TextMeshProUGUI timer;
    public static float timeRemaining = 300;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else{
            timeRemaining = 0;
        }
        
    
        int minutes = Mathf.FloorToInt(timeRemaining/60);
        int seconds = Mathf.FloorToInt(timeRemaining%60);
        timer.text = string.Format ("{0:00}:{1:00}", minutes, seconds);

                //Menu Selalu melihat ke arah player
        // menu.transform.LookAt(head.transform.position);
        //Agar Menu tidak berbalik/inverted
        // menu.transform.forward *= -1;
    }
}
