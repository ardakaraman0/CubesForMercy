﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPos.position + offset;
    }
}
