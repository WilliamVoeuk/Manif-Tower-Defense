using UnityEngine;
using UnityEngine.UI;

public class Protestor : MonoBehaviour
{
    [SerializeField] float _speed;
    private Transform _target;
    int _pathpointIndex = 0;
    [SerializeField] int _healthPoints;
    int _currentHealth;
    [SerializeField] int _moneyReward;
    [SerializeField] Slider Healthbar;
    private PlayerStats playerStats;

    public AudioClip[] _dyingSounds;
    [SerializeField] AudioSource _dyingSoundsource;


    private void Start()
    {
        _currentHealth = _healthPoints;
        Healthbar.maxValue = _healthPoints;
        Healthbar.value = _healthPoints;
        _target = PathPoints.pathPoints[_pathpointIndex];
        playerStats = PlayerStats.instance;

        //_dyingSoundsource.clip = _dyingSounds[0];

    }
    void Update()
    {

        Vector3 direction = _target.position - transform.position;
        transform.Translate(_speed * Time.deltaTime * direction.normalized);
        if (direction.sqrMagnitude < 0.2f)
        {
            GetNextPoint();

        }

    }
    void GetNextPoint()
    {
        if( _pathpointIndex >= PathPoints.pathPoints.Length -1 )
        {
            playerStats.HpLose(1);
            Destroy(gameObject);
            return;

        }
        _pathpointIndex++;
        _target = PathPoints.pathPoints[_pathpointIndex];
    }
    public void GetDMG(int dmg)
    {
        _currentHealth -= dmg;
        Healthbar.value = (_currentHealth);
        if (_currentHealth <= 0 )
        {
            _dyingSoundsource.Play();
            GameObject.Destroy(gameObject);
            playerStats.GetMoney(_moneyReward);
        }
    }

}
