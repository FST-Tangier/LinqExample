using System;
using System.Collections.Generic;

namespace LinqExample
{
    public class Operation
    {
        public int Num { get; set; }
        public double Montant { get; set; }
        public DateTime Date { get; set; }
        public EnumType Type { get; set; }
        public int CompteId { get; set; }


        public static List<Operation> GetData()
        {
            List<Operation> list = new List<Operation>();
            list.Add(new Operation { Num = 1, Date = DateTime.Now, Montant = 1000, Type=EnumType.Credit, CompteId=1});
            list.Add(new Operation { Num = 2, Date = DateTime.Now, Montant = 200, Type = EnumType.Debit, CompteId = 1 });
            list.Add(new Operation { Num = 3, Date = DateTime.Now, Montant = 3000, Type = EnumType.Credit, CompteId = 2 });
            list.Add(new Operation { Num = 4, Date = DateTime.Now, Montant = 450, Type = EnumType.Debit, CompteId = 1 });
            list.Add(new Operation { Num = 5, Date = DateTime.Now, Montant = 6000, Type = EnumType.Credit, CompteId = 2 });
            list.Add(new Operation { Num = 6, Date = DateTime.Now, Montant = 800, Type = EnumType.Credit, CompteId = 3 });


            return list;
        }



}
}

