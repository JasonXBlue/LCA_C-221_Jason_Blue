using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp
{
    public class ItemRepository
    {
        //public static ItemContext todolist = new ItemContext();
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
            //make sure table exist and create it if not
            context.Database.EnsureCreated();   
        }
        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.Items;
            return list.ToList();
        }
        public void AddItem(string description, string date, bool done, bool pending)
        {
            // create a new item object
            // add new item object
            ToDoItem newItem = new ToDoItem(description, date, done, pending);
            context.Items.Add(newItem);
            //save changes to database
            context.SaveChanges();
        }
        public ToDoItem DeleteItem(int id)
        {
            ToDoItem delItem = context.Items.Where(item => item.ID == id).FirstOrDefault();

            if (delItem != null)
            {
                context.Items.Remove(delItem);
                context.SaveChanges();
                return delItem;
            }
            else
            {
                return null;
            }
        }
    }
}
