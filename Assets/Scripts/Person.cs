using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Person
{
    [SerializeField] PersonSO pType;
    [SerializeField] string personName;
    Dictionary<StatSO, StatValue> individualStats;
    [SerializeField] List<StatValue> stats;
    [SerializeField] List<TraitSO> currentTraits;

    public Person(PersonSO p, string pName)
    {
        individualStats = new Dictionary<StatSO, StatValue>();
        foreach(StatValue s in p.baseStats)
        {
            individualStats.Add(s.stat, new StatValue(s.stat, s.defaultValue));
        }
        stats = GetAllStats();
        pType = p;
        personName = pName;
        currentTraits = new List<TraitSO>(p.traits);
    }

    public void refreshStats()
    {
        foreach(StatValue sv in stats)
        {
            sv.defaultValue = pType.mappedBaseStates[sv.stat].defaultValue;
            foreach(TraitSO t in currentTraits)
            {
                sv.defaultValue *= t.value;
            }
            individualStats[sv.stat] = sv;
        }
    }

    public float GetStat(StatSO s)
    {
        return individualStats[s].defaultValue;
    }

    public List<StatValue> GetAllStats()
    {
        return new List<StatValue>(individualStats.Values);
    }

    public string GetName()
    {
        return personName;
    }

    public List<TraitSO> GetTraits()
    {
        return currentTraits;
    }

    public void AddTrait(TraitSO t)
    {
        currentTraits.Add(t);
    }

    public void RemoveTrait(TraitSO t)
    {
        currentTraits.Remove(t);
    }
}
