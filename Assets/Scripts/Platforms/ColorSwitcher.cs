using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{

    private Color randomColor;
    public static ColorSwitcher instance { private set; get; }

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        randomColor = new Color(
    Random.Range(0.2f, 1f), //Red
    Random.Range(0.2f, 1f), //Green
    Random.Range(0.2f, 1f) //Blue
    );
    }

    public Color GetColor()
    {
        return randomColor;
    }


  

}
