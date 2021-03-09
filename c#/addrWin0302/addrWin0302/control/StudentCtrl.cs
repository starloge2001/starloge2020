﻿using addrWin0302;
using adressTest0218.util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adressTest0218.control
{
    class StudentCtrl
    {
          List<Student> addrList =
            new List<Student>();
        // Random r;
        RandData rand;

        public Point Location { get; private set; }

        public List<Student> getList()
        {
            return addrList;
        }

        public StudentCtrl()
        {
            // r = new Random();
            rand = new RandData(new Random());
        }

        public void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();
            string id=rand.getId();
            addrList.Add(new Student(id,name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("ID: " + addrList[i].Id);
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }



        

        public void delItem(string name)
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }   
        }

        public void delItemAll()
        {
            addrList.Clear();
            /*Point parentPoint = main.Location;
            string input = Microsoft.VisualBasic.Interaction.InputBox("삭제 확인", "삭", "??힌트", parentPoint.X, parentPoint.Y);
            Microsoft.VisualBasic.Interaction.*/
            MessageBox.Show("모두 삭제 하였습니다.");
        }

        public void randData(int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Student(rand.getId(), 
                    rand.getName(), 
                    rand.getTel(), 
                    rand.getAddr(), 
                    rand.getEmail()));
            }
        }

        public void updateItem()
        {

        }



    }
}
