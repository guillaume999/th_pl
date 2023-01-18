using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class BaseModel : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
