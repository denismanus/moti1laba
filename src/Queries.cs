using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Queries
    {
        private static DatabaseController db = new DatabaseController();

        private static void Execute(SqlCommand command)
        {
            db.Perform(command);
        }

        public static void AddPerson(string name, string rang = null)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LPR " +
                "(LName, LRange) " +
                "VALUES " +
                "(@LName, @LRange);");
            var parameters = command.Parameters;
            parameters.AddWithValue("@LName", name);
            parameters.AddWithValue("@LRange", int.Parse(rang));
            Execute(command);
        }

        public static void AddAlternative(string name)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Alternative " +
                "(AName) " +
                "VALUES " +
                "('@AName');");
            var parameters = command.Parameters;
            parameters.AddWithValue("@AName", name);
            Execute(command);
        }

        public static void AddCriterion(string name, string range, string weight,
            string type, string optimType, string  izmer, string scaleType)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Criterion" +
                " (" +
                "Cname, CRange, CWeight, CType, OptimType, Edlzmer, ScaleType) " +
                "VALUES (" +
                "'@CName', '@CRange', '@CWeight', '@CType', '@OptimType', '@Edlzmer', '@ScaleType'" +
                ");");

            var parameters = command.Parameters;
            parameters.AddWithValue("@CName"    , name);
            parameters.AddWithValue("@CRange"   , range);
            parameters.AddWithValue("@CWeight"  , weight);
            parameters.AddWithValue("@CType"    , type);
            parameters.AddWithValue("@OptimType", optimType);
            parameters.AddWithValue("@Edlzmer"  , izmer);
            parameters.AddWithValue("@ScaleType", scaleType);
            Execute(command);
        }
        public static void AddMark(string name, int criterionNumber)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Mark " +
                "(CNum, MName) " +
                "VALUES " +
                "('@CNum', '@MName');");
            var parameters = command.Parameters;
            parameters.AddWithValue("@CNum", criterionNumber);
            parameters.AddWithValue("@MName", name);
            Execute(command);
        }
        public static void AddVector(int alternativeNumber, int markNumber)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Vector " +
                "(ANum, MNum) " +
                "VALUES " +
                "('@ANum', '@MNum');");
            var parameters = command.Parameters;
            parameters.AddWithValue("@ANum", alternativeNumber);
            parameters.AddWithValue("@MNum", markNumber);
            Execute(command);
        }

        public static SqlCommand GetCriteriaNameAndNum()
        {
            return new SqlCommand("SELECT CName, CNum FROM Criterion");
        }

        public static SqlCommand GetMark()
        {
            return new SqlCommand("SELECT MNum, MName FROM Mark");
        }

        public static SqlCommand GetAlternative()
        {
            return new SqlCommand("SELECT * FROM Alternative");
        }
        public static void GetPersons(DataSet ds)
        {
           SqlCommand command = new SqlCommand("SELECT * FROM LPR");
           db.Perform(command, ds);
        }
    }
}
