using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private float startTouchPosition = 0;
    private float endTouchPosition = 0;
    private float gap;

  
    private Vector3 touchPosition;
    


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Score.instance.CheckBestScore();
            SceneManager.LoadScene("Menu");
        }

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touchPosition.x;
            }
            if (touch.phase == TouchPhase.Moved)
            {

                endTouchPosition = touchPosition.x;
                gap = endTouchPosition - startTouchPosition;
                touchPosition.z = 0;

                transform.position = new Vector2(transform.position.x + gap, transform.position.y);
                startTouchPosition = touchPosition.x;

            }

        }
    }



    


}
