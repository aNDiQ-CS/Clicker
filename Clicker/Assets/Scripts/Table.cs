using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    [SerializeField]
    private Shop _shop;

    [SerializeField]
    private TextMeshProUGUI _textAmmount, _textPrice;

    [SerializeField]
    private int _ammount, _price;

    [SerializeField]
    private Button _buyButton;
    
    public Table(int a, int p)
    {
        _ammount = a;
        _price = p;
    }

    public void Buy()
    {
        int currentMoney = _shop.GetAmmount();
        if (currentMoney >= _price)
            print("гю демэцх дю!");
        else
            print("анлф");
    }
}
