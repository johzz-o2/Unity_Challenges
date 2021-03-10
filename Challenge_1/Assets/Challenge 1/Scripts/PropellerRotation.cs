﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    public GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(propeller.transform.position, Vector3.back, 120 * Time.deltaTime);
    }
}
