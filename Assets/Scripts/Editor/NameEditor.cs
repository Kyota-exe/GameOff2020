using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NameGeneratorSO), editorForChildClasses: true)]
public class NameEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Test"))
        {
            NameGeneratorSO e = target as NameGeneratorSO;
            Debug.Log(e.GetRandomName());
        }        
    }
}
