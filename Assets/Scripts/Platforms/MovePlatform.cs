using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{

    [SerializeField] private float rightBorder,leftBorder;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool randomPosition = false;
    [SerializeField] private bool moveRight = false;
    private float posX;
    // Start is called before the first frame update
    void Start()
    {
        if (randomPosition)
        {
            posX = Random.Range(leftBorder, rightBorder);
            transform.position = new Vector2(posX, transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= rightBorder)
        {
            moveRight = false;
        }
        if(transform.position.x <= leftBorder)
        {
            moveRight = true;
        }
        
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
