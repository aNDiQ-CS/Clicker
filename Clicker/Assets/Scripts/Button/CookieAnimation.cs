using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieAnimation : MonoBehaviour
{
    [SerializeField]
    float _rotationSpeed = 5f;

    [SerializeField]
    float _scaleFactor = 0.5f;

    bool _mouseOn = false;

    private void OnMouseOver()
    {
        _mouseOn = true;
        Scale();
    }

    private void Scale()
    {

    }

    void Update()
    {        
        transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
    }
}
