using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerListener : MonoBehaviour
{
    public GameObject trap;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            trap.transform.position = new Vector2(1.674f, trap.transform.position.y);
        }

    }
}
