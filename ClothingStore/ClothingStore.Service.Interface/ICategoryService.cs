﻿using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Service.Interface
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public Category GetByName(string name);
    }
}
