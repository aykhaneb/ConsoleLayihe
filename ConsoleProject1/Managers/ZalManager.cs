using ConsoleApp11;
using ConsoleApp11.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject1.Managers
{
    public class ZalManager : ICrudService, ICrudPrint
    {
        private Zal[] _zal = new Zal[5];
        public int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 5)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 5zal elave etmek mumkundur");
                return;
            }
            _zal[_currentIndex++] = (Zal)entity;
            Console.WriteLine("Zal ugurla elave edildi");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _zal.Length; i++)
            {
                if (_zal[i] == null)
                    continue;

                if (id == _zal[i].Id)
                {
                    found = true;

                    for (int j = i; j < _zal.Length - 1; j++)
                    {
                        _zal[j] = _zal[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id}-li zal silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"{id}-li zal not found");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _zal.Length; i++)
            {
                if (_zal[i] == null) continue;

                if (_zal[i].Id == id)
                {
                    return _zal[i];
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _zal;
        }

        public void Print()
        {
            foreach (var item in _zal)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _zal.Length; i++)
            {
                if (_zal[i] == null) continue;

                if (_zal[i].Id == id)
                {
                    _zal[i] = (Zal)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found!");
        }
    }
}
