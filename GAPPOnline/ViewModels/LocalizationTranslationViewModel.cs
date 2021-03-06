﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GAPPOnline.ViewModels
{
    public class LocalizationTranslationViewModelItem: Models.Localization.LocalizationTranslation
    {
        public long CultureId { get; set; }
        public long OriginalTextId { get; set; }
        public string OriginalText { get; set; }
        public string LocalizationCultureName { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public bool CanClone { get; set; }
        public bool CanSelect { get; set; }
    }

    public class LocalizationTranslationViewModel : BaseViewModel
    {
        public List<LocalizationTranslationViewModelItem> Items { get; set; }
        public long CurrentPage { get; set; }
        public long PageCount { get; set; }
        public long TotalCount { get; set; }
    }
}