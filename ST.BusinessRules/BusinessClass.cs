using ST.DataAccess;
using ST.Model;

namespace ST.BusinessRules
{
    public class BusinessClass
    {

        private SqlServerAccess objSqlServerAccess=new SqlServerAccess();

        public BusinessClass() { }

        public bool AddStudent(Student student) { 

            if(objSqlServerAccess.createStudent(student)>0)
            {
                return true;
            }
            return false; 
        }



    }
}