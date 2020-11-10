using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TraitEventListener : GameEventListener
{
    [Tooltip("Event to register with.")]
    public List<TraitSO> traits;

    private void OnEnable()
    {
        Register();
    }

    private void Register()
    {
        foreach (GameEvent e in traits)
        {
            e.RegisterListener(this);
        }
    }

    public void SetTraits(List<TraitSO> t)
    {
        traits = t;
        Register();
    }

    private void OnDisable()
    {
        foreach (GameEvent e in traits)
        {
            e.UnregisterListener(this);
        }
    }
}
