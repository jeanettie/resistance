using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using resistance.Models;

namespace resistance.DAL
{
    public class PostInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<postContext>
    {
    }
}