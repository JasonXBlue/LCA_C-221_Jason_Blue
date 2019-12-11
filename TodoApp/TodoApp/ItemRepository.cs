using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace TodoApp
{
    class ItemRepository
    {
        public static ItemContext todoList = new ItemContext();

        public ItemRepository()
        {
            //make sure table exist and create it if not
            todoList.Database.EnsureCreated();
        }
        
        
        public static void AddItem(string item, string dueDate, bool pending)
        {
      
            ToDoItem newToDoItem = new ToDoItem(item, dueDate, pending);
            todoList.Add(newToDoItem);
            //save changes to database
            todoList.SaveChanges();
        }
        public static ToDoItem DeleteItem(int id)
        {
            ToDoItem delItem = todoList.ToDoItems.Where(item => item.ID == id).FirstOrDefault();

            if (delItem != null)
            {
                todoList.ToDoItems.Remove(delItem);
                todoList.SaveChanges();
                return delItem;
            }
            else
            {
                return null;
            }
        }

        public static List<ToDoItem> GetAllToDoItems()
        {
            IEnumerable<ToDoItem> list = todoList.ToDoItems;
            return list.ToList();
          
        }
        public static List<ToDoItem> GetToDoItems(string sort)
        {
            string SortLow = sort.ToLower();
            if (SortLow == "done")
            {
                IEnumerable<ToDoItem> list = todoList.ToDoItems.Where(item => item.Pending == false);
                return list.ToList();
            }
            else if (SortLow == "pend")
            {
                IEnumerable<ToDoItem> list = todoList.ToDoItems.Where(item => item.Pending == true);
                return list.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
