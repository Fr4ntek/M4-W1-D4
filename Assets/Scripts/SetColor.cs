using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private ColorManager _colorManager;
    private Renderer _renderer;
    private Color _defaultColor;
    private Camera _cam;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _colorManager = FindObjectOfType<ColorManager>();
        _defaultColor = _renderer.material.color;
        _cam = Camera.main;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _renderer.material.SetColor("_BaseColor", _defaultColor);
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = _cam.ScreenPointToRay(mousePos);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                hit.collider.gameObject.GetComponent<Renderer>().material.color = _colorManager.Renderer.material.color;
            }

        }
    }
   
}
