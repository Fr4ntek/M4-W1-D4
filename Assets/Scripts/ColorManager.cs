using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Renderer Renderer { get; private set; }
    void Start()
    {
        Renderer = GetComponent<Renderer>();
    }

    public void ChangeColor(Color color)
    {
        Renderer.material.color = color;
    }

    
}
