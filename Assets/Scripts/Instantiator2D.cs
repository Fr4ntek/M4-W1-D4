using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] GameObject _quadPrefab;
    private int _row = 10;
    private int _col = 10;
    private float _offsetX;
    private float _spacingX = 1.2f;
    private float _offsetY;
    private float _spacingY = 1.2f;

    void Start()
    {
        _offsetX = transform.position.x;
        _offsetY = transform.position.y;

        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _col; j++)
            {
                Vector3 position = new Vector3(_offsetX + j * _spacingX, _offsetY + i * _spacingY, transform.position.z);
                Instantiate(_quadPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}

