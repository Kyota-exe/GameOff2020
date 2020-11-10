using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PersonSO), editorForChildClasses: true)]
public class PersonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUILayout.Label("Push the button if expected stats does not equal base stats size");
        GUILayout.Label("Only for cases when making a new person. If you messed up restart");
        if (GUILayout.Button("Add Missing Stats"))
        {
            PersonSO e = target as PersonSO;
            e.AddAllMissingStats();
        }
    }
}
