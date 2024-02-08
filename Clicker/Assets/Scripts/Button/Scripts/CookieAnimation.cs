using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private float _rotationSpeed = 5f;

    [SerializeField]
    private float _scaleFactor = 0.5f;

    private void OnMouseOver()
    {
        _animator.SetBool("OnMouseHover", true);        
    }

    private void OnMouseExit()
    {
        _animator.SetBool("OnMouseHover", false);
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger("OnMouseClicked");
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);        
    }
}
