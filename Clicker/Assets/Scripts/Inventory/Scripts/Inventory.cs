using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.UIElements;
using static Inventory;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Storage _storage;

    [SerializeField] private Clicker _clicker;

    [SerializeField] private BonusButtonSpawner _bonusButtonSpawner;

    [SerializeField] private GameObject[] _youtubersPrefabs, _equipmentPrefabs;

    [SerializeField] private BonusButton _bonusButton;

    public void SpawnYoutuber(Youtuber _youtuber)
    {
        GameObject youtuberPrefab = _youtubersPrefabs[(int)_youtuber];
        Instantiate(youtuberPrefab, this.transform, false);
        Debug.Log(youtuberPrefab);

        switch (_youtuber)
        {
            case Youtuber.Kuplinov:
                _storage._additionPerSec += 1;
                break;
            case Youtuber.Lololoshka:
                _storage._additionPerSec += 7;
                break;
            case Youtuber.Windy31:
                _storage._additionPerSec += 31;
                break;
            case Youtuber.A4:
                _storage._additionPerSec += 50;
                break;
            case Youtuber.Melstroy:
                _storage._additionPerSec += 150;
                break;
            case Youtuber.MrBeast:
                _storage._additionPerSec += 500;
                break;
            case Youtuber.BrianMaps:
                _storage._additionPerSec += 3000;
                break;
            case Youtuber.ValeraGhoster:
                _storage._additionPerSec += 12000;
                break;
            case Youtuber.Dream:
                _storage._additionPerSec += 45000;
                break;
            case Youtuber.PewDiePie:
                _storage._additionPerSec += 100000;
                break;
        }
    }

    public void SpawnEquipment(Equipment _equipment)
    {
        GameObject equipmentPrefab = _equipmentPrefabs[(int)_equipment];
        Instantiate(equipmentPrefab, this.transform, false);
        Debug.Log(equipmentPrefab);

        switch (_equipment)
        {
            case Equipment.Microphone:
                _clicker._addingAmount += 1;
                break;
            case Equipment.Camera:
                _bonusButtonSpawner._minSpawnTime -= 10;
                _bonusButtonSpawner._maxSpawnTime -= 10;
                break;
            case Equipment.GreenScreen:
                _bonusButton.MultiplyBonusButton(2);
                break;
            case Equipment.PC:
                _storage._additionPerSec *= 5;
                break;
            case Equipment.YoutubeAlgorithms:
                if (_bonusButtonSpawner._usingButtonLastIndex <= 1)
                {
                    _bonusButtonSpawner._usingButtonLastIndex += 1;
                }
                break;
        }
    }

    public enum Youtuber
    {
        Kuplinov,
        Lololoshka,
        Windy31,
        A4,
        Melstroy,
        MrBeast,
        BrianMaps,
        ValeraGhoster,
        Dream,
        PewDiePie
    }

    public enum Equipment
    {
        Microphone,
        Camera,
        GreenScreen,
        PC,
        YoutubeAlgorithms
    }
}
