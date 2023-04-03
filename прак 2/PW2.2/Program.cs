
int number = 0;
FindNumber Find = new FindNumber();
Find.NumberResult(number);




class FindNumber
{
    private int n = 0; 
    bool numberCheck;
    private bool SetNumber(int number)
    {
        if(  number == n+1 )
        {
            n = number;
            numberCheck = true;
            return numberCheck;
        }
        else
        {
            numberCheck = false;
            number = 1;
            n = 0;
            return numberCheck;
        }
    }
    public void NumberResult(int number)
    {
        while (number != 1)
        {
            Console.WriteLine("Введите 1 ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while(true)
        {
           this.numberCheck = SetNumber(number);
            if (numberCheck == true)
            {
                Console.WriteLine($"Введите число {n + 1}");
                number = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                NumberResult( number);

            }
        }

    }

}