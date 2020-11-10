using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is for a stat that is tracked in the game that is related to many different objects
[CreateAssetMenu(fileName = "GlobalStat", menuName = "ScritableObjects/GlobalStat", order = 7)]
public class GlobalStatSO : ScriptableObject
{
    public string statName;
    [TextArea] public string description;
    public float currentValue;
    public float startValue;
    public bool reset;
    public Modifier modifier;

    private void OnEnable()
    {
        if(reset)
        {
            currentValue = startValue;
        }
    }
}
