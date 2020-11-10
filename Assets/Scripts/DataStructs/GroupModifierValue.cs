using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

[Serializable]
public class GroupModifierValue
{
    [SerializeField] Jobs[] jobs;
    [SerializeField] Personalities[] traits;
    [SerializeField] Stats[] stats;
    [SerializeField][Range(0, 2)] float value;

    public Jobs[] GetJobs()
    {
        return jobs;
    }

    public Personalities[] GetTraits()
    {
        return traits;
    }

    public Stats[] GetStats()
    {
        return stats;
    }

    public float GetValue()
    {
        return value;
    }
}
