using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    private Renderer _renderer;
    private ColorManager _colorManager;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _colorManager = FindObjectOfType<ColorManager>();
    }

    private void OnMouseDown()
    {
        _colorManager.ChangeColor(_renderer.material.color);
    }

}
