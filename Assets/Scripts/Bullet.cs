using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _target;


    [SerializeField] float _speed;
    [SerializeField] float _lifetime;

    [SerializeField] float _explosionRadius = 0f;
    public void Seek(Transform target)
    {
        _target = target;
    }
    void Update()
    {
        if(_target == null )
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.LookAt(_target);
        _lifetime -= Time.deltaTime;
        if (_lifetime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (_explosionRadius > 0)
        {
            Explode();
        }
        else
        {
            Damage(collision);
        }
        GameObject.Destroy(gameObject);
    }

    void Explode()
    {

    }
    void Damage(Collision enemy)
    {
        Destroy(enemy.gameObject);
    }
}
