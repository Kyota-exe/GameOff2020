using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Resource", menuName = "ScritableObjects/Resource", order =0)]
public class ResourceSO : ScriptableObject
{
    public string resourceName;
    [TextArea] public string description;
    public Modifier modifier;
}
