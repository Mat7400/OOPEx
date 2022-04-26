using System;

namespace CalcValut
{
    public enum valut
    { 
        RUR,
        EUR,
        USD,
        GBP,
        CHF,
        YEN
    }
    //ООП - со,ираем полезный код в ,и,леотеку и используем его в други[ места[
    public class calcValut
    {
        private double kursEvro = 80.04;
        private double kursUsd = 71.25;
        public double kalkulateKurs(int sum, valut Valut = valut.USD)
        {
            double res = 0;
            GetKursFromInternet();
            if (Valut == valut.USD)
            {
                 res = sum * kursUsd;
            }
            if (Valut == valut.EUR)
            {
                 res = sum * kursEvro;
            }

            return res;
        }

        private double GetKursFromInternet()
        {
            //not implemented
            return 0;
        }
    }
}
