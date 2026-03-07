using System;
using System.Collections;

namespace WinFormsApp_OOP_Lab3_Singleton
{
    public class HouseCollection
    {
        private static HouseCollection _instance;
        private static readonly object _lock = new object();

        public Hashtable Table { get; private set; }
        private readonly RandomGenerator _generator = new RandomGenerator();

        // Приватный конструктор (паттерн Singleton)
        private HouseCollection()
        {
            Table = new Hashtable();
        }

        // Свойство для доступа к единственному экземпляру (потокобезопасное)
        public static HouseCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new HouseCollection();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Add(int key, House house)
        {
            if (Table.ContainsKey(key))
                throw new ArgumentException($"Ключ {key} уже существует.");
            Table.Add(key, house);
        }

        public void Remove(int key)
        {
            if (!Table.ContainsKey(key))
                throw new KeyNotFoundException($"Ключ {key} не найден.");
            Table.Remove(key);
        }

        public void AddRandomItem(int key)
        {
            Add(key, _generator.CreateRandomHouse());
        }

        public int GetItemCount()
        {
            return Table.Count;
        }

        // Возвращает все элементы в виде массива DictionaryEntry
        public DictionaryEntry[] GetAllEntries()
        {
            var entries = new DictionaryEntry[Table.Count];
            Table.CopyTo(entries, 0);
            return entries;
        }
    }
}