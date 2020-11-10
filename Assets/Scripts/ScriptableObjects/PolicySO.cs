using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Policy", menuName = "ScritableObjects/Policy", order = 1)]
public class PolicySO : ScriptableObject
{
    [SerializeField] int id;
    [SerializeField] [TextArea] string text;
    [SerializeField] GroupModifierValue[] modifiers;

    public int GetId()
    {
        return id;
    }
    public string GetText()
    {
        return text;
    }

    public GroupModifierValue[] GetModifiers()
    {
        return modifiers;
    }

    public string DisplayText()
    {
        string display = text + "<br>";
        string jobs = "";
        string traits = "";
        string stats = "";
        foreach (GroupModifierValue gmv in modifiers)
        {
            foreach(Jobs j in gmv.GetJobs())
            {
                jobs += j.ToString() + ", ";
            }
            jobs = jobs.Remove(jobs.Length - 2);            

            foreach(Personalities p in gmv.GetTraits())
            {
                traits += p.ToString() + ", ";
            }
            traits = traits.Remove(traits.Length - 2);

            foreach(Stats s in gmv.GetStats())
            {
                stats += s.ToString() + ", ";
            }
            stats = stats.Remove(stats.Length - 2);

            display += jobs + "<br>";
            display += traits + "<br>";
            display += stats + "<br>";
            display += gmv.GetValue() + "<br><br>";
        }

        return display;
    }
}
