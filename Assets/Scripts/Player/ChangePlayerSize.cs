using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerSize : MonoBehaviour
{
    public static ChangePlayerSize instance { private set; get; }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("a"))
        {
            SoundManagerScript.GrowUpSound();
            gameObject.transform.localScale = new Vector2(0.7f, 0.7f);
        }
    }
    public void IncrementSize()
    {
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + 0.01f, gameObject.transform.localScale.y + 0.01f);
    }
    
}
