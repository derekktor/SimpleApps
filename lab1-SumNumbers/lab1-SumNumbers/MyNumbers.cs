using System;
namespace lab1_SumNumbers
{
    public class MyNumbers
    {
        int[] _values;
        int _buffer;
        int _cursor;

        public MyNumbers(int buffer = 5)
        {
            _values = new int[buffer];
            _buffer = buffer;
            _cursor = 0;
        }

        public void add(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Error: Can't enter negative number!!!");
                return;
            }

            if (_cursor == _buffer)
            {
                _buffer = _cursor;
                increaseSize();
            }

            _values[_cursor] = num;
            _cursor++;
        }

        public string getInfo()
        {
            Console.WriteLine("HELLLOOOOO");

            string result = "";

            result += "Length: " + getLength() + "\n";
            result += "Buffer: " + getBuffer() + "\n";
            result += "Sum: " + getSum() + "\n";

            result += "[ ";
            for(int i = 0; i < getLength(); i++)
            {
                string number = getValueAt(i).ToString();
                result += number + " ";
            }
            result += " ]";


            return result;
        }

        public int getSum()
        {
            int sum = 0;
            for (int i = 0; i < getLength(); i++)
            {
                sum += getValueAt(i);
            }
            return sum;
        }

        public int[] getValues()
        {
            return _values;
        }

        public int getValueAt(int index)
        {
            return _values[index];
        }

        public int getLength()
        {
            return _cursor - 1;
        }

        public int getBuffer()
        {
            return _buffer;
        }

        public void increaseSize()
        {
            _buffer *= 2;
            Array.Resize<int>(ref _values, _buffer);
        }
    }
}
