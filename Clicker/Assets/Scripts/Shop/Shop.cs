using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private Storage _storage;

    List<Table> tables = new List<Table>();

    public int GetAmmount()
    {
        return _storage.Ammount;
    }
}
