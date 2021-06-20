using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public float parallaxFactor;

    void Start()
    {
        if (parallaxFactor < 0)
        {
            transform.localScale *= 1 + Mathf.Abs(parallaxFactor);
        }
    }

    public void Move(float delta)
    {
        Vector3 newPos = transform.localPosition;
        newPos.x -= delta * parallaxFactor;
        transform.localPosition = newPos;
    }

}
