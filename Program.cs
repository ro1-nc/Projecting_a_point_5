using System;

namespace Projection_Of_Point
{
    class Program
    {

        public class FootOfPerpendicular
        {
            public double[] s1 = new double[2];
            public double[] e1 = new double[2];

            public static string Foot_of_Per(double[] s1, double[] e1, double[] user_pt)
            {
                //standard form coefficinets

                double A1 = e1[1] - s1[1];
                double B1 = -(e1[0] - s1[0]);
                double C1 = -(s1[0] * e1[1] - s1[1] * e1[0]);

                //euation of line perpendicular to Ax+By+C=0 is  Bx - Ay + C2 = 0 where C2 is constant  
                double A2, B2;
                A2 = B1;
                B2 = A1;

                double C2 = -(B2 * user_pt[1] - A2 * user_pt[0]);

                //standard form coefficinets
                double x=(B1*C2-B2*C1)/(B2*A1-B1*A2);
                double y=(C1*A2-C2*A1)/(B2*A1-B1*A2);

                return "Coordinates of point of projection on line is "+x+" , "+y;
            }
        }
        static void Main(string[] args)
        {
            double[] startpt1 = new double[2] { 1, 0 };
            double[] endpt1 = new double[2] { 5, 0 };
            double[] user_pt = new double[2] { 3, 3 };

            Console.WriteLine("Enter start point of 1st line");
            for (int i = 0; i < 2; i++)
            {
                startpt1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter end point of 1st line");
            for (int i = 0; i < 2; i++)
            {
                endpt1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter point to project on above line");
            for (int i = 0; i < 2; i++)
            {
                user_pt[i] = Convert.ToDouble(Console.ReadLine());
            }
            string result = FootOfPerpendicular.Foot_of_Per(startpt1, endpt1, user_pt);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
