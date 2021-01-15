using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    private float offset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(target.hasChanged)
        {
            Vector3 temp = transform.position;

            temp.y = target.position.y;
            temp.y += offset;

            transform.position = temp;
        }
        
    }
}
