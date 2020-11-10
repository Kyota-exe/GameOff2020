using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//[CreateAssetMenu(fileName = "People", menuName = "ScritableObjects/People", order = 3)]
public class PersonSO : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline(5)]
    public string DeveloperDescription = "";
#endif

    public List<TraitSO> traits;

    public List<StatValue> baseStats;
    

    public int expectedStats;


    private List<StatSO> alreadyAdded;
    public Dictionary<StatSO, StatValue> mappedBaseStates;

    private void OnEnable()
    {
        mappedBaseStates = new Dictionary<StatSO, StatValue>();
        foreach(StatValue sv in baseStats)
        {
            mappedBaseStates.Add(sv.stat, sv);
        }
    }

    public void AddAllMissingStats()
    {
        if(alreadyAdded == null || alreadyAdded.Count != baseStats.Count)
        {
            expectedStats = 0;
            alreadyAdded = new List<StatSO>();
            baseStats = new List<StatValue>();
        }
        string[] guids = AssetDatabase.FindAssets("t:" + typeof(StatSO).Name);  //FindAssets uses tags check documentation for more info
        StatSO[] a = new StatSO[guids.Length];
        for (int i = 0; i < guids.Length; i++)         //probably could get optimized 
        {            
            string path = AssetDatabase.GUIDToAssetPath(guids[i]);
            a[i] = AssetDatabase.LoadAssetAtPath<StatSO>(path);
            if (!alreadyAdded.Contains(a[i]))
            {
                baseStats.Add(new StatValue(a[i], 50));
                alreadyAdded.Add(a[i]);
            }            
        }
        expectedStats = alreadyAdded.Count;
    }
}
