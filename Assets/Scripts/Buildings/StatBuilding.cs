using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Building that increases specified stats
[CreateAssetMenu(fileName = "StatBuilding", menuName = "ScritableObjects/StatBuilding", order = 8)]
public class StatBuilding : Building
{
    //List of stats it increases
    List<GlobalStatSO> globalStats;
    List<StatSO> stats;
    List<Upgrade> upgrades;
    List<Upgrade> appliedUpgrades;
    List<FormulaStep> formulas;

    public override void CreateUIElements()
    {
        throw new System.NotImplementedException();
    }

    public override void DoAction()
    {
        throw new System.NotImplementedException();
    }
}
