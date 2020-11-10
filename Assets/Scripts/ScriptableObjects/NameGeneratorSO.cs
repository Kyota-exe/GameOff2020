using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "NameGenerator", menuName = "ScritableObjects/Names", order = 4)]
public class NameGeneratorSO : ScriptableObject
{
    public List<string> names;

    public string GetRandomName()
    {
        return names[Random.Range(0, names.Count)];
    }

    private void OnEnable()
    {
        names = names.Distinct().ToList();
    }
}
