using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField] Building activeBuilding;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero, LayerMask.GetMask("Building"));

            if(hit.collider != null)
            {
                activeBuilding = hit.collider.GetComponent<Building>();
            }
        }
    }

    public Building GetActiveBuilding()
    {
        return activeBuilding;
    }

    public void AddBuilding()
    {

    }
}
