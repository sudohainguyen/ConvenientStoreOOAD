﻿using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class BillRepository : IBillRepository
    {
        public bool Add(Bill obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Insert(obj) != 0;
            }
        }

        public bool AddRange(IEnumerable<Bill> objs)
        {
            throw new NotImplementedException();
        }

        public int CountBill()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "select count(*) from bill";
                return con.Query<int>(query).FirstOrDefault();
            }
        }

        public IEnumerable<Bill> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bill> GetByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bill> GetByDateRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Bill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Bill GetByIdWithCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Bill obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Update(obj);
            }
        }
    }
}