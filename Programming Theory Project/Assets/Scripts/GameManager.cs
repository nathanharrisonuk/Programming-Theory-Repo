using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // SCORE UI
    public TextMeshProUGUI scoreText;
    public GameObject scoring;
    private int score;

    public GameObject titles;

    public bool isGameActive;

     

    // Start is called before the first frame update
    void Start()
    {
        
        isGameActive = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        InvokeRepeating("SpawnRandomChick", startDelay, spawnDelay / difficulty);
        scoring.gameObject.SetActive(true);
    }


    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }




    public void GameOver()
    {
        isGameActive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }












    // SPAWNING

    [SerializeField]
    public GameObject[] chickPrefabs;

    protected float XSpawnRange = 8.5f;
    protected float YSpawnRange = 0.0f;
    protected float ZSpawnRange = 10.0f;

    protected float startDelay = 1.0f;
    protected float spawnDelay = 2.0f;




    public void SpawnRandomChick()
    {

        if (isGameActive == true)
        {

            int chickIndex = Random.Range(0, chickPrefabs.Length);

            Vector3 spawnPos = new Vector3(Random.Range(-XSpawnRange, XSpawnRange), YSpawnRange, ZSpawnRange);

            Instantiate(chickPrefabs[chickIndex], spawnPos, chickPrefabs[chickIndex].transform.rotation);
        }
        

    }



}
