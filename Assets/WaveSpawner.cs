
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject _protestorPrefab;
    [SerializeField] float _waveTimer = 5f;
    [SerializeField] Transform _spawner;
    [SerializeField] float _countDown = 2f;
    void Update()
    {
        if(_countDown <= 0)
        {
            StartWave();
            _countDown = _waveTimer;

        }
        _countDown -= Time.deltaTime;
    }
    void StartWave()
    {
        Debug.Log("Oya");
        Instantiate(_protestorPrefab, _spawner.position, _spawner.rotation);
    }
}
