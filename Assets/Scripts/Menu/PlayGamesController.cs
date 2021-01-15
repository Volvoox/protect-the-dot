using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using GooglePlayGames;
//using GooglePlayGames.BasicApi;


public class PlayGamesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AuthenticateUser();
    }

    private void AuthenticateUser()
    {
//         PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
//         PlayGamesPlatform.InitializeInstance(config);
//         PlayGamesPlatform.Activate();
//         Social.localUser.Authenticate((bool success) =>
//         {
            

//         });
    }

    public static void PostLeaderboard(long newScore)
    {
//         Social.ReportScore(newScore, GPGSIds.leaderboard_top_scores, (bool success) =>
//          {

//          });
    }

    public static void ShowLeaderBoard()
    {
        //PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_top_scores);
    }
}
