public class BMW : Car
{
    bool _ismpower;
    public bool İsMpower 
    {
        get
        {
            return _ismpower;
        }
        set
        {
            if (value == true)
            {
                _ismpower = true;
            }
            else 
            {
                _ismpower = false;
            }
        }
    }

    public void GetFullInfo()
    {
        Console.WriteLine($"Model : {Model} , Topspeed : {Topspeed} , {Engine} , Km : {Km} , Hp {Hp} , İsMpower : {İsMpower}");
    }
}
