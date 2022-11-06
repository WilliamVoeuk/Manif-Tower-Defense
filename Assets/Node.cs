using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] Color _hoverColor;

    private GameObject _turret;
    private Color _normalColor;
    private Renderer _rend;

    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _normalColor = _rend.material.color;
    }
    private void OnMouseEnter()
    {
        _rend.material.color = _hoverColor;
    }

    private void OnMouseDown()
    {
        if(_turret != null)
        {
            Debug.Log("no");
            return;
        }

        GameObject turrectToBuild = BuildsManager.instance.GetTurretToBuild();
        Vector3 turretPosition = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z); 
        _turret = Instantiate(turrectToBuild, turretPosition, transform.rotation);
    }

    private void OnMouseExit()
    {
        _rend.material.color = _normalColor;
    }

}
