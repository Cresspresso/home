﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotlightScript : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }
}
