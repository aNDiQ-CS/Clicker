using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject[] _youtubersPrefabs;

    [SerializeField] private Storage _storage;

    public void SpawnYoutuber(Youtuber _youtuber)
    {
        GameObject youtuberPrefab = _youtubersPrefabs[(int)_youtuber];
        Instantiate(youtuberPrefab, this.transform, false);
        Debug.Log(youtuberPrefab);

        switch (_youtuber)
        {
            case Youtuber.A4:
                _storage._additionPerSec += 1;
                break;
            case Youtuber.MrBeast:
                break;
        }
    }

    public enum Youtuber
    {
        A4,
        MrBeast
    }
}
