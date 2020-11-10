using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingInfoDisplayer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI buildingNameText;

    //Cached References
    BuildingManager bManager;
    Building currentBuilding;

    [SerializeField] GameObject statViewerPrefab;
    List<GameObject> currentInfo;

    [SerializeField] GameObject personInfoDisplay; //The panel to add all the information

    GameObject relatedButton;


    // Start is called before the first frame update
    void Start()
    {
        bManager = FindObjectOfType<BuildingManager>();
        currentBuilding = bManager.GetActiveBuilding();
        if(currentBuilding != null)
        {
        }
    }
}
