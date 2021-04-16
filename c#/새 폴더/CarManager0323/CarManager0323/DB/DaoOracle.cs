using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323
{
    public class DaoOracle
    {
        public const string TB_NAME_CUSTOMER = "customer_t";
        public const string TB_NAME_CAR = "car_t";
        public const string TB_NAME_SELLER = "seller_t";
        public const string TB_NAME_DEAL = "deal_t";

        public const string SEQ_NAME_CUSTOMER = "customer_t_SEQ";
        public const string SEQ_NAME_CAR = "car_t_SEQ";
        public const string SEQ_NAME_SELLER = "seller_t_SEQ";
        public const string SEQ_NAME_DEAL = "deal_t_SEQ";

        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블 + 시퀀스 생성";
        const string DROP_TB_ERR = "테이블 + 시퀀스 삭제";
        const string ORADB = "Data Source=(DESCRIPTION" +
            "=(ADDRESS_LIST" +
            "=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=c##scott;" +
            "Password=1126;";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~DaoOracle()
        {
            Console.WriteLine("소멸자가 불렸어용..");
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                Console.WriteLine("오라클 접속 성공");
            }
            catch(OracleException e)
            {
                errorMsg(CONNECT_ERR, e);
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
                errorMsg(DISCONNECT_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + ":에러 번호" + e.Number);
            Console.WriteLine(msg + ":에러 내용" + e.Message);
        }

        public void makeAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbDeal();
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE customer_t(" +
                    "c_id       INT             NOT NULL," +
                    "c_name     VARCHAR2(20)    NOT NULL," +
                    "c_tel      VARCHAR2(20)    NOT NULL," +
                    "c_addr     VARCHAR2(20)    NOT NULL," +
                    "c_email    VARCHAR2(20)    NULL," +
                    "CONSTRAINT CUSTOMER_T_PK PRIMARY KEY (c_id))";
                // cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE customer_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCar()
        {
            try
            {
                string query = "CREATE TABLE car_t(" +
                    "car_id         INT             NOT NULL," +
                    "car_model      VARCHAR2(10)    NOT NULL," +
                    "car_price      NUMBER          NOT NULL," +
                    "car_color      VARCHAR2(20)    NOT NULL," +
                    "car_company    VARCHAR2(20)    NOT NULL," +
                    "car_year       VARCHAR2(20)    NOT NULL," +
                    "CONSTRAINT CAR_T_PK PRIMARY KEY (car_id))";
                // cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "CREATE TABLE seller_t(" +
                    "se_id       INT             NOT NULL," +
                    "se_name     VARCHAR2(10)    NOT NULL," +
                    "se_tel      VARCHAR2(20)    NOT NULL," +
                    "se_email    VARCHAR2(20)    NULL," +
                    "se_jikwi    VARCHAR2(20)    NOT NULL," +
                    "CONSTRAINT SELLER_T_PK PRIMARY KEY (se_id))";
                // cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE seller_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbDeal()
        {
            try
            {
                string query = "CREATE TABLE deal_t(" +
                    "c_id      INT     NOT NULL," +
                    "car_id    INT     NOT NULL," +
                    "se_id     INT     NOT NULL," +
                    "d_date    DATE    NOT NULL," +
                    "d_id      INT     NOT NULL," +
                    "CONSTRAINT FK_deal_t_c_id_customer_t_c_id FOREIGN KEY (c_id) " +
                    "REFERENCES customer_t (c_id)," +
                    "CONSTRAINT FK_deal_t_car_id_car_t_car_id FOREIGN KEY (car_id) " +
                    "REFERENCES car_t (car_id)," +
                    "CONSTRAINT FK_deal_t_se_id_seller_t_se_id FOREIGN KEY (se_id) " +
                    "REFERENCES seller_t (se_id)," +
                    "CONSTRAINT DEAL_T_PK PRIMARY KEY (d_id))";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE deal_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void dropAllTB()
        {
            dropTable(DaoOracle.TB_NAME_DEAL, DaoOracle.SEQ_NAME_DEAL);
            dropTable(DaoOracle.TB_NAME_CAR, DaoOracle.SEQ_NAME_CAR);
            dropTable(DaoOracle.TB_NAME_CUSTOMER, DaoOracle.SEQ_NAME_CUSTOMER);
            dropTable(DaoOracle.TB_NAME_SELLER, DaoOracle.SEQ_NAME_SELLER);
        }

        public void dropTable(string tb, string seq)
        {
            try
            {
                string query = "drop table " + tb;
                // cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence " + seq;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void insertCar()
        {
            try
            {
                string sql = "insert into car_t values(" +
                    "car_t_SEQ.nextval, '그랜저', 40000000, '은색', '현대', '2021년')";
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertSeller()
        {
            try
            {
                string sql = "insert into seller_t values(" +
                    "seller_t_SEQ.nextval, '김철수', '010-1111-1234', 'kim@hyndai.com', '대리')";
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }

        public void insertCustomer()
        {
            try
            {
                string sql = "insert into customer_t values(" +
                    "customer_t_SEQ.nextval, '김순자', '010-1133-1289', '대구 동구', 'kims5@naver.com')";
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertDeal()
        {
            try
            {
                // 시퀀스 질의로 알어오기
                string query = "select DEAL_T_SEQ.nextval from dual";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                int seq = -1;
                while (dr.Read())
                {
                    string dummy = dr["nextval"].ToString();
                    seq = int.Parse(dummy);
                }

                string sql = "insert into deal_t(c_id, car_id, se_id, d_date, d_id) " +
                    "(SELECT c_id, car_id, se_id, sysdate, " + seq + " from customer_t, car_t, seller_t " +
                    "where c_id=" + seq + " and car_id=" + seq + " and se_id=" + seq + ")";
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public Car[] getSelectAllCars()
        {
            string query = "select * from car_t order by car_id";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Car> cars = new List<Car>();

            while(dr.Read())
            {
                string car_id = dr["car_id"].ToString();
                string car_model = dr["car_model"].ToString();
                string car_price = dr["car_price"].ToString();
                string car_color = dr["car_color"].ToString();
                string car_company = dr["car_company"].ToString();
                string car_year = dr["car_year"].ToString();

                Car car = new Car(car_model, Int32.Parse(car_price), car_color, car_company, car_year);
                car.Id = Int32.Parse(car_id);
                cars.Add(car);
            }

            return cars.ToArray();
        }

        public Customer[] getSelectAllCustomers()
        {
            string query = "select * from customer_t order by c_id";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();

            while (dr.Read())
            {
                string c_id = dr["c_id"].ToString();
                string c_name = dr["c_name"].ToString();
                string c_tel = dr["c_tel"].ToString();
                string c_addr = dr["c_addr"].ToString();
                string c_email = dr["c_email"].ToString();

                Customer customer = new Customer(c_name, c_tel, c_addr, c_email);
                customer.Id = Int32.Parse(c_id);
                customers.Add(customer);
            }

            return customers.ToArray();
        }

        public Seller[] getSelectAllSellers()
        {
            string query = "select * from seller_t order by se_id";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Seller> sellers = new List<Seller>();

            while (dr.Read())
            {
                string se_id = dr["se_id"].ToString();
                string se_name = dr["se_name"].ToString();
                string se_tel = dr["se_tel"].ToString();
                string se_email = dr["se_email"].ToString();
                string se_jikwi = dr["se_jikwi"].ToString();

                Seller seller = new Seller(se_name, se_tel, se_email, se_jikwi);
                seller.Id = Int32.Parse(se_id);
                sellers.Add(seller);
            }

            return sellers.ToArray();
        }

        public Deal[] getSelectAllDeals()
        {
            string query = "select * from deal_t order by d_id";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Deal> deals = new List<Deal>();

            while (dr.Read())
            {
                int c_id = int.Parse(dr["c_id"].ToString());
                int car_id = int.Parse(dr["car_id"].ToString());
                int se_id = int.Parse(dr["se_id"].ToString());
                string d_date = dr["d_date"].ToString();
                int d_id = int.Parse(dr["d_id"].ToString());

                Customer cust = null;
                foreach (var item in getSelectAllCustomers())
                {
                    if (item.Id == c_id)
                    {
                        cust = item;
                        break;
                    }
                }
                Car car = null;
                foreach (var item in getSelectAllCars())
                {
                    if (item.Id == car_id)
                    {
                        car = item;
                        break;
                    }
                }
                Seller seller = null;
                foreach (var item in getSelectAllSellers())
                {
                    if (item.Id == se_id)
                    {
                        seller = item;
                        break;
                    }
                }

                Deal deal = new Deal(cust, car, seller);
                deal.Id = d_id;
                deal.Date = d_date;
                deals.Add(deal);
            }

            return deals.ToArray();
        }

        public bool tryInsertCar(Car car)
        {
            try
            {
                string sql = string.Format("insert into car_t values(car_t_seq.nextval," +
                    "'{0}', {1}, '{2}', '{3}', '{4}')", car.Model, car.Price, car.Color, car.Company, car.Year);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OracleException e)
            {
                errorMsg("insertCar(Car)", e);
                return false;
            }
        }

        public bool tryInsertCustomer(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into customer_t values(" +
                    "customer_t_SEQ.nextval, '{0}', '{1}', '{2}', '{3}')", cust.Name, cust.Tel, cust.Addr, cust.Email);
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer(Customer)", e);
                return false;
            }
        }

        public bool tryInsertSeller(Seller seller)
        {
            try
            {
                string sql = string.Format("insert into seller_t values(" +
                    "seller_t_SEQ.nextval, '{0}', '{1}', '{2}', '{3}')", seller.Name, seller.Tel, seller.Email, seller.Jikwi);
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller(Seller)", e);
                return false;
            }
        }

        public bool tryInsertDeal(Deal deal)
        {
            try
            {
                string sql = string.Format("insert into deal_t(c_id, car_id, se_id, d_date, d_id) " +
                    "values({0}, {1}, {2}, sysdate, DEAL_T_SEQ.nextval)", deal.Customer.Id, deal.Car.Id, deal.Seller.Id);
                // cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
                return false;
            }
        }

    }
}
