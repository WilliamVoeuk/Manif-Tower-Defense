using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] float _lifetime;
    [SerializeField] int _Dmg;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        _lifetime -= Time.deltaTime;

        if (_lifetime <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Protestor protestor = collider.gameObject.GetComponent<Protestor>();
        if (protestor != null)
        {
            protestor.GetDMG(_Dmg);
        }
        GameObject.Destroy(gameObject);
    }
}
