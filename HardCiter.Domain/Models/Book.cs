using System;
using HardCiter.Domain.Enums;

namespace HardCiter.Domain.Models
{

    public class Book : BookBase
    {

        #region Constructors

        public Book()
        {
            PageCount = null;
        }

        #endregion

        #region Properties

        public override ItemType ItemType
        {
            get
            {
                return ItemType.Book;
            }
        }

        public int? PageCount { get; set; }

        #endregion

    }

}