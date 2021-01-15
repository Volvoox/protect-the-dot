using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance { private set; get; }

    private int score = 0;
    private int bestScore;
    [SerializeField] private Text scoreText;

    // Start is called before the first frame update

    private void Start()
    {
        instance = this;

        if (PlayerPrefs.HasKey("BEST_SCORE"))
        {
            bestScore = PlayerPrefs.GetInt("BEST_SCORE");
           // PlayGamesController.PostLeaderboard(bestScore);
        }
        else
        {
            PlayerPrefs.SetInt("BEST_SCORE",0);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public int GetScore()
    {
        return score;
    }
    public int GetBestScore()
    {

        return bestScore;
    }

    public void CheckBestScore() //Oyuncu duvara çarptıktan ya da oyunu kapatırken çağır.
    {
        if(score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BEST_SCORE", bestScore);
            //PlayGamesController.PostLeaderboard(bestScore);
        }
    }

    private void OnApplicationPause(bool pause)
    {
            CheckBestScore();    
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
 
  
  

    
}
