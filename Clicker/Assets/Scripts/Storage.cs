using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    private int _ammount;
    
    public int Ammount => _ammount;

    private void Start()
    {
        _ammount = 0;
    }

    public void Add(int a)
    {
        _ammount += a;
        print(Ammount);
    }

}
