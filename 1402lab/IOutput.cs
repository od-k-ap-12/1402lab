﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402lab
{
    interface IOutput
    {
        void Show();
        void Show(string info);
        string Info { get; set; }
    }
}
