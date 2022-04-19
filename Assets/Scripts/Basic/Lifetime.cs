using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable - " + gameObject.name);
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable - " + gameObject.name);
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Debug.Log("Start - " + gameObject.name);
    }

    // Update is called once per frame
    private void Update()
    {
        // Debug.Log("Update - " + gameObject.name);
    }
}
