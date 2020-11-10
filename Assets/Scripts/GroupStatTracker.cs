using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GroupStatTracker
{
    [SerializeField] List<Person> peopleInGroup;
    [SerializeField] Jobs job;
    [SerializeField] int count;

    [SerializeField] float totalHappiness;
    [SerializeField] float totalProduction;
    [SerializeField] float totalHealth;
    [SerializeField] float totalIntelligence;
    [SerializeField] float totalCreativity;

    [SerializeField] float averageHappiness;
    [SerializeField] float averageProduction;
    [SerializeField] float averageHealth;
    [SerializeField] float averageIntelligence;
    [SerializeField] float averageCreativity;

    public GroupStatTracker()
    {
        peopleInGroup = new List<Person>();
    }

    public void AddNewIndividual(Person i)
    {
        count++;
        peopleInGroup.Add(i);

        averageHappiness = totalHappiness / count;
        averageCreativity = totalCreativity / count;
        averageHealth = totalHealth / count;
        averageIntelligence = totalIntelligence / count;
        averageProduction = totalProduction / count;
    }

    public float GetAverageHappiness()
    {
        return averageHappiness;
    }

    public float GetAverageCreativity()
    {
        return averageCreativity;
    }

    public float GetAverageHealth()
    {
        return averageHealth;
    }

    public float GetAverageProduction()
    {
        return averageProduction;
    }

    public float GetAverageIntelligence()
    {
        return averageIntelligence;
    }

}
