using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.DTO
{
    class Category
    {
        public Category(int cateId, string cateName)
        {
            this.CateId = cateId;
            this.CateName = cateName;
        }

        private int cateId;

        public int CateId
        {
            get { return cateId; }
            set { cateId = value; }
        }

        private string cateName;
        public string CateName
        {
            get { return cateName; }
            set { cateName = value; }
        }

    }
}
