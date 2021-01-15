using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGameButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LeaderboardButton()
    {
       // PlayGamesController.ShowLeaderBoard();
    }
}
