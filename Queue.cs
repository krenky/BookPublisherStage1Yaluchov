using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPublisherStage1

{
    public class Queue<T> : IEnumerable<T>
    {
        private int _Front = -1; //позиция головы
        private int _Rear = -1; //позиция хвоста
        private int _Count = 0; //количество элементов
        private readonly int _Size; //размер массива
        private readonly T[] _Array; // массив

        public Queue(int Size)
        {
            
        }

        public bool IsFull() //проверяет заполнена ли очередь
        {
            
        }
        public bool IsEmpty() //возвращает 0 если очередь пуста
        {
           
        }
        public void Add(T Item) // метод добавления
        {

        }
        public T Dequeue() //проверка на пустоту
        {

        }
        public void Remove()
        { 
        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
        }
    }
}
