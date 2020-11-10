using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SelectablePerson : MonoBehaviour
{
    [SerializeField] Person p;

    PersonInfoDisplayer pid;
    PopulationManager pm;
    [SerializeField] TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        pid = FindObjectOfType<PersonInfoDisplayer>();
        pm = FindObjectOfType<PopulationManager>();
    }

    public void SetPerson(Person p)
    {
        this.p = p;
        text.text = p.GetName();
    }

    public void SelectPerson()
    {
        pid.SetPerson(p, gameObject);
    }
}
