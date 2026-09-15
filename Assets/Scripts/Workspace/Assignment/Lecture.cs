using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            //LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            LCT03_SyntaxHashTable();
            //LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            // 1. การสร้าง List
            List<string> items = new List<string>();

            // 2. การเพิ่มข้อมูล (Add / AddRange)
            items.Add("Potion");
            items.Add("Sword");
            items.Add("Shield");

            // 3. การเข้าถึงข้อมูลด้วย Index
            Debug.Log($"Item at index 0: {items[0]}");

            // 4. การแก้ไขข้อมูล
            items[0] = "Super Potion";

            // 5. การตรวจสอบข้อมูลและการหา Index (Contains / IndexOf)
            if (items.Contains("Shield"))
            {
                Debug.Log($"Shield index: {items.IndexOf("Shield")}");
            }

            // 6. การลบข้อมูล (Remove / RemoveAt)
            items.Remove("Sword"); // ลบตามมูลค่า
            items.RemoveAt(0);     // ลบตามตำแหน่ง Index

            // 7. การวน Loop อ่านค่า
            foreach (var item in items)
            {
                Debug.Log($"Remaining item: {item}");
            }

            // 8. การล้างข้อมูลทั้งหมด
            items.Clear();
        }
        

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();

            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> firstNode = linkedlist.First;
            Debug.Log("first: " + firstNode.Value);

            // แก้ไข: lastNode ควรดึงจาก linkedlist.Last
            LinkedListNode<string> lastNode = linkedlist.Last;
            Debug.Log("last: " + lastNode.Value);

            Debug.Log("firstNode.Next: " + firstNode.Next.Value);
            Debug.Log("firstNode.Next.Next: " + firstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + lastNode.Previous.Value);
            Debug.Log("lastNode.Previous.Previous: " + lastNode.Previous.Previous.Value);

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next == null");

            linkedlist.AddAfter(firstNode, "Node 0.5");

            // แก้ไข: เปลี่ยนค่าเป็น "Node 1.5" ตามโครงสร้างที่ต้องการ
            linkedlist.AddBefore(lastNode, "Node 1.5");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");

            if (node1 != null)
            {
                linkedlist.Remove(node1);
            }

            linkedlist.RemoveLast();
            linkedlist.RemoveFirst();
            linkedlist.Clear();
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 1);
            table.Add(true, "");
            table.Add(0, 0);
            table[true] = 1;

            // เพิ่มการวน Loop เพื่อนำข้อมูลออกมากดดูใน Console
            foreach (DictionaryEntry entry in table)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
        

        public void LCT04_SyntaxDictionary()
        {
          Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();

            inv.Add("Potion", 1);

            //"Poion" : 1
            //"Apple" : 10
            inv.Add("Apple", 10);

            inv["Banana"] = 5;

            inv["Potion"] = 10;

            var pickupItem = "Sowrd";
            inv[pickupItem] = 1;

            //foreach(KeyValuePair<string, int> pair in inv)
            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            var appleExists = inv.ContainsKey("Key");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);
            
            inv.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

        }
        #endregion
    }
}
