using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarManager0323.DB
{
    public class DaoOracle
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" + "User Id=c##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        /*        ~DaoOracle()
                {
                    dbClose();
                }
        */
        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                Console.WriteLine("해제에러: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table testTB (id number not null, " +
                    "name varchar(20) not null, " +
                    "age number not null, " +
                    "constraint pk_testTb_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀸스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }

        public void dropAllTB()
        {
            dropTable("cust_t", "cust_t_SEQ");
            dropTable("sell_t", "sell_t_SEQ");
            dropTable("car_t", "car_t_SEQ");
            dropTable("seller_t", "seller_t_SEQ");
        }

        private void dropTable(string tb, string tbs)
        {
            try
            {
                string query = "drop table " + tb;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence " + tbs;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀸스 삭제 성공!");

            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }

        public void makeCustomer()
        {
            try
            {
                string query = "CREATE TABLE cust_t ( cu_id INT NOT NULL, " +
                    "cu_name VARCHAR2(20) NOT NULL, " +
                    "cu_tel VARCHAR2(20) NOT NULL, " +
                    "cu_addr VARCHAR2(20) NOT NULL, " +
                    "cu_email VARCHAR2(20) NOT NULL, " +
                    "CONSTRAINT CUST_T_PK PRIMARY KEY(cu_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE cust_t_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("custermer테이블, 시퀸스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }
        public void makeSell()
        {
            try
            {
                string query = "CREATE TABLE sell_t ( sell_id INT NOT NULL," +
                    " sell_cu_id INT NOT NULL," +
                    " sell_car_id INT NOT NULL," +
                    " sell_se_id INT NOT NULL," +
                    " sell_date VARCHAR2(20) NOT NULL," +
                    " CONSTRAINT SELL_T_PK PRIMARY KEY(sell_id)," +
                    " CONSTRAINT FK_sell_t_sell_cu_id_cust_t_cu FOREIGN KEY (sell_cu_id) REFERENCES cust_t(cu_id)," +
                    "CONSTRAINT FK_sell_t_sell_car_id_car_t_ca FOREIGN KEY (sell_car_id) REFERENCES car_t(car_id)," +
                    "CONSTRAINT FK_sell_t_sell_se_id_seller_t_ FOREIGN KEY (sell_se_id) REFERENCES seller_t(se_id)" +
                    ")";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE sell_t_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("sell테이블, 시퀸스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }

        public void makeCar()
        {
            try
            {
                string query = "CREATE TABLE car_t( car_id INT NOT NULL, " +
                    "car_model VARCHAR2(20) NOT NULL, " +
                    "car_price VARCHAR2(20) NOT NULL, " +
                    "car_color VARCHAR2(20) NOT NULL, " +
                    "car_con VARCHAR2(20) NOT NULL, " +
                    "car_year VARCHAR2(20) NOT NULL, " +
                    "CONSTRAINT CAR_T_PK PRIMARY KEY(car_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_t_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("car테이블, 시퀸스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }

        public void makeSeller()
        {
            try
            {
                string query = "CREATE TABLE seller_t(se_id INT NOT NULL, " +
                    "se_name VARCHAR2(20) NOT NULL, " +
                    "se_tel VARCHAR2(20) NOT NULL, " +
                    "se_email VARCHAR2(20) NOT NULL, " +
                    "se_jikwi VARCHAR2(20) NOT NULL, " +
                    "se_office_name VARCHAR2(20) NOT NULL, " +
                    "CONSTRAINT SELLER_T_PK PRIMARY KEY(se_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE seller_t_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("seller테이블, 시퀸스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }


        public void insertCustomer(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into " +
                    "cust_t values " +
                    "(cust_t_SEQ.nextval, " +
                    "'{0}', '{1}', '{2}', '{3}')",
                    cust.Name, cust.Tel, cust.Addr, cust.Email);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            catch (OracleException e)
            {
                MessageBox.Show("에러: " + e.Message);
            }
        }
        public void insertCar(Car car)
        {
            try
            {
                string sql = string.Format("insert into car_t values " +
                    "(car_t_SEQ.nextval, " +
                    "'{0}', {1}, '{2}', '{3}', '{4}')",
                    car.Model, car.Price, car.Color, car.Company, car.Year);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("에러: " + e.Message);
            }
        }

        public void insertSeller(Seller sell)
        {
            try
            {
                string sql = string.Format("insert into seller_t " +
                    "values (seller_t_SEQ.nextval, " +
                    "'{0}', '{1}', '{2}', '{3}', '{4}')",
                    sell.Name, sell.Tel, sell.Email,
                    sell.Jikwi, sell.OfficeName);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("에러: " + e.Message);
            }
        }


        public void insertSell()
        {
            try
            {
                string query = "select sell_t_seq.nextval from dual";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string dummy = dr["nextval"].ToString();
                int seq = int.Parse(dummy);


                string sql = "insert into sell_t values(" + seq + ", " +
                    "(select cu.cu_id from cust_t cu where " + seq + " = cu.cu_id), " +
                "(select c.car_id from car_t c where " + seq + "=c.car_id), " +
                    "(select s.se_id from seller_t s where " + seq + " =s.se_id), sysdate)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }
    }
}
