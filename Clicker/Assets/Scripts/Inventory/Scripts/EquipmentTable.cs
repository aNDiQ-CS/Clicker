using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Inventory;

public class EquipmentTable : Table
{
    [SerializeField] private Inventory.Equipment _equipment;

    public EquipmentTable(int a, int p) : base(a, p) { }

    public override void Buy()
    {
        int currentMoney = _shop.GetAmmount();
        if (currentMoney >= _price)
        {
            print("ÇÀ ÄÅÍÜÃÈ ÄÀ!");
            _inventory.SpawnEquipment(_equipment);
        }
        else
            print("ÁÎÌÆ");
    }
}
