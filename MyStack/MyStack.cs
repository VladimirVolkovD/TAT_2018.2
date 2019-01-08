using System;

namespace Stack
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO)
    /// collection of instances of the same specified type.
    /// </summary>
    /// <typeparam name="T">Generic data type.</typeparam>
    class MyStack<T>
    {
        private int _maxSize;
        private int _actualSize;
        private T[] _stackArr;

        /// <summary>
        /// Initializes a new instance of the MyStack class that is empty.
        /// </summary>
        public MyStack()
        {
            _stackArr = new T[1];
            _actualSize = 0;
            _maxSize = 1;
        }

        /// <summary>
        /// Initializes a new instance of MyStack with the specified initial capacity.
        /// </summary>
        /// <param name="initialCapacity"></param>
        public MyStack(int initialCapacity)
        {
            _stackArr = new T[initialCapacity];
            _actualSize = initialCapacity;
            _maxSize = initialCapacity;
        }

        /// <summary>
        /// Resizes stack to new capacity.
        /// </summary>
        /// <param name="newCapacity">Value of new capacity.</param>
        public void Resize(int newCapacity)
        {
            Array.Resize(ref _stackArr, newCapacity);
            _maxSize = newCapacity;
            if (newCapacity < _actualSize)
            {
                _actualSize = newCapacity;
            }
        }

        /// <summary>
        /// Inserts an object at the top of the stack.
        /// </summary>
        /// <param name="newValue">The value of the new element for add.</param>
        public void Push(T newValue)
        {
            if ((_maxSize == _actualSize) && (_maxSize != 0))
            {
                Array.Resize(ref _stackArr, _stackArr.Length + 1);
                _stackArr[_stackArr.Length - 1] = newValue;
                _actualSize = _stackArr.Length;
                _maxSize = _stackArr.Length;
                Console.WriteLine("stack size was increased");
            }
            else
            {
                _stackArr[_actualSize] = newValue;
                _actualSize++;
            }
        }

        /// <summary>
        /// Returns the object at the top of the stack without removing it.
        /// </summary>
        /// <returns>
        /// Returns the object at the top of the stack
        /// or null if stack is empty.
        /// </returns>
        public T GetHead()
        {
            if (_stackArr != null)
            {
                return _stackArr[_stackArr.Length - 1];
            }

            return default(T);
        }

        /// <summary>
        /// Removes and returns the object at the top of the stack.
        /// </summary>
        /// <returns>The object at the top of the stack or null if stack is empty.</returns>  
        public T Pop()
        {
            if (_actualSize > 0)
            {
                T returnableElement = _stackArr[_actualSize - 1];
                _stackArr[_actualSize - 1] = default(T);
                _actualSize--;
                return returnableElement;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
        }
    }
}
