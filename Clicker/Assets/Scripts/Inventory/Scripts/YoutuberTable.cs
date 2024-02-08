using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class YoutuberTable : Table
{
    [SerializeField] private Inventory.Youtuber _youtuber;

    public YoutuberTable(int a, int p) : base(a, p) { }

    public override void Buy()
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
