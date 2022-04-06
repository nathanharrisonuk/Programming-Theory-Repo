using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifficultySetter : MonoBehaviour
{

    private GameManager gameManagerScript;


    public Button difficultyButton;
  
    public int difficultyLevel;



    // Start is called before the first frame update
    void Start()
    {
        difficultyButton = GetComponent<Button>();
        difficultyButton.onClick.AddListener(SetDifficultyAndStart);
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();   
      
        
    }

    private void Update()
    {
       
    }



    public void SetDifficultyAndStart()
    {
        GameObject.Find("Title").SetActive(false);
        gameManagerScript.StartGame(difficultyLevel);
        gameManagerScript.isGameActive = true;
        
    }


    
}
