
using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class RunLinkedList : MonoBehaviour
{


    private LinkedList<int> list;

    [SerializeField]private int data;
    [SerializeField]private GameObject go;


    private void Start()
    {
        list = new LinkedList<int>();
       
        
    }


    [ContextMenu("Add Node")]
    public void Add()
    {
       list.AddNode(data);
       Debug.LogError("Data Added");
    }


    [ContextMenu("Show the nodes")]
    public void Show()
    {
      var elementList =  list.ShowNodes();
      foreach (LinkedList<int>.Node node in  elementList)
      {
         GameObject g =  Instantiate(go, transform.localPosition, Quaternion.identity, transform.parent);
         g.transform.localPosition += new Vector3(1f, 2f, 3f);
         g.name =  node.data.ToString();
      }
    }
    
}


