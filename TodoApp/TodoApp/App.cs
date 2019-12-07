using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace TodoApp
{
    public class App
    {
        public void Start()
        {
            // instantiate an instance of the context
            ItemContext context = new ItemContext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();
        }

    }
}
