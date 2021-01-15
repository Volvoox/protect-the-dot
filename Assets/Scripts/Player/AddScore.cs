using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            SoundManagerScript.ScoreSound();
            ChangePlayerSize.instance.IncrementSize();
            Score.instance.AddScore();
            
        }
        
    }

}
