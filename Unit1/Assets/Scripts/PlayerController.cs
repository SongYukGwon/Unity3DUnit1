﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Move the avehicle forward
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
