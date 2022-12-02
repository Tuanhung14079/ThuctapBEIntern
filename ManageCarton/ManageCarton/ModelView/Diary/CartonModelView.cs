﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartonManeger.ModelView.Diary
{
    public class CartonModelView
    {
        public int DiaryId { get; set; }
        public string Title { get; set; }
        public string Dcontent { get; set; }
        public string Image { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? PostDate { get; set; }
        public int AccountId { get; set; }

    }
}
