using UnityEngine;

public class GunBullet : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _lifetime;
    //[SerializeField] int _damage;
    private Transform _target;

    public void Seek(Transform target)
    {
        _target = target;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        _lifetime -= Time.deltaTime;
        if (_lifetime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
