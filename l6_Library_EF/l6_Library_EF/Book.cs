//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace l6_Library_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public Nullable<int> Pages { get; set; }
        public Nullable<int> Price { get; set; }
        public int IdPublisher { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
