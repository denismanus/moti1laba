using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Queries
    {
        public static string AddPerson(string name, string rang = null)
        {
            return @"INSERT INTO LPR (LName, LRange) VALUES ('" + name + "', '" + rang + "');";
        }
        public static string AddAlternative(string name)
        {
            return  @"INSERT INTO Alternative (AName) VALUES ('" + name.ToString() + "');";
        }
        public static string AddCriterion(string name, string rang, string weight, string type,
                string optimType, string  izmer, string scaleType)
        {
            return @"INSERT INTO Criterion (Cname, CRange, CWeight, CType, OptimType, Edlzmer, ScaleType)
            VALUES ('" + name.ToString() + "','" + rang.ToString() + "','" + weight.ToString() + "'," +
            "'" + type.ToString() + "','" + optimType.ToString() + "','" + izmer.ToString() + "'" +
            ",'" + scaleType.ToString() + "' );";
        }
        public static string AddMark(string name, int criterionNumber)
        {
            return @"INSERT INTO Mark (CNum, MName) VALUES ('" + criterionNumber + "', '" + name.ToString() + "' ); "; 
        }
        public static string AddVector(int alternativeNumber, int markNumber)
        {
            return @"INSERT INTO Vector (ANum, MNum) VALUES ('" + alternativeNumber + "', '" + markNumber + "' ); ";
        }

        public static string GetCriteriaNameAndNum()
        {
            return @"SELECT CName, CNum FROM Criterion";
        }

        public static string GetMark()
        {
            return @"SELECT MNum, MName FROM Mark";
        }

        public static string GetAlternative()
        {
            return @"SELECT * FROM Alternative";
        }
        public static string GetPersons()
        {
            return @"SELECT * FROM LPR";
        }
    }
}
