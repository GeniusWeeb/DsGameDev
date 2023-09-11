
using UnityEditor;
using UnityEngine;



[CustomEditor(typeof(RunLinkedList))]
public class LinkedListEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var list = (RunLinkedList)target;

        
        if (GUILayout.Button("Add Node"))
        {
            list.AddANode();
        }
        
        if (GUILayout.Button("Add Node At End"))
        {
            list.AddNodeAtTheEnd();
        }
        if (GUILayout.Button("Remove First Node"))
        {
            list.RemoveFirst();
        }
        
        if (GUILayout.Button("Remove Last Node"))
        {
            list.RemoveLast();
        }
        
        if (GUILayout.Button("Show All Nodes"))
        {
            list.ShowAllNodes();
        }
        
        
     

    }
}
