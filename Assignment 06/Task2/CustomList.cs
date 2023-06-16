using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CustomList
    {
        private Customer[] _customlist;

        public Customer this[int index]
        {
            get
            {
                return _customlist[index];
            }
            set
            {
                _customlist[index] = value;
            }
        }

        public int CustomerCapacity
        {
            set
            {
                _customlist = new Customer[value];
            }
        }

        public int Count
        {
            get{
                int count = 0;
                for (int i = 0; i < _customlist.Length; i++)
                {
                    if (_customlist[i] != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void AddElement(Customer customer)
        {
            for (int i = 0; i < _customlist.Length; i++)
            {
                if (_customlist[i] == null)
                {
                    _customlist[i] = customer;
                    return;
                }
            }
        }

        public void AddList(Customer[] customlist)
        {
            int j = customlist.Length - 1;
            for (int i = 0; i < _customlist.Length; i++)
            {
                if (_customlist[i] == null)
                {
                    if(j < 0)
                    {
                        break;
                    }
                    else
                    {
                        _customlist[i] = customlist[j];
                        j--;
                    }

                }
            }
        }

        public bool InsertElement(Customer customer, int index)
        {
            if(index >= 0 && Count >= index)
            {
                for(int i = 0; i < _customlist.Length; i++)
                {
                    _customlist[index] = customer;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertList(Customer[] customers, int[] index)
        {
            int count = 0;

            for(int i = 0; i < index.Length; i++)
            {
                if (index[i] >= 0 && index.Length >= index[i])
                {
                    count++;
                }
                else
                {
                    return false;
                }
            }

            if (count == index.Length)
            {
                for (int j = 0; j < customers.Length; j++)
                {
                    _customlist[index[j]] = customers[j];
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public Customer GetElement(int index)
        {
            if (index >= 0 && _customlist.Length >= index)
            {
                return _customlist[index];
            }
            else
            {
                return null;
            }
        }

        public int GetList(int[] index)
        {
            Customer[] customers = new Customer[index.Length];
            int count = 0;

            for(int i = 0; i < index.Length; i++)
            {
                if (index[i] >= 0 && index.Length >= index[i])
                {
                    customers[i] = _customlist[index[i]];
                    count++;
                }
            }
            return count;
        }

        public void RemoveElement(Customer customer)
        {
            for (int i = 0; i < _customlist.Length; i++)
            {
                if (customer == _customlist[i])
                {
                    _customlist = null;
                }
            }
            Console.WriteLine("Waishala elementi!");
        }

        public void Clear()
        {
            for(int i = 0; i < _customlist.Length; i++)
            {
                _customlist[i] = null;
            }
            Console.WriteLine("Yvela elementi waishala!");
        }

        public Customer Find(string personalId)
        {
            for(int i = 0; i < _customlist.Length; i++) 
            {
                if (_customlist[i].PersonalId == personalId)
                {
                    return _customlist[i];
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
