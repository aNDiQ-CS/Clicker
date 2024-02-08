using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BonusButton : MonoBehaviour
{
    [SerializeField] private int _bonus;

    public void MultiplyBonusButton(int k)
    {
        _bonus *= k;
    }

    private void OnMouseDown()
    {
        EventHandler.OnBonusButtonClicked(_bonus);
        Destroy(gameObject);
    }
}
