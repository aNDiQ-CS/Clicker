using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusButtonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttonPrefabs;
    private float _spawnTime;

    [SerializeField] private int _lifeTime = 5;

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
            GameObject bonusGO = Instantiate(newBonusButton, position, Quaternion.identity);
            yield return new WaitForSeconds(_lifeTime);
            Destroy(bonusGO);
        }
    }
}
