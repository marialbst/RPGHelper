﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGHelper.Data;
using RPGHelper.Models;

namespace RPGHelper.Services
{
    public class ItemService
    {
        public static  List<Item> GetAllItems()
        {
            using (var context = new RPGHelperContext())
            {
                return context.Items.ToList();
            }
        }
    }
}