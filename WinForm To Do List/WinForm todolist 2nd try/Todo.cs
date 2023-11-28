using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_todolist_2nd_try
{
    class Todo
    {
        string title;
        int category;

        public string Title { get => title; set => title = value; }
        public int Category { get => category; set => category = value; }
    }
}
