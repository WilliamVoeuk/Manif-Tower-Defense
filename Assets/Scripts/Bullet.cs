using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _target;


    [SerializeField] float _speed;
    [SerializeField] float _lifetime;
    [SerializeField] int _Dmg;
    public void Seek(Transform target)
    {
        _target = target;
    }
    void Update()
    {
        //transform.LookAt(_target);
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        _lifetime -= Time.deltaTime;

        if (_lifetime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touché");
        Protestor protestor = collision.gameObject.GetComponent<Protestor>();
        if (protestor != null)
        { 
            protestor.GetDMG(_Dmg);
        }
    }
}
