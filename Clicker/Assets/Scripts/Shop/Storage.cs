using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data.SqlTypes;
using UnityEditor;

public class Storage : MonoBehaviour
{
    private int _ammount;
    public int _additionPerSec;

    float _temp;

    public int Ammount => _ammount;

    private void Start()
    {
        _ammount = 0;
        EventHandler.BonusButtonCollected += Add;
    }

    private void Update()
    {
        AddPerTick();
    }

    public void Add(int a)
    {
        _ammount += a;
        print(Ammount);
    }

    private void AddPerTick()
    {
        _temp += _additionPerSec * Time.deltaTime;
        if (_temp >= 1) {
            _ammount += (int)_temp;
            _temp = 0;
        }
    }
}
