using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieAnimation : MonoBehaviour
{
    [SerializeField]
    Animator _animator;

    [SerializeField]
    float _rotationSpeed = 5f;

    [SerializeField]
    float _scaleFactor = 0.5f;

    private void OnMouseOver()
    {
        _animator.SetBool("OnMouseHover", true);        
    }

    private void OnMouseExit()
    {
        _animator.SetBool("OnMouseHover", false);
    }

    void Update()
    {
        
        transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);        
    }
}
