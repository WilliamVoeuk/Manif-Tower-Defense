using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float _range;
    [SerializeField] public Transform _target;
    public Transform target;
    public string protestorTag = "Protestor";

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);

    }
    void UpdateTarget()
    {
        GameObject[] protestors = GameObject.FindGameObjectsWithTag(protestorTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestProtestor = null;
        
        foreach(GameObject protestor in protestors)
        {
            float distanceToProtestor = Vector3.Distance(transform.position, protestor.transform.position);

            if(distanceToProtestor < shortestDistance)
            {
                shortestDistance = distanceToProtestor;
                nearestProtestor = protestor;
            }
        }

        if(nearestProtestor != null && shortestDistance <= _range)
        {
            target = nearestProtestor.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        //UpdateTarget();
        transform.LookAt(_target);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _range);
    }
}
