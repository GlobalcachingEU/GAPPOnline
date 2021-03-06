﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAPPOnline.ViewModels
{
    public class PagedListViewModel : BaseViewModel
    {
        public List<dynamic> Items { get; set; } // object CAN (but does not have to) be a (dynamic object created from) PagedListViewModelItem
        public long CurrentPage { get; set; }
        public long PageCount { get; set; }
        public long TotalCount { get; set; }
    }
}