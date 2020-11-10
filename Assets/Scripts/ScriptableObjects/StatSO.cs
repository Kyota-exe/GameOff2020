using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//These are for stats that individual people and buildings have
[CreateAssetMenu(fileName = "Stat", menuName = "ScritableObjects/Stat", order = 1)]
public class StatSO : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline(5)]
    public string DeveloperDescription = "";
#endif
}
