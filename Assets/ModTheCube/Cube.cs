﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(1.0f, 0.5f, 0.2f, 0.8f);
    }
    
    void Update()
    {
        transform.Rotate(0f, 15.0f * Time.deltaTime, 0.0f);
    }
}
