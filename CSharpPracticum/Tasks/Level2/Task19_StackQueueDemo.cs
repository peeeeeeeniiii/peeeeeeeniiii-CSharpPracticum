using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class MyStack<T>
    {
        private T[] _items = new T[4]; private int _count;
        public int Count { get { return _count; } }
        public void Push(T item) { if (_count == _items.Length) Array.Resize(ref _items, _items.Length * 2); _items[_count++] = item; }
        public T Pop() { if (_count == 0) throw new InvalidOperationException("Стек пуст."); T item = _items[--_count]; _items[_count] = default(T); return item; }
        public T Peek() { if (_count == 0) throw new InvalidOperationException("Стек пуст."); return _items[_count - 1]; }
    }
    public class MyQueue<T>
    {
        private T[] _items = new T[4]; private int _head, _count;
        public int Count { get { return _count; } }
        public void Enqueue(T item)
        {
            if (_count == _items.Length)
            {
                T[] bigger = new T[_items.Length * 2];
                for (int i = 0; i < _count; i++) bigger[i] = _items[(_head + i) % _items.Length];
                _items = bigger; _head = 0;
            }
            _items[(_head + _count) % _items.Length] = item; _count++;
        }
        public T Dequeue()
        {
            if (_count == 0) throw new InvalidOperationException("Очередь пуста.");
            T value = _items[_head]; _items[_head] = default(T); _head = (_head + 1) % _items.Length; _count--; return value;
        }
    }
    public class Task19_StackQueueDemo : TaskBase
    {
        public override string Title { get { return "19. MyStack и MyQueue"; } }
        public override void Run()
        {
            MyStack<int> stack = new MyStack<int>(); stack.Push(10); stack.Push(20);
            Console.WriteLine("Стек: Pop = " + stack.Pop());
            MyQueue<string> queue = new MyQueue<string>(); queue.Enqueue("первый"); queue.Enqueue("второй");
            Console.WriteLine("Очередь: Dequeue = " + queue.Dequeue());
        }
    }
}
