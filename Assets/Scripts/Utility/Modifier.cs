using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Modifier 
{
    public float change;
    public bool isPercent;
    public float GetModifier()
    {
        return change;
    }
}
