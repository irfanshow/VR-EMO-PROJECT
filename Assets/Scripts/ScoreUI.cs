using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    // Start is called before the first frame update
    // public Transform head;
    // public GameObject menu;
    public static int score = 0;

    public TextMeshProUGUI showScore;
  
    // Update is called once per frame
    void Update()
    {

        showScore.text = score.ToString();

    }
}



