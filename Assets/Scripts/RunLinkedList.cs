
using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class RunLinkedList : MonoBehaviour  
{
    
    private LinkedList<int> list;

    [SerializeField]private int data;
    [SerializeField]private GameObject go;

    [SerializeField] private Transform listHolder;


    private void Start()
    {
        list = new LinkedList<int>();
    }


        [ContextMenu("Add Node")]
        public void AddANode()
        {
           list.AddNode(data);
           Debug.LogError("Data Added");
        }



        [ContextMenu("Add Node at the end")]
        public void AddNodeAtTheEnd()
        {
              list.AddNodeAtEnd(data);
            
        }


        
        
        public void RemoveFirst()
        {
          var removedNode =  list.RemoveFirstNode();
          Debug.LogError("Removed Node" + removedNode.data);

        }


        public void RemoveLast()
        {
          var removedNode =   list.RemoveLastNode();
          Debug.LogError("Removed Node" + removedNode.data);

        }

        [ContextMenu("Show the nodes")]
        public void ShowAllNodes()
        {
          var elementList =  list.ShowNodes();
          foreach (LinkedList<int>.Node node in  elementList)
          {
              CleanUPHolder(); 
              GameObject g =  Instantiate(go, transform.localPosition, Quaternion.identity, listHolder.transform);
             g.transform.localPosition  =  transform.localPosition +  new Vector3(5f,  0f , 0f);
             g.name =  node.data.ToString();

          }
        }

        private void CleanUPHolder()
        {
            foreach (Transform item in listHolder)
            {
                Destroy(item.gameObject);
            }
        }


  }



