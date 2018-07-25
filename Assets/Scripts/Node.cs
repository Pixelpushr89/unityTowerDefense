using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color defaultColor;

    void Start()
    {
        // cache it
        rend = GetComponent<Renderer>();
        defaultColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there! - TODO Display on screen.");
                return;
        }

        // build a turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = defaultColor;
    }
}
