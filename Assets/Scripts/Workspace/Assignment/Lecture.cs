using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            LCT01_SyntaxList();
            LCT02_SyntaxLinkedList();
            LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 5);
            table.Add(5, "Potion");

            foreach (var item in table)
            {
                Debug.Log($"Item: {item}");
            }
        }

        public void LCT02_SyntaxLinkedList()
        {
            // string[] playerNames = new string[1000];

            // -> null
            LinkedList<string> linkedlist = new LinkedList<string>();

            // [Node 1] -> null
            linkedlist.AddLast("Node 1");
            // [Node 1] -> [Node 2] -> null
            linkedlist.AddLast("Node 2");
            // [Node 0] -> [Node 1] -> [Node 2] -> null
            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            // Debug.Log(node1.Next.Next.Value);
            Debug.Log(node1.Previous.Value);

            var firstNode = linkedlist.First;
            var lastNode = linkedlist.Last;
            Debug.Log(firstNode.Previous);
            Debug.Log(lastNode.Next);

            // [Node 0] -> [Node 1] -> [*Node 1.5] -> [Node 2] -> null
            linkedlist.AddAfter(node1, "Node 1.5");
            // [Node 0] -> [*Node 0.5] -> [Node 1] -> [Node 1.5] -> [Node 2] -> null
            linkedlist.AddBefore(node1, "Node 0.5");

            // [Node 0.5] -> [Node 1] -> [Node 1.5] -> [Node 2] -> null
            linkedlist.RemoveFirst();
            // [Node 0.5] -> [Node 1] -> [Node 1.5] -> null
            linkedlist.RemoveLast();
            // [Node 0.5] -> [Node 1] -> null
            linkedlist.Remove("Node 1.5");

            // -> null
            linkedlist.Clear();

            foreach (var item in linkedlist)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            // var inv = new Dictionary<string, int>();

            // Potion: 5
            // Banana: 1
            // Apple: 10
            inv.Add("Potion", 5);
            inv.Add("Banana", 1);
            inv.Add("Apple", 10);

            // Potion: 5
            // Banana: 1
            // Apple: 0
            inv["Apple"] = 0;

            // Potion: 5
            // Banana: 1
            // Apple: 10
            // Apple1: 1
            inv["Apple1"] = 1;

            int potion = inv["Potion"];
            Debug.Log($"Potion: {potion}");

            // int apple2 = inv["Apple2"];
            // Debug.Log($"Apple2: {apple2}");

            bool hasPotion = inv.ContainsKey("Potion");
            Debug.Log($"Has Potion: {hasPotion}");

            inv.Remove("Banana");

            foreach (KeyValuePair<string, int> kvp in inv)
            {
                var key = kvp.Key;
                var value = kvp.Value;
                Debug.Log($"{key}: {value}");
                // inv.add("mm", 1); // This will throw an exception because the key already exists
            }

            inv.Clear();
        }

        #endregion
    }
}
