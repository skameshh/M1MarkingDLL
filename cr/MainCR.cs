using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class MainCR
    {
        public static String getCRHEADER(string pstr)
        {
            return CMON.getHEADER(pstr, Consts.P19);
        }

        public static String getCR0()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.8522 Y-.072");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.858 Y-.1016");
            sb.AppendLine("X8.8699 Y-.1198");
            sb.AppendLine("X8.8879 Y-.126");
            sb.AppendLine("X8.9003");
            sb.AppendLine("X8.9181 Y-.1202");
            sb.AppendLine("X8.9304 Y-.1023");
            sb.AppendLine("X8.9365 Y-.0724");
            sb.AppendLine("X8.9366 Y-.0543");
            sb.AppendLine("X8.9307 Y-.0244");
            sb.AppendLine("X8.9187 Y-.0061");
            sb.AppendLine("X8.9007 Y0");
            sb.AppendLine("X8.8887 Y.0001");
            sb.AppendLine("X8.8705 Y-.0056");
            sb.AppendLine("X8.8583 Y-.0237");
            sb.AppendLine("X8.8522 Y-.0536");
            sb.AppendLine("X8.8521 Y-.0717");
            sb.AppendLine("G00 Z4.155");       
            return sb.ToString();
        }

         

        public static String getCR1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("X9.9646 Y-.108");
            sb.AppendLine("X9.9465 Y-.126");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");

            return sb.ToString();
        }
         

        public static String getCR2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.8789 Y-.096");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("Y-.102");
            sb.AppendLine("X9.8729 Y-.1139");
            sb.AppendLine("X9.8669 Y-.1199");
            sb.AppendLine("X9.8549 Y-.126");
            sb.AppendLine("X9.8308");
            sb.AppendLine("X9.8188 Y-.1199");
            sb.AppendLine("X9.8128 Y-.1139");
            sb.AppendLine("X9.8068 Y-.102");
            sb.AppendLine("Y-.09");
            sb.AppendLine("X9.8128 Y-.0781");
            sb.AppendLine("X9.8248 Y-.06");
            sb.AppendLine("X9.8849 Y0");
            sb.AppendLine("X9.8008");
            sb.AppendLine("G00 Z4.155");

            return sb.ToString();
        }

         

        public static String getCR3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.7606 Y-.0229");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("X9.7545 Y-.0108");
            sb.AppendLine("X9.7486 Y-.0048");
            sb.AppendLine("X9.7282 Y0");
            sb.AppendLine("X9.71");
            sb.AppendLine("X9.6921 Y-.006");
            sb.AppendLine("X9.6801 Y-.018");
            sb.AppendLine("X9.674 Y-.036");
            sb.AppendLine("Y-.048");
            sb.AppendLine("X9.6801 Y-.066");
            sb.AppendLine("X9.6861 Y-.0721");
            sb.AppendLine("X9.698 Y-.0781");
            sb.AppendLine("X9.716");
            sb.AppendLine("X9.6801 Y-.126");
            sb.AppendLine("X9.7625");
            sb.AppendLine("G00 Z4.155");
          
            return sb.ToString();
        }
         

        public static String getCR4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.5622 Y-.042");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("X9.6363");
            sb.AppendLine("X9.5758 Y-.126");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");


            return sb.ToString();
        }

         

        public static String getCR5()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.5243 Y-.0241");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("X9.5183 Y-.012");
            sb.AppendLine("X9.5122 Y-.006");

            sb.AppendLine("X9.4942 Y0");
            sb.AppendLine("X9.4762");
            sb.AppendLine("X9.4581 Y-.006");
            sb.AppendLine("X9.4461 Y-.018");
            sb.AppendLine("X9.4401 Y-.036");

            sb.AppendLine("Y-.048");
            sb.AppendLine("X9.4461 Y-.066");
            sb.AppendLine("X9.4581 Y-.0781");
            sb.AppendLine("X9.4762 Y-.084");
            sb.AppendLine("X9.4942");

            sb.AppendLine("X9.5122 Y-.0781");
            sb.AppendLine("X9.5183 Y-.0721");
            sb.AppendLine("X9.5122 Y-.126");
            sb.AppendLine("X9.4521");
            sb.AppendLine("G00 Z4.155");
            return sb.ToString();
        }

 

        public static String getCR6()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.3999 Y-.0424");
            sb.AppendLine("G01 Z4.F35.");
            sb.AppendLine("X9.3998 Y-.0721");
            sb.AppendLine("X9.3938 Y-.102");
            sb.AppendLine("X9.3818 Y-.1199");
            sb.AppendLine("X9.3638 Y-.126");
            sb.AppendLine("X9.3516");
            sb.AppendLine("X9.3337 Y-.1199");
            sb.AppendLine("X9.3277 Y-.108");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C3.6");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.3938 Y-.018");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.3818 Y-.006");
            sb.AppendLine("X9.3638 Y0");
            sb.AppendLine("X9.3576");
            sb.AppendLine("X9.3396 Y-.006");
            sb.AppendLine("X9.3277 Y-.018");
            sb.AppendLine("X9.3217 Y-.036");
            sb.AppendLine("Y-.042");
            sb.AppendLine("X9.3277 Y-.06");
            sb.AppendLine("X9.3396 Y-.0721");
            sb.AppendLine("X9.3576 Y-.0781");
            sb.AppendLine("X9.3638");
            sb.AppendLine("X9.3818 Y-.0721");
            sb.AppendLine("X9.3938 Y-.06");
            sb.AppendLine("X9.3998 Y-.042");
            sb.AppendLine("X9.3941 Y-.0182");
            sb.AppendLine("G00 Z4.155");

            return sb.ToString();
        }

        public static String getCR7()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.2838 Y-.1274");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.2098");
            sb.AppendLine("X9.2703 Y-.0014");
            sb.AppendLine("G00 Z4.155");

            return sb.ToString();
        }

        public static String getCR8()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.1494 Y-.0782");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.1613 Y-.0842");
            sb.AppendLine("X9.1672 Y-.0964");
            sb.AppendLine("X9.167 Y-.1084");
            sb.AppendLine("X9.1608 Y-.1202");
            sb.AppendLine("X9.1428 Y-.126");
            sb.AppendLine("X9.1184");
            sb.AppendLine("X9.1004 Y-.1198");
            sb.AppendLine("X9.0947 Y-.1076");
            sb.AppendLine("X9.0948 Y-.0956");
            sb.AppendLine("X9.101 Y-.0837");
            sb.AppendLine("X9.1132 Y-.0779");
            sb.AppendLine("X9.1372 Y-.072");
            sb.AppendLine("X9.1554 Y-.0658");
            sb.AppendLine("X9.1673 Y-.0537");
            sb.AppendLine("X9.1732 Y-.0417");
            sb.AppendLine("X9.173 Y-.0237");
            sb.AppendLine("X9.1668 Y-.0116");
            sb.AppendLine("X9.1607 Y-.0057");
            sb.AppendLine("X9.1425 Y.0001");
            sb.AppendLine("X9.1184 Y0");
            sb.AppendLine("X9.1004 Y-.0061");
            sb.AppendLine("X9.0946 Y-.0122");
            sb.AppendLine("X9.0885 Y-.0244");
            sb.AppendLine("X9.0887 Y-.0424");
            sb.AppendLine("X9.095 Y-.0543");
            sb.AppendLine("X9.1071 Y-.0662");
            sb.AppendLine("X9.1252 Y-.0722");
            sb.AppendLine("X9.149 Y-.0781");
            sb.AppendLine("G00 Z4.155");



            return sb.ToString();
        }

        public static String getCR9()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.0455 Y-.018");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.0395 Y-.006");
            sb.AppendLine("X9.0214 Y0");
            sb.AppendLine("X9.0094");
            sb.AppendLine("X8.9914 Y-.006");
            sb.AppendLine("X8.9794 Y-.0241");
            sb.AppendLine("X8.9732 Y-.054");
            sb.AppendLine("Y-.084");
            sb.AppendLine("X8.9794 Y-.108");
            sb.AppendLine("X8.9914 Y-.1199");
            sb.AppendLine("X9.0094 Y-.126");
            sb.AppendLine("X9.0154");
            sb.AppendLine("X9.0334 Y-.1199");
            sb.AppendLine("X9.0455 Y-.108");
            sb.AppendLine("X9.0515 Y-.09");
            sb.AppendLine("Y-.084");
            sb.AppendLine("X9.0455 Y-.066");
            sb.AppendLine("X9.0334 Y-.054");
            sb.AppendLine("X9.0154 Y-.048");
            sb.AppendLine("X9.0094");
            sb.AppendLine("X8.9914 Y-.054");
            sb.AppendLine("X8.9794 Y-.066");
            sb.AppendLine("X8.9732 Y-.084");
            sb.AppendLine("G00 Z4.155");


            return sb.ToString();
        }

        public static String getCRA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.9457 Y-.126");
            sb.AppendLine("X9.8975 Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.9157 Y-.0421");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.9758");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");

            return sb.ToString();
        }

        public static String getCRB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.8508 Y-.066");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.797 Y-.0662");
            sb.AppendLine("X9.7875 Y-.0607");
            sb.AppendLine("X9.7814 Y-.0548");
            sb.AppendLine("X9.7753 Y-.0429");
            sb.AppendLine("X9.7751 Y-.0247");
            sb.AppendLine("X9.781 Y-.0127");
            sb.AppendLine("X9.7869 Y-.0066");
            sb.AppendLine("X9.7962 Y0");
            sb.AppendLine("X9.8508");
            sb.AppendLine("Y-.126");
            sb.AppendLine("X9.797 Y-.1262");
            sb.AppendLine("X9.7875 Y-.1208");
            sb.AppendLine("X9.7814 Y-.1149");
            sb.AppendLine("X9.7753 Y-.1029");
            sb.AppendLine("X9.7751 Y-.0909");
            sb.AppendLine("X9.781 Y-.0787");
            sb.AppendLine("X9.7869 Y-.0727");
            sb.AppendLine("X9.7966 Y-.0662");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            return sb.ToString();
        }

        public static String getCRC()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.6436 Y-.0961");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.6497 Y-.108");
            sb.AppendLine("X9.6617 Y-.12");
            sb.AppendLine("X9.6737 Y-.126");
            sb.AppendLine("X9.6977");
            sb.AppendLine("X9.7099 Y-.12");
            sb.AppendLine("X9.7219 Y-.108");
            sb.AppendLine("X9.7279 Y-.0961");
            sb.AppendLine("X9.7339 Y-.078");
            sb.AppendLine("Y-.048");
            sb.AppendLine("X9.7279 Y-.0299");
            sb.AppendLine("X9.7219 Y-.018");
            sb.AppendLine("X9.7099 Y-.006");
            sb.AppendLine("X9.6977 Y0");
            sb.AppendLine("X9.6737");
            sb.AppendLine("X9.6617 Y-.006");
            sb.AppendLine("X9.6497 Y-.018");
            sb.AppendLine("X9.6436 Y-.0299");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRD()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.5881 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.546");
            sb.AppendLine("X9.528 Y-.006");
            sb.AppendLine("X9.5159 Y-.018");
            sb.AppendLine("X9.5099 Y-.03");
            sb.AppendLine("X9.5038 Y-.0481");
            sb.AppendLine("Y-.078");
            sb.AppendLine("X9.5099 Y-.0961");
            sb.AppendLine("X9.5159 Y-.1081");
            sb.AppendLine("X9.528 Y-.12");
            sb.AppendLine("X9.546 Y-.126");
            sb.AppendLine("X9.5881");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.4548 Y-.066");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.4066");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.3765 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.4548");
            sb.AppendLine("Y0");
            sb.AppendLine("X9.3765");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRF()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.3318 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.126");
            sb.AppendLine("X9.2535");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.2836 Y-.066");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.3318");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRG()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.1456 Y-.0481");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X9.1152");
            sb.AppendLine("X9.1156 Y-.0296");
            sb.AppendLine("X9.1218 Y-.0176");
            sb.AppendLine("X9.1339 Y-.0057");
            sb.AppendLine("X9.146 Y.0002");
            sb.AppendLine("X9.1702 Y0");
            sb.AppendLine("X9.1821 Y-.0062");
            sb.AppendLine("X9.1941 Y-.0183");
            sb.AppendLine("X9.2 Y-.0303");
            sb.AppendLine("X9.2059 Y-.0484");
            sb.AppendLine("X9.2058 Y-.0783");
            sb.AppendLine("X9.1997 Y-.0964");
            sb.AppendLine("X9.1936 Y-.1084");
            sb.AppendLine("X9.1815 Y-.1203");
            sb.AppendLine("X9.1694 Y-.1262");
            sb.AppendLine("X9.1452 Y-.126");
            sb.AppendLine("X9.1333 Y-.1198");
            sb.AppendLine("X9.1214 Y-.1077");
            sb.AppendLine("X9.1156 Y-.096");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.0659 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X9.0659 Y-.066");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.9816");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.9816 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("	Z4.155	");
            sb.AppendLine("	X8.9204 Y0	");
            sb.AppendLine("	G01 Z4. F35.	");
            sb.AppendLine("	Y-.126	");
            sb.AppendLine("	G00 Z4.155	");
            sb.AppendLine("	G00 C0	");


            return sb.ToString();
        }

        public static String getCRJ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.8646 Y-.0421");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.03");
            sb.AppendLine("X8.8586 Y-.012");
            sb.AppendLine("X8.8526 Y-.006");
            sb.AppendLine("X8.8406 Y0");
            sb.AppendLine("X8.8286");
            sb.AppendLine("X8.8164 Y-.006");
            sb.AppendLine("X8.8104 Y-.012");
            sb.AppendLine("X8.8044 Y-.03");
            sb.AppendLine("Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRK()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.7604 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.7604 Y-.0421");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.6761 Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.6761 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.7302 Y-.072");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.6373 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y0");
            sb.AppendLine("X8.565");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRM()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.5189 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.126");
            sb.AppendLine("X8.4708 Y0");
            sb.AppendLine("X8.4228 Y-.126");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.3707 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.126");
            sb.AppendLine("X8.2864 Y.0004");
            sb.AppendLine("Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRO()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.2371 Y-.0784");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.231 Y-.0965");
            sb.AppendLine("X8.2248 Y-.1085");
            sb.AppendLine("X8.2128 Y-.1203");
            sb.AppendLine("X8.2011 Y-.126");
            sb.AppendLine("X8.1767");
            sb.AppendLine("X8.1646 Y-.1198");
            sb.AppendLine("X8.1526 Y-.1078");
            sb.AppendLine("X8.1467 Y-.0958");
            sb.AppendLine("X8.1408 Y-.0776");
            sb.AppendLine("X8.1409 Y-.0477");
            sb.AppendLine("X8.147 Y-.0296");
            sb.AppendLine("X8.1531 Y-.0176");
            sb.AppendLine("X8.1652 Y-.0057");
            sb.AppendLine("X8.1774 Y.0002");
            sb.AppendLine("X8.2015 Y0");
            sb.AppendLine("X8.2134 Y-.0062");
            sb.AppendLine("X8.2253 Y-.0183");
            sb.AppendLine("X8.2313 Y-.0303");
            sb.AppendLine("X8.2373 Y-.0484");
            sb.AppendLine("X8.2372 Y-.078");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.0946 Y-.06");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.0404");
            sb.AppendLine("X8.0224 Y-.066");
            sb.AppendLine("X8.0164 Y-.072");
            sb.AppendLine("X8.0104 Y-.084");
            sb.AppendLine("Y-.1021");
            sb.AppendLine("X8.0164 Y-.114");
            sb.AppendLine("X8.0224 Y-.12");
            sb.AppendLine("X8.0404 Y-.126");
            sb.AppendLine("X8.0946");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRQ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.9671 Y-.0779");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.9672 Y-.0483");
            sb.AppendLine("X7.9613 Y-.0302");
            sb.AppendLine("X7.9554 Y-.0181");
            sb.AppendLine("X7.9435 Y-.006");
            sb.AppendLine("X7.9314 Y.0002");
            sb.AppendLine("X7.9074 Y.0004");
            sb.AppendLine("X7.8953 Y-.0055");
            sb.AppendLine("X7.8831 Y-.0175");
            sb.AppendLine("X7.877 Y-.0294");
            sb.AppendLine("X7.8709 Y-.0476");
            sb.AppendLine("X7.8708 Y-.0776");
            sb.AppendLine("X7.8767 Y-.0957");
            sb.AppendLine("X7.8826 Y-.1078");
            sb.AppendLine("X7.8947 Y-.1198");
            sb.AppendLine("X7.9066 Y-.126");
            sb.AppendLine("X7.931");
            sb.AppendLine("X7.9429 Y-.1203");
            sb.AppendLine("X7.9549 Y-.1084");
            sb.AppendLine("X7.961 Y-.0964");
            sb.AppendLine("X7.9671 Y-.0783");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.913 Y-.0238");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.8769 Y.0122");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.8173 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.126");
            sb.AppendLine("X7.763");
            sb.AppendLine("X7.745 Y-.12");
            sb.AppendLine("X7.7391 Y-.114");
            sb.AppendLine("X7.7331 Y-.1021");
            sb.AppendLine("Y-.0901");
            sb.AppendLine("X7.7391 Y-.078");
            sb.AppendLine("X7.745 Y-.072");
            sb.AppendLine("X7.763 Y-.066");
            sb.AppendLine("X7.8173");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.7752 Y-.066");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.7331 Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRS()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.6899 Y-.018");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.6779 Y-.006");
            sb.AppendLine("X7.6599 Y0");
            sb.AppendLine("X7.6357");
            sb.AppendLine("X7.6177 Y-.006");
            sb.AppendLine("X7.6057 Y-.018");
            sb.AppendLine("Y-.0359");
            sb.AppendLine("X7.6117 Y-.0481");
            sb.AppendLine("X7.6177 Y-.054");
            sb.AppendLine("X7.6297 Y-.06");
            sb.AppendLine("X7.6659 Y-.072");
            sb.AppendLine("X7.6779 Y-.078");
            sb.AppendLine("X7.6839 Y-.084");
            sb.AppendLine("X7.6899 Y-.0961");
            sb.AppendLine("Y-.1081");
            sb.AppendLine("X7.6779 Y-.1201");
            sb.AppendLine("X7.6599 Y-.126");
            sb.AppendLine("X7.6357");
            sb.AppendLine("X7.6177 Y-.1201");
            sb.AppendLine("X7.6057 Y-.1081");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.5683 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.4842");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.5264 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRU()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.4412 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("Y-.0359");
            sb.AppendLine("X7.4352 Y-.018");
            sb.AppendLine("X7.4232 Y-.006");
            sb.AppendLine("X7.405 Y0");
            sb.AppendLine("X7.393");
            sb.AppendLine("X7.375 Y-.006");
            sb.AppendLine("X7.363 Y-.018");
            sb.AppendLine("X7.357 Y-.0359");
            sb.AppendLine("Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            return sb.ToString();
        }

        public static String getCRV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.3162 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.2682 Y.0004");
            sb.AppendLine("X7.2199 Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            return sb.ToString();
        }

        public static String getCRW()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.1807 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X7.1507 Y.0004");
            sb.AppendLine("X7.1206 Y-.126");
            sb.AppendLine("X7.0905 Y.0004");
            sb.AppendLine("X7.0605 Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRX()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.0168 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X6.9325 Y0");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X7.0168 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X6.9325 Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRY()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X6.8948 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X6.8469 Y-.0661");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");
            sb.AppendLine("Z4.155");
            sb.AppendLine("X6.8466 Y0");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X6.8469 Y-.0657");
            sb.AppendLine("X6.7985 Y-.126");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("G00 C0");


            return sb.ToString();
        }

        public static String getCRZ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X6.7664 Y-.126");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X6.6817");
            sb.AppendLine("X6.7664 Y0");
            sb.AppendLine("X6.6821");
            sb.AppendLine("G00 Z4.155");
            sb.AppendLine("Z5.0048");


            return sb.ToString();
        }
     
         

        public static String getCRCOLON()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(":");
            return sb.ToString();
        }

        public static String getCRCR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n");
            return sb.ToString();
        }

        public static String getCRCOMMA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(",");
            return sb.ToString();
        }

        public static String getCRDOT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Z4.155");
            sb.AppendLine("X8.7262 Y-.0054");
            sb.AppendLine("G01 Z4. F35.");
            sb.AppendLine("X8.72 Y0");
            sb.AppendLine("X8.715 Y-.0057");
            sb.AppendLine("X8.7206 Y-.0116");
            sb.AppendLine("X8.7259 Y-.0057");
            sb.AppendLine("G00 Z4.155");

            return sb.ToString();
        }

        public static String getCRFOOTER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("M05");
            sb.AppendLine("G69");
            sb.AppendLine("G49");
            sb.AppendLine("G00 G91 G28 X0 Y0");
            sb.AppendLine("G91 G30 P3 Z0");
            sb.AppendLine("M01");

            return sb.ToString();
        }

        public static String getCRHASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#");
            return sb.ToString();
        }

        public static String getCRHEADER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(THIS IS MARKING PROGRAM -v1.2.1)");
            sb.AppendLine("(PLEASE MOVE THE TOOL MANUALLY TO MARKING LOCATION)");
            sb.AppendLine("(MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
            sb.AppendLine("(USE SNAP GAUGE TO CHECK THE CLEARANCE)");

            return sb.ToString();
        }

        public static String getCRSLASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\\");
            return sb.ToString();
        }


        public static String getCRAMP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("&");
            return sb.ToString();
        }

        public static String getCRSPACE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ");
            return sb.ToString();
        }

        public static String getCRHYPHEN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-");
            return sb.ToString();
        }
    }//class
}
