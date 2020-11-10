using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonGameObject : MonoBehaviour
{
    Person p;

    public void SetPerson(Person p)
    {
        this.p = p;
        UpdateStats();
    }    

    public void UpdateStats()
    {
        p.refreshStats();
    }
}
