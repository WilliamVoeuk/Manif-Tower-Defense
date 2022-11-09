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
        buildsManager.SetTurretToBuild(buildsManager._baseTurretPrefab);
    }
    public void BuyRocketTurret()
    {
        buildsManager.SetTurretToBuild(buildsManager._baseRocketPrefab);
    }
}
