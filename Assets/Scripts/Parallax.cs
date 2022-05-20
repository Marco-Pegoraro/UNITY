using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float StartPos;
    private float Length;
    public float ParallaxEffect;
    private Transform cam;

    void Start()
    {
        StartPos = transform.position.x;
        Length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
    }

    void Update()
    {
        float RsPosition = cam.transform.position.x * (1 - ParallaxEffect);
        float Distance = cam.transform.position.x * ParallaxEffect;

        transform.position = new Vector3(StartPos + Distance, transform.position.y, transform.position.z);

        if(RsPosition > StartPos + Length)
        {
            StartPos += Length;
        }
        else if(RsPosition < StartPos - Length)
        {
            StartPos -= Length;
        }
    }
}
