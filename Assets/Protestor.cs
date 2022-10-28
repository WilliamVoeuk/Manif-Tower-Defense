using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protestor : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Transform _destination;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = _destination.position - transform.position;
        transform.Translate(_speed * Time.deltaTime * direction.normalized);
        if(direction.sqrMagnitude < 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
