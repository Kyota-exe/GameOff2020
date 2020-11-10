using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatViewer : MonoBehaviour
{
    StatSO stat;
    float value;

    [SerializeField] TextMeshProUGUI statText;

    public void SetText(StatValue s)
    {
    //    statText.text = s.stat.name + " :  " + s.baseValue;
    }

    public void SetText(string title, string value)
    {
        statText.text = title + " :  " + value;
    }
}
