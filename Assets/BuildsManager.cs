using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildsManager : MonoBehaviour
{
    #region Singleton
    public static BuildsManager instance;


    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("already one BuildManager");
        }
        instance = this;
    }
    #endregion
    [SerializeField] GameObject _baseTurretPrefab;
    private GameObject _turretToBuild;

    private void Start()
    {
        _turretToBuild = _baseTurretPrefab;
    }
    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }

    public void Hola()
    {
        Debug.Log("hoya");
    }
}
