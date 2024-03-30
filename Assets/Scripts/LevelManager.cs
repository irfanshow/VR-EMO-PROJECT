using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static GameObject head;
    public string sceneName;
    public string restartScene;

    // private int enemyLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // enemyLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        // Debug.Log(enemyLeft);
    }

    public void SceneLoader()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

        public void Restart()
    {
        SceneManager.LoadScene(restartScene);
    }
}
