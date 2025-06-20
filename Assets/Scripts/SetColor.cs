using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private ColorManager _colorManager;
    private Renderer _renderer;
    private Color _defaultColor;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _colorManager = FindObjectOfType<ColorManager>();
        _defaultColor = _renderer.material.color;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _renderer.material.SetColor("_BaseColor", _defaultColor);
        }
    }

    private void OnMouseDown()
    {
        _renderer.material.color = _colorManager.Renderer.material.color;
    }
   
}
