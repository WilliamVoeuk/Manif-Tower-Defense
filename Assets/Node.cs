using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    [Header("Rendering")]
    [SerializeField] Color _hoverColor;
    private Color _normalColor;
    private Renderer _rend;

    [Header("Build")]
    private GameObject _turret;
    private BuildsManager buildsManager;
    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _normalColor = _rend.material.color;
        buildsManager = BuildsManager.instance;

    }
    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject() || buildsManager.GetTurretToBuild() == null)
        {
            return;
        }

        _rend.material.color = _hoverColor;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject() )
        {
            return;
        }
        if (buildsManager.GetTurretToBuild() == null)
        {
            return;
        }
        if(_turret != null)
        {
            return;
        }

        GameObject turrectToBuild = buildsManager.GetTurretToBuild();
        Vector3 turretPosition = new(transform.position.x, transform.position.y + 0.5f, transform.position.z); 
        _turret = (GameObject)Instantiate(turrectToBuild, turretPosition, transform.rotation);
    }

    private void OnMouseExit()
    {
        _rend.material.color = _normalColor;
    }

}
