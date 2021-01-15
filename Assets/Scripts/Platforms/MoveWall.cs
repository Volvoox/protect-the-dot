using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        if(Score.instance.GetScore() > 50)
        {
            speed = 2.3f;
        }
        transform.Translate(translation: (Vector3)(Vector2.down * speed * Time.deltaTime));

    }


    
}
