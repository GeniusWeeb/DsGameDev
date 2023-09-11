using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList<T> 
{
    public Node head;
    public int currentSize;


    public LinkedList()
    {
        this.head = null;
        currentSize = 0;
        
    }


    public void AddNode(T data)
    { 
        var node =  new  Node(data);

        node.next = this.head;
        this.head = node;
        currentSize++;
        
        
    }

    public List<Node> ShowNodes()
    {

        List<Node> goList = new List<Node>();
        Debug.LogError("Head is " +  this.head.data);
        Node current = this.head;
        while (current != null)
        {
            Debug.LogError(current.data);
            goList.Add(current);
            current = current.next;
        }
        
        return goList;

}



    public class Node
    {
        public Node next;
        public T data;



        public Node(T data)
        {
            this.next = null;
            this.data = data;
        }
    }
}
