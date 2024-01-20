using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusButtonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttonPrefabs;
    private float _spawnTime;

    private void Start()
    {
        StartCoroutine(ButtonSpawn());
    }

    private IEnumerator ButtonSpawn()
    {
        while (true)
        {
            _spawnTime = Random.Range(2f, 5f);
            yield return new WaitForSeconds(_spawnTime);
            Vector3 position = new Vector3(Random.Range(-3.75f, -2f), Random.Range(-4f, 3.25f), 0f);
            GameObject newBonusButton = _buttonPrefabs[Random.Range(0, _buttonPrefabs.Length)];
            Instantiate(newBonusButton, position, Quaternion.identity);
        }
    }
}
