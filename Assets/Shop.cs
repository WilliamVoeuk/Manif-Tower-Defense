using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildsManager buildsManager;

    private void Start()
    {
        buildsManager = BuildsManager.instance;
    }
    public void BuyBasicTurret()
    {
        Debug.Log("Basic Turret Selected");

        buildsManager.SetTurretToBuild(buildsManager._baseTurretPrefab);
    }
}
