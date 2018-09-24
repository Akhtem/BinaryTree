using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
     public class OwnComparer<T>:IComparer<T>
    {
        private Func<T, T, int> _comparison;

        public OwnComparer(Func<T,T,int>comparison)
        {
            _comparison = comparison;
        }
        public int Compare(T ob1, T ob2)
        {
            int result = _comparison(ob1,ob2);

            return result;
        }
        
    }
   
}
