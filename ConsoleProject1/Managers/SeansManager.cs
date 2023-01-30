using ConsoleApp11;
using ConsoleApp11.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject1.Managers
{
    public class SeansManager : ICrudService, ICrudPrint
    {
        public Seans[] _seans = new Seans[5];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 5)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 5 seans elave etmek mumkundur");
                return;
            }
            _seans[_currentIndex++] = (Seans)entity;
            Console.WriteLine("Seans ugurla elave edildi");

        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null)
                    continue;

                if (id == _seans[i].Id)
                {
                    found = true;
                    for (int j = i; j < _seans.Length - 1; j++)
                    {
                        _seans[j] = _seans[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id}-Idli seans silindi!");
                    return;
                }
            }
            if (!found)
                Console.WriteLine($"{id}-li student not found");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null) continue;

                if (_seans[i].Id == id)
                {
                    return _seans[i];
                }
            }
            Console.WriteLine("Not found!");

             return null;
        }
            public Entity[] GetAll()
            {
            return _seans;
            }

            public void Print()
            {
            foreach (var item in _seans)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

            public void Update(int id, Entity entity)
            {
            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null) continue;

                if (_seans[i].Id == id)
                {
                    _seans[i] = (Seans)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found!");
        }
    }
}

        