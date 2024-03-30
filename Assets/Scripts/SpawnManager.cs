using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] npcPrefabs;
    public GameObject[] spawnPoints;
    public Counter enemy;
    private int spawnPointIndex ;
    private int enemyTotal = 1;
    


    // private float spawnPosXMin = -7;
    // private float spawnPosXMax = 16;
    // private float spawnPosZMin = -1;
    // private float spawnPosZMax = -20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnNPC", 0.1f, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnNPC()
    {
        
        int npcIndex = Random.Range(0, npcPrefabs.Length);
        spawnPointIndex = Random.Range (0,spawnPoints.Length);

        if(enemyTotal >= 15)
        {
            
            CancelInvoke("spawnNPC");
        }
      
        // spawnPoints[spawnPointIndex].SetActive(false);

        Instantiate(npcPrefabs[npcIndex],spawnPoints[spawnPointIndex].transform.position,spawnPoints[spawnPointIndex].transform.rotation);
        spawnPoints[spawnPointIndex].SetActive(false);
        enemyTotal += 1;
        
        
    }
}
