using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPublisherStage1
{
    public class LinkedList : IEnumerable  // односвязный список
    {
        Book head = null; // головной/первый элемент
        Book tail = null; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(string name, Author author, int edition)
        {
            Book node = new Book(name, author, edition);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление элемента
        public bool Remove(Book book)
        {
            Book current = head;
            Book previous = null;

            while (current != null)
            {
                    // Если узел в середине или в конце
                    if (current == book)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;

                previous = current;
                current = current.Next;
            }
            return false;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // содержит ли список элемент
        public bool Contains(string Name)
        {
            Book current = head;
            while (current != null)
            {
                if (current.PName.Equals(Name))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        // реализация интерфейса IEnumerable

    }
}
