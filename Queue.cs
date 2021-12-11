using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPublisherStage1

{
    public class Queue : IEnumerable
    {
        private int _Count; //количество элементов
        private int _Size; //размер массива
        private Author[] _Array; // массив

        public Queue(int Size)
        {
            _Count = 0;
            _Size = Size;
            _Array = new Author[Size];
        }

        public bool IsFull() //проверяет заполнена ли очередь
        {
            return 1 - _Count == _Size;
        }
        public bool IsEmpty() //возвращает 0 если очередь пуста
        {
            return _Count == 0;
        }
        public bool Add(Author Item) // метод добавления
        {
            _Array[_Count] = Item; // добавление заказа в конец
            _Count++; // увеличение счетчика
            if (_Count == _Array.Length) // если массив заполнен
            {
                _Size *= 2;
                Array.Resize(ref _Array, _Size); // увеличиваем его размер на 2 
                return true;
            }
            return false;
        }
        public bool Dequeue() //проверка на пустоту
        {
            if (_Count != 0) // если массив не пуст
            {
                _Array[0] = null; // удаление заказа из начала
                for (int i = 1; i < _Count; i++) // сдвиг
                    _Array[i - 1] = _Array[i];
                _Count--; // уменьшение счетчика
                return true;
            }
            else return false;
        }

        public int FindIndex(string FirstName) // Поиск заказа
        {
            for (int i = 0; i < _Count; i++) // проход по массиву
            {
                if (_Array[i].PFirstName == FirstName)// если имена совпали 
                {
                    return i; // вовращаем индекс 
                }
            }
            return -1;
        }
        public Author FindAuthor(string FirstName) // Поиск заказа
        {
            for (int i = 0; i < _Count; i++) // проход по массиву
            {
                if (_Array[i].PFirstName == FirstName)// если имена совпали 
                {
                    return _Array[i]; // вовращаем индекс 
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return _Array.GetEnumerator();
        }

    }
}
