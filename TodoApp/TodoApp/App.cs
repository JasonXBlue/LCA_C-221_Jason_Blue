﻿using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
namespace TodoApp
{
    public class App
    {



        public App()
        {

        }

        public static void AddItemApp(string item, string dueDate, bool pending)
        {
            ItemRepository.AddItem(item, dueDate, pending);
        }
        public  List<ToDoItem> ListItems()
        {
            return ItemRepository.GetAllToDoItems();
        }
        public List<ToDoItem> ListItems(string sort)
        {
            return ItemRepository.GetToDoItems(sort);
        }
        public ToDoItem DeleteItems(int id)
        {
            return ItemRepository.DeleteItem(id);
        }

    }
}
