using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class FormulaStep
{
    float startValue;
    bool isPercentage;
    float modifier;

    public float Calculate()
    {
        return (isPercentage) ? startValue * modifier : startValue + modifier;
    }
}
