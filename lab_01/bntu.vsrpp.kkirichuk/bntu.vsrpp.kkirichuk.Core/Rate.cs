using System;

namespace bntu.vsrpp.kkirichuk.Core
{
    public class Rate
    {

        public long Cur_ID { get; set; }
        public string Date { get; set; }
        public string Cur_Abbreviation { get; set; }
        public long Cur_Scale { get; set; }
        public string Cur_Name { get; set; }
        public decimal Cur_OfficialRate { get; set; }

        public string Cur_DateEnd { get; set; }

        public Rate()
        {
        }

        public Rate(long Cur_ID, string Cur_Abbreviation, long Cur_Scale, string Cur_Name, decimal Cur_OfficialRate)
        {
            this.Cur_ID = Cur_ID;
            DateTime now = DateTime.Now;
            this.Date = now.ToString("t: {0:t}");
            this.Cur_Abbreviation = Cur_Abbreviation;
            this.Cur_Scale = Cur_Scale;
            this.Cur_Name = Cur_Name;
            this.Cur_OfficialRate = Cur_OfficialRate;
        }

        override
        public string ToString()
        {
            return Cur_Name;
        }
    }
}