using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            //AS01_CountWords();
            //AS02_CountNumber();
            //AS03_CheckValidBrackets();
            //AS04_PrintReverseLinkedList();
            //AS05_FindMiddleElement();
            //AS06_MergeDictionaries();
            //AS07_RemoveDuplicatesFromLinkedList();
            //AS08_TopFrequentNumber();
            //AS09_PlayerInventory();
            //AS10_GameEventQueue();
            //AS11_PlayerStatsTracker();
        }

        #region Assignment

        [Header("AS01 - Count Words")]
        [SerializeField] private string[] as01Words;

        public void AS01_CountWords()
        {
            string[] words = as01Words;
            if (words == null || words.Length == 0) return;

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                    wordCounts[word]++;
                else
                    wordCounts[word] = 1;
            }

            foreach (var kvp in wordCounts)
            {
                Debug.Log($"Word: {kvp.Key}, Count: {kvp.Value}");
            }
        }
            


        [Header("AS02 - Count Number")]
        [SerializeField] private int[] as02Numbers;

        public void AS02_CountNumber()
        {
            int[] numbers = as02Numbers;
            if (numbers == null || numbers.Length == 0) return;

            Dictionary<int, int> numCounts = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (numCounts.ContainsKey(num))
                    numCounts[num]++;
                else
                    numCounts[num] = 1;
            }

            foreach (var kvp in numCounts)
            {
                Debug.Log($"Number: {kvp.Key}, Count: {kvp.Value}");
            }
        }
            
        

        [Header("AS03 - Check Valid Brackets")]
        [SerializeField] private string as03Input;

        public void AS03_CheckValidBrackets()
        {
            string input = as03Input;
            if (string.IsNullOrEmpty(input))
            {
                Debug.Log("Valid Brackets: True");
                return;
            }

            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0) isValid = false;

            Debug.Log($"Input: {input} -> Is Valid: {isValid}");
        }
            
        

        [Header("AS04 - Print Reverse Linked List")]
        [SerializeField] private IntLinkedListInput as04List = new IntLinkedListInput();

        public void AS04_PrintReverseLinkedList()
        {
            LinkedList<int> list = as04List.GetLinkedList();
            if (list == null || list.Count == 0) return;

            LinkedListNode<int> current = list.Last;
            while (current != null)
            {
                Debug.Log($"Value: {current.Value}");
                current = current.Previous;
            }
        }
           
        

        [Header("AS05 - Find Middle Element")]
        [SerializeField] private StringLinkedListInput as05List = new StringLinkedListInput();

        public void AS05_FindMiddleElement()
        {
            LinkedList<string> list = as05List.GetLinkedList();
            if (list == null || list.Count == 0) return;

            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            Debug.Log($"Middle Element: {slow.Value}");
        }
            
        

        [Header("AS06 - Merge Dictionaries")]
        [SerializeField] private StringIntDictionaryInput as06FirstDictionary = new StringIntDictionaryInput();
        [SerializeField] private StringIntDictionaryInput as06SecondDictionary = new StringIntDictionaryInput();

        public void AS06_MergeDictionaries()
        {
            Dictionary<string, int> dict1 = as06FirstDictionary.GetDictionary();
            Dictionary<string, int> dict2 = as06SecondDictionary.GetDictionary();

            Dictionary<string, int> mergedDict = new Dictionary<string, int>(dict1);

            foreach (var kvp in dict2)
            {
                if (mergedDict.ContainsKey(kvp.Key))
                    mergedDict[kvp.Key] += kvp.Value;
                else
                    mergedDict[kvp.Key] = kvp.Value;
            }

            foreach (var kvp in mergedDict)
            {
                Debug.Log($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
        

        [Header("AS07 - Remove Duplicates From Linked List")]
        [SerializeField] private IntLinkedListInput as07List = new IntLinkedListInput();

        public void AS07_RemoveDuplicatesFromLinkedList()
        {
            LinkedList<int> list = as07List.GetLinkedList();
            if (list == null) return;

            HashSet<int> seen = new HashSet<int>();
            LinkedListNode<int> current = list.First;

            while (current != null)
            {
                LinkedListNode<int> nextNode = current.Next;
                if (seen.Contains(current.Value))
                {
                    list.Remove(current);
                }
                else
                {
                    seen.Add(current.Value);
                }
                current = nextNode;
            }

            foreach (var val in list)
            {
                Debug.Log($"Unique Value: {val}");
            }
        }
            
        

        [Header("AS08 - Top Frequent Number")]
        [SerializeField] private int[] as08Numbers;

        public void AS08_TopFrequentNumber()
        {
            int[] numbers = as08Numbers;
            if (numbers == null || numbers.Length == 0) return;

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            int topNumber = numbers[0];
            int maxFrequency = 0;

            foreach (var kvp in counts)
            {
                if (kvp.Value > maxFrequency)
                {
                    maxFrequency = kvp.Value;
                    topNumber = kvp.Key;
                }
            }

            Debug.Log($"Most Frequent Number: {topNumber} (Appeared {maxFrequency} times)");
        }
            
        

        [Header("AS09 - Player Inventory")]
        [SerializeField] private StringIntDictionaryInput as09Inventory = new StringIntDictionaryInput();
        [SerializeField] private string as09ItemName;
        [SerializeField] private int as09Quantity;

        public void AS09_PlayerInventory()
        {
            Dictionary<string, int> inventory = as09Inventory.GetDictionary();
            string itemName = as09ItemName;
            int quantity = as09Quantity;

            if (!string.IsNullOrEmpty(itemName))
            {
                if (inventory.ContainsKey(itemName))
                    inventory[itemName] += quantity;
                else
                    inventory[itemName] = quantity;
            }

            foreach (var item in inventory)
            {
                Debug.Log($"Item: {item.Key}, Quantity: {item.Value}");
            }
        }
            
        

        [Header("AS10 - Game Event Queue")]
        [SerializeField] private GameEventLinkedListInput as10EventQueue = new GameEventLinkedListInput();

        public void AS10_GameEventQueue()
        {
            LinkedList<GameEvent> eventQueue = as10EventQueue.GetLinkedList();
            if (eventQueue == null) return;

            while (eventQueue.Count > 0)
            {
                GameEvent evt = eventQueue.First.Value;
                Debug.Log($"Processing Event: {evt}");
                eventQueue.RemoveFirst();
            }
        }
            

        [Header("AS11 - Player Stats Tracker")]
        [SerializeField] private StringIntDictionaryInput as11PlayerStats = new StringIntDictionaryInput();
        [SerializeField] private string as11StatName;
        [SerializeField] private int as11Value;

        public void AS11_PlayerStatsTracker()
        {
            Dictionary<string, int> playerStats = as11PlayerStats.GetDictionary();
            string statName = as11StatName;
            int value = as11Value;

            if (!string.IsNullOrEmpty(statName))
            {
                playerStats[statName] = value;
            }

            foreach (var stat in playerStats)
            {
                Debug.Log($"Stat: {stat.Key}, Value: {stat.Value}");
            }
        }

    }
        #endregion
    }
