using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    [SerializeField] protected Shop _shop;

    [SerializeField] private Storage _storage;

    [SerializeField] protected Inventory _inventory;

    [SerializeField] private TextMeshProUGUI _textAmmount, _textPrice;

    [SerializeField] protected int _ammount, _price;

    [SerializeField] private Button _buyButton;

    
    public Table(int a, int p)
    {
        _ammount = a;
        _price = p;
    }

    public virtual void Buy()
    {
        
    }
}
