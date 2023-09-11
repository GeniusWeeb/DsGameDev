using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList<T> 
{
    private Node head;
    private Node tail;
    public int currentSize {    get ; private set; } 


    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        currentSize = 0;
        
    }


    public void AddNode(T data)
    { 
        var node =  new  Node(data);

        if (head == null) // empty list
        {
            head = tail = node;
        }
        else
        {
            node.next = this.head;
            this.head = node;
        }
        currentSize++;
        
    }
        
    
    //Make use of tail
    public void AddNodeAtEnd(T data)
    {
        var node = new Node(data);

        if (head == null)
        {
            Debug.LogError("List is empty. now adding new element");
            head = tail = node;
        }
        else
        {   
            Debug.LogError("Elemt exist in the node");
             // node.next = tail; -> basically means that node.next -> null , since tail is null
            this. tail.next = node;
             tail = node;
        }

        currentSize++;
      

    }

    public List<Node> ShowNodes()
    {

        List<Node> goList = new List<Node>();
        Debug.LogError("Head is " +  this.head.data);
        Debug.LogError("Tail is " + this.tail.data);
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
