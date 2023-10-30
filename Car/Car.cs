public class Car
{
    string _model;
    int _topspeed;
    double _engine;
    double _km;
    int _hp;
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (!(string.IsNullOrWhiteSpace(value)) && value.Length >= 10)
            {
                _model = value;
            }
            else
            {
                Console.WriteLine("boluq ve adi 10-dan az ola bilmez");
            }
        }
    }
    public int Topspeed
    {
        get
        {
            return _topspeed;
        }
        set
        {
            if (value > 10 && value <= 1000)
            {
                _topspeed = value;
            }
            else
            {
                Console.WriteLine("10 ve 1000 araligi olmalidir");
            }
        }
    }
    public double Engine
    {
        get
        {
            return _engine;
        }
        set
        {
            if (value > 0.3 && value <= 10)
            {
                _engine = value;
            }
            else
            {
                Console.WriteLine("0.3 ve 10 araligi olmalidri");
            }
        }
    }
    public double Km
    {
        get
        {
            return _km;
        }
        set
        {
            if (value >= 0)
            {
                _km = value;
            }
        }
    }
    public int Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value >= 50 && value <= 1000)
            {
                _hp = value;
            }
        }
    }
}

