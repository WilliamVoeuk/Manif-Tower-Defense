using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _target;


    [SerializeField] float _speed;
    [SerializeField] float _lifetime;
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
        GameObject.Destroy(collision.gameObject);
    }
}
