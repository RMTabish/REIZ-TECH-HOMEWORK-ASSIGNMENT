using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class branch
    {
        public List<branch> branches;


        //making a construcor;
        public branch()
    {
        branches = new List<branch>();

    }
    }
    class RECURSION
    {

        static int height(branch b)
        {
            //now if tree is empty 

            int Mdepth = 0;

            if (b == null || b.branches.Count == 0)
            {
                return 0;

            }
           
                foreach(var child in b.branches)
                {
                    int d = height(child);
                    if (d > Mdepth)
                    {
                        Mdepth = d;

                    }
                }
                return Mdepth + 1;
            
        }

        static void Main()
        {

            //make a tree
            branch root = new branch();

            //making branches
            branch B1 = new branch();
            branch B2 = new branch();
            branch B3 = new branch();
          

            //now add all the branches in root
            root.branches.Add(B1);
            root.branches.Add(B2);
        B1.branches.Add(B3);
          
            int dp = height(root);

            Console.WriteLine("the depth of tree is " + dp);
            
        Console.WriteLine("PRESS ANY KEY TO END.....");
        Console.Read();

        }
    }

