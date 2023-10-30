public class Mercedes : Car
{
    private bool _isAmg;
    public bool IsAmg 
    {
        get
        {
            return _isAmg;
        }
        set
        {
            if (value == true)
            {
                _isAmg= true;
            }
            else
            {
                _isAmg = false;
            }
        }
    }
    public void GetFullInfo()
    {
        Console.WriteLine($"Model : {Model} , Topspeed : {Topspeed} , {Engine} , Km : {Km} , Hp {Hp} , IsAmg : {IsAmg}");
    }

}

