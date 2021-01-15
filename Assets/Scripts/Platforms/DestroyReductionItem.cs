using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyReductionItem : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
