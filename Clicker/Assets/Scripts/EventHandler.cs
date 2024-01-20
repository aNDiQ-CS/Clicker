using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    public static Action<int> BonusButtonCollected;

    public static void OnBonusButtonClicked(int bonus)
    {
        BonusButtonCollected?.Invoke(bonus);
    }
}
