using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    [SerializeField] List<Person> people;
    [SerializeField] List<PersonSO> peopleTypes;
    [SerializeField] NameGeneratorSO names;
    [SerializeField] GameObject selectablePeoplePanel;
    [SerializeField] GameObject selectPeopleButton;
    [SerializeField] GameObject personObject;
    [SerializeField] Transform peopleFolder;
    [SerializeField] GlobalStatSO population;
    [SerializeField] GlobalStatSO populationLimit;

    [SerializeField] int startPopulation = 3;

    private Dictionary<Person, GameObject> mappedPeople;

    // Start is called before the first frame update
    void Start()
    {
        mappedPeople = new Dictionary<Person, GameObject>();
        people = new List<Person>();
        while(people.Count < startPopulation)
        {
            CreatePerson();
        }
    }

    public void CreatePerson()
    {
        if(populationLimit.currentValue > population.currentValue)
        {
            Person newP = new Person(peopleTypes[Random.Range(0, peopleTypes.Count)], names.GetRandomName());
            GameObject newButton = Instantiate(selectPeopleButton, selectablePeoplePanel.transform);
            people.Add(newP);
            newButton.GetComponent<SelectablePerson>().SetPerson(newP);
            population.currentValue++;
            GameObject pObject = Instantiate(personObject, peopleFolder);
            pObject.GetComponent<PersonGameObject>().SetPerson(newP);
            pObject.GetComponent<TraitEventListener>().SetTraits(newP.GetTraits());
            mappedPeople.Add(newP, pObject);
        }
        else
        {
            Debug.Log("Max population reached");
        }
    }

    public void RemovePerson(Person p)
    {
        if (people.Contains(p))
        {
            people.Remove(p);
            population.currentValue--;
            Destroy(mappedPeople[p].gameObject);
            mappedPeople.Remove(p);
        }
        else
        {
            Debug.Log("Person doesn't exist");
        }
    }

    public int GetPopulation()
    {
        return people.Count;
    }
}
