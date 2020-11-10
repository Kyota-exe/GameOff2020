using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Trait", menuName = "ScritableObjects/Trait", order = 2)]
public class TraitSO : GameEvent
{
    public string traitName;
    [TextArea] public string description;
    public float value;

    private void OnEnable()
    {   
    }

    public void ModifyValue(float value)
    {
        this.value = value;
        Raise();
    }
}
