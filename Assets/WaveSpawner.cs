using System.Collections;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] GameObject _protestorPrefab;
    
    [SerializeField] float _waveTimer;
    [SerializeField] Transform _spawner;
    [SerializeField] float _countDown;
    private int _counter = 1;

    [SerializeField] TextMeshProUGUI _waveAnnouncerText;

    void Update()
    {
        if(_countDown <= 0)
        {
            StartCoroutine(StartWave());
            _countDown = _waveTimer;

        }
        _countDown -= Time.deltaTime;
        _waveAnnouncerText.text = $"Next Wave in {Mathf.Floor(_countDown+0.5f)}";  //Math.Ceiling()
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

    public void LaunchWave()
    {
        _countDown = 0f;
    }
}
