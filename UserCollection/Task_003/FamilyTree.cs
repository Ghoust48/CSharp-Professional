using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_003
{
    public class FamilyTree : ICollection
    {
        private List<Human> _familyTrees = new List<Human>();

        public void Add(Human human)
        {
            _familyTrees.Add(human);
        }

        public void Delete(Human human)
        {
            _familyTrees.Remove(human);
        }

        public IEnumerator GetEnumerator()
        {
            return _familyTrees.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            _familyTrees.CopyTo((Human[]) array, index);
        }

        public int Count { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }

        public void GetHumansByBirthday(int year)
        {
            foreach (var human in _familyTrees)
            {
                if (human.Birthday.Year == year)
                {
                    Console.WriteLine(human);
                }
            }
        }

        public void GetChildren(Human parent)
        {
            foreach (var human in _familyTrees)
            {
                if (human.Parent == parent)
                {
                    Console.WriteLine(human);
                    GetChildren(human);
                }
            }
        }
    }
}