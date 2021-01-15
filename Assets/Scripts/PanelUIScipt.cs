using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelUIScipt : MonoBehaviour
{
    public static PanelUIScipt instance { set; get; }

    [SerializeField] private GameObject Panel;
    [SerializeField] private Text bestScoreText;
    [SerializeField] private Text currentScoreText;
    [SerializeField] private GameObject scoreTextInGame;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActivePanel()
    {
        currentScoreText.text = Score.instance.GetScore().ToString();
        bestScoreText.text = Score.instance.GetBestScore().ToString();
        scoreTextInGame.SetActive(false);
        Panel.SetActive(true);
        
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
