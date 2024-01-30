using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    [SerializeField] private Shop _shop;

    [SerializeField] private Storage _storage;

    [SerializeField] private Inventory _inventory;

    [SerializeField] private TextMeshProUGUI _textAmmount, _textPrice;

    [SerializeField] private int _ammount, _price;

    [SerializeField] private Button _buyButton;

    [SerializeField] private Inventory.Youtuber _youtuber;
    
    public Table(int a, int p)
    {
        _ammount = a;
        _price = p;
    }

    public void Buy()
    {
        int currentMoney = _shop.GetAmmount();
        if (currentMoney >= _price)
        {
            print("ÇÀ ÄÅÍÜÃÈ ÄÀ!");
            _inventory.SpawnYoutuber(_youtuber);
        }
        else
            print("ÁÎÌÆ");
    }
}
