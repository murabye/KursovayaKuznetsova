//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kursovayaKuznetsova
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentPrice { get; set; }
        public int Amount { get; set; }
        public int CheckId { get; set; }
    
        public virtual Check Check { get; set; }
        public virtual CheckDiscount CheckDiscount { get; set; }
    }
}
