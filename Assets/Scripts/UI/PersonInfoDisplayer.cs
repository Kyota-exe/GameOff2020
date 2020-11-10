using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInfoDisplayer : MonoBehaviour
{
    [SerializeField] GameObject statViewerPrefab;
    List<GameObject> currentInfo;

    [SerializeField] Person personViewing;
    [SerializeField] GameObject personInfoDisplay; //The panel to add all the information

    PopulationManager pm;
    GameObject relatedButton;
 
    private void Start()
    {
        currentInfo = new List<GameObject>();
        pm = FindObjectOfType<PopulationManager>();
    }

    public void SetPerson(Person p, GameObject b)
    {
        relatedButton = b;
        personViewing = p;
        ClearOutCurrentInfo();

        //Add name
        GameObject statViewer = Instantiate(statViewerPrefab, personInfoDisplay.transform);
        statViewer.GetComponent<StatViewer>().SetText("name", p.GetName());
        currentInfo.Add(statViewer);

        //Add all traits
        string traits = "";
        foreach (TraitSO t in p.GetTraits())
        {
            traits += t.traitName + ", ";
        }
        //traits = traits.Substring(0, traits.Length - 2);
        statViewer = Instantiate(statViewerPrefab, personInfoDisplay.transform);
        statViewer.GetComponent<StatViewer>().SetText("trait(s)", traits);
        currentInfo.Add(statViewer);

        //Add all stats
        foreach (StatValue s in p.GetAllStats())
        {
            statViewer = Instantiate(statViewerPrefab, personInfoDisplay.transform);
            statViewer.GetComponent<StatViewer>().SetText(s.stat.name, p.GetStat(s.stat).ToString());
            currentInfo.Add(statViewer);
        }
    }

    public void RemoveSelected()
    {
        pm.RemovePerson(personViewing);
        Destroy(relatedButton);
        ClearOutCurrentInfo();
    }

    private void ClearOutCurrentInfo()
    {
        foreach(GameObject c in currentInfo)
        {
            Destroy(c);
        }
    }
}
