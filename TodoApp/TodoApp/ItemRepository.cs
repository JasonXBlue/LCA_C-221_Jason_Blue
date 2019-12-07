using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace TodoApp
{
    public class ItemRepository
    {
        public static ItemContext ItemsList = new ItemContext();

        public static void AddItem(string description, string date, bool done, bool pending)
        {
            // create a new item object
            // add new item object
            ToDoItem newItem = new ToDoItem(description, date, done, pending);
            ItemsList.Add(newItem);
            //save changes to database
            ItemsList.SaveChanges();
        }
        public ToDoItem DeleteItem(string IdNum)
        {
            ToDoItem DeleteItem = ItemsList.
        }
        public ToDoItem MarkItemDone(string description, string date, bool done, bool pending)
        {

        }
        public ToDoItem ListDone(string description, string date, bool done, bool pending)
        {

        }
        public ToDoItem ListPending(string description, string date, bool done, bool pending)
        {

        }
        public ToDoItem ListAllItems(string description, string date, bool done, bool pending)
        {

        }
    }
}
