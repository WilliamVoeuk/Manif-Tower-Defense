
using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject _protestorPrefab;
    
    [SerializeField] float _waveTimer = 5f;
    [SerializeField] Transform _spawner;
    [SerializeField] float _countDown = 2f;
    private int _counter = 1;


    void Update()
    {
        if(_countDown <= 0)
        {
            StartCoroutine(StartWave());
            _countDown = _waveTimer;

        }
        _countDown -= Time.deltaTime;
    }

    IEnumerator StartWave()
    {
        for (int i = 0; i < _counter; i++)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(0.5f);
        }
        _counter++;
    }

    void SpawnEnemies()
    {
        Instantiate(_protestorPrefab, _spawner.position, _spawner.rotation);

    }
}
