using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator3D : MonoBehaviour
{
    [SerializeField] GameObject _cubePrefab;
    private int _row = 10;
    private int _col = 10;
    private int _depth = 10; 
    private float _offsetX;
    private float _spacingX = 1.2f;
    private float _offsetY;
    private float _spacingY = 1.2f;
    private float _offsetZ;
    private float _spacingZ = 1.2f;

    void Start()
    {
        _offsetX = transform.position.x;
        _offsetY = transform.position.y;
        _offsetZ = transform.position.z;

        for (int k  = 0; k < _depth; k++)
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Vector3 position = new Vector3(_offsetX + j * _spacingX, _offsetY + i * _spacingY, _offsetZ + k * _spacingZ);
                    Instantiate(_cubePrefab, position, Quaternion.identity, transform);
                }
            }
        }
        
    }
}
