using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TODO.CoreHosted.Client.Shared;

namespace TODO.CoreHosted.Server
{
    public class Data : DbContext
    {
        public Data (DbContextOptions<Data> options)
            : base(options)
        {
        }

        public DbSet<TODO.CoreHosted.Client.Shared.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
