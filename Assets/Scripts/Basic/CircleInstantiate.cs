using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    public GameObject template;
    public int count;
    public float radius;

    private void Start()
    {
        int angleStep = 360 / count;

        for (int i = 0; i < count; i++)
        {
            GameObject newObject = Instantiate(template, Vector3.zero, Quaternion.identity);
            Transform newObjectTransform = newObject.GetComponent<Transform>();
            newObjectTransform.position =
                new Vector3(radius * Mathf.Cos(angleStep * (i + 1) * Mathf.Deg2Rad),
                    radius * Mathf.Sin(angleStep * (i + 1) * Mathf.Deg2Rad), 0);
        }
    }
}