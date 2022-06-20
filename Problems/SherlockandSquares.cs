namespace Problems;
public class SherlockandSquares
{

    public static int squares(int a, int b )
    {
        double start = a;
        double end = b;
        int count = 0;

        // Console.WriteLine(Math.Floor(Math.Sqrt(start)));
        // Console.WriteLine(Math.Floor(Math.Sqrt(end)));

        double s = Math.Floor(Math.Sqrt(start));
        double e = Math.Floor(Math.Sqrt(end));


        for (int i = Convert.ToInt32(s); i <= e; i++ )
        {
            if ( (i*i) >= start && (i*i) <= end )
            {
                count++;
            }
        }



        return count;
    }
}
