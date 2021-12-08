namespace bntu.vsrpp.kkirichuk.Core
{
    public class RateShort
    {

        public long Cur_ID { get; set; }
        public string Date { get; set; }
        public double Cur_OfficialRate { get; set; }


        public RateShort()
        {
        }

        public RateShort(long Cur_ID, string Cur_Abbreviation, long Cur_Scale, string Cur_Name, double Cur_OfficialRate)
        {
         
        }


    }
}