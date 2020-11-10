using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class StatValue
{
    public StatSO stat;
    public float defaultValue;
    
    public StatValue(StatSO s, float v)
    {
        stat = s;
        defaultValue = v;
    }

    //public float GetBaseValue()
    //{
     //   float baseChange = 0;
     //   float percentChange = 1;
        //foreach (GlobalStatSO gs in stat.statsThatAffect)
     //   {
         //   if (gs.modifier.isPercent)
          //  {
         //       percentChange *= gs.modifier.GetModifier();
        //    }
         //   else
         //  {
       //         baseChange += gs.modifier.GetModifier();
     //       }
       // }

  //      return (baseValue + baseChange) * (percentChange);
  //  }
}
