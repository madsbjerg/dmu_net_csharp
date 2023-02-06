namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time = "02:30:42";
            Console.WriteLine(time.Substring(0, 2));
            Console.WriteLine(time.Substring(3, 2));
            Console.WriteLine(time.Substring(6, 2));

            Console.WriteLine("Hello, World!");
            Time t = new Time("02:30:42");
            Console.WriteLine(t.ToString());

        }

        struct Time
        {
            private int _secondsSinceMidnight = 0;
            private const int _maxSeconds = 86400;

            public Time(string time)
            {
                string[] s = time.Split(":");
                Hour = int.Parse(s[0]);
                Min = int.Parse(s[1]);
                Sec = int.Parse(s[2]);
            }

            public override string ToString()
            {
                return $"{Hour}:{Min}:{Sec}";
            }

            public int Hour
            {
                set
                {
                    int temp = _secondsSinceMidnight % 3600;
                    _secondsSinceMidnight = (temp + value * 3600) % _maxSeconds;
                }
                get
                {
                    return _secondsSinceMidnight / 3_600;
                }
            }

            public int Min
            {
                set
                {
                    int temp = _secondsSinceMidnight % 60;
                    _secondsSinceMidnight = (temp + value * 60 + Hour * 3600) % _maxSeconds;
                }
                get
                {
                    return (_secondsSinceMidnight - Hour * 3600) / 60;
                }
            }

            public int Sec
            {
                set
                {
                    _secondsSinceMidnight = (value + Min * 60 + Hour * 3600) % _maxSeconds;
                }
                get
                {
                    return _secondsSinceMidnight - Hour * 3600 - Min * 60;
                }
            }
        }
    }
}