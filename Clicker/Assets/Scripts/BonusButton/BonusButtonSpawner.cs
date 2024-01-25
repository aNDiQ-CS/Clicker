using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusButtonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttonPrefabs;
    private float _spawnTime;

    [SerializeField] private static int _lifeTime = 5;

    private void Start()
    {
        StartCoroutine(ButtonSpawn());
    }

    public static int GetLifeTime()
    {
        return _lifeTime;
    }

    private IEnumerator ButtonSpawn()
    {
        while (true)
        {
            _spawnTime = Random.Range(2f, 5f);
            yield return new WaitForSeconds(_spawnTime);
            Vector3 position = new Vector3(Random.Range(-8.5f, 4f), Random.Range(-2f, -4f), 0f);
            GameObject newBonusButtonIndex = _buttonPrefabs[Random.Range(0, _buttonPrefabs.Length)];
            GameObject bonusGO = Instantiate(newBonusButtonIndex, position, Quaternion.identity);
            yield return new WaitForSeconds(_lifeTime);
            Destroy(bonusGO);
        }
    }
}
