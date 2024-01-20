using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [SerializeField]
    private Storage _storage;

    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
        print(_boxCollider.gameObject);
    }

    private void OnMouseDown()
    {
        _storage.Add(1);
    }
}
