using System;
using System.Collections.Generic;
using System.Linq;


namespace bntu.vsrpp.kkirichuk.Core
{
    public class Currency
    {

        public long Cur_ID { get; set; }
        public long Cur_ParentID { get; set; }
        public string Cur_Code { get; set; }
        public string Cur_Abbreviation { get; set; }
        public string Cur_Name { get; set; }
        public string Cur_Name_Bel { get; set; }
        public string Cur_Name_Eng { get; set; }
        public string Cur_QuotName { get; set; }
        public string Cur_QuotName_Bel { get; set; }
        public string Cur_QuotName_Eng { get; set; }
        public string Cur_NameMulti { get; set; }
        public string Cur_Name_BelMulti { get; set; }
        public string Cur_Name_EngMulti { get; set; }
        public long Cur_Scale { get; set; }
        public long Cur_Periodicity { get; set; }
        public string Cur_DateStart { get; set; }
        public string Cur_DateEnd { get; set; }

        public Currency()
        {
        }

        override
        public string ToString()
        {
            return Cur_ID + " \n" + Cur_Name + " \n" + Cur_Scale;
        }
    }
}