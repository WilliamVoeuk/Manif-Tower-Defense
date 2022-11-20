using UnityEngine;

public class Protestor : MonoBehaviour
{
    [SerializeField] float _speed;
    private Transform _target;
    int _pathpointIndex = 0;
    [SerializeField] int _healthPoints;
    [SerializeField] int _moneyReward;

    private PlayerStats playerStats;


    private void Start()
    {
        _target = PathPoints.pathPoints[_pathpointIndex];
        playerStats = PlayerStats.instance;
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
        _healthPoints -= dmg;
        if( _healthPoints <= 0 )
        {
            GameObject.Destroy(gameObject);
            playerStats.GetMoney(_moneyReward);
        }
    }

}
