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
    public GameObject _baseTurretPrefab;
    private GameObject _turretToBuild;


    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        Debug.Log("Turret in setter");
        _turretToBuild = turret;
    }
}
