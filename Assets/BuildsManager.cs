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
    public GameObject _baseRocketPrefab;
    private GameObject _turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        Debug.Log(turret);
        _turretToBuild = turret;
    }
}
