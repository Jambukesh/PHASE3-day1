namespace ClassLibrary
{
    public class Classadd
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }

        public int Add()
        {
            int res;
            res = Fnum + Snum;
            return res;
        }
        public int Sub()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }
        public int Div()
        {
            int res;
            if (Fnum == 0 || Snum == 0)
            {
                return 0;
            }
            else
            {
                res = Fnum / Snum;
                return res;
            }
        }
    }
}
