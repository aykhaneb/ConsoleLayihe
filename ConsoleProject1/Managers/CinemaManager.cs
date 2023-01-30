using ConsoleApp11;
using ConsoleApp11.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject1.Managers
{
    class CinemaManager : ICrudService, ICrudPrint
    {
        public Cinema[] _cinema = new Cinema[5];
        private int _currentIndex = 0;
        public void Add(Entity entity)
        {
            if (_currentIndex > 5)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 5 sinema elave etmek mumkundur");
                return;
            }
            _cinema[_currentIndex++] = (Cinema)entity;
            Console.WriteLine("Sinema ugurla elave edildi");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _cinema.Length; i++)
            {
                if (_cinema[i] == null) continue;

                if (_cinema[i].Id == id)
                {
                    return _cinema[i];
                }
            }
            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _cinema;
        }

        public void Print()
        {
            foreach (var item in _cinema)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
