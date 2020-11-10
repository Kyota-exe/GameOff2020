using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : ScriptableObject
{
    public string buildingName;
    [TextArea] public string description;

    public abstract void DoAction();

    public abstract void CreateUIElements();

    public void SetBuildingName(string name)
    {
        buildingName = name;
    }

    public string GetBuildingName()
    {
        return buildingName;
    }
}
