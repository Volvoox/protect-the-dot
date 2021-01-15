using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColor : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = ColorSwitcher.instance.GetColor();
    }

}
