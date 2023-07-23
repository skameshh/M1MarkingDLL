using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class MainCR0P125
    {
        //============ start ===============
        //19th July 2022
        //10th June 2023
        public static String getCRHEADER(string pstr)
        {
            return CMON.getHEADER(pstr, Consts.P125);
        }

        public static String getCR0()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(0)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.0357] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.14 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0387  F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(2)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0506");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0506");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0268");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.14 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(3)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0595] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0387");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(4)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.142 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR5()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(5)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0387");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR6()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(6)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0446");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0595] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0595] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR7()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(7)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR8()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(8)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.141 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR9()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(9)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0208");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0357] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0268");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0595] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0446");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.142 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(A)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.006] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0208");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.141 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRAMP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(&)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1369] Y-0.0089");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1369] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.131] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.125] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.119] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.1131] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.119] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.131] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.1369] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1369] Y0.0506");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.19 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(B)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0506");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0268");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.003");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0208");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0387");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRCR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(NEXT LINE)");
            sb.AppendLine("NOEX V6 = V163 * V177");
            sb.AppendLine("C[V6]");
            sb.AppendLine("NOEX V163 = V163 + 1");
            sb.AppendLine("NOEX V5 = V24 (MARKING Z VALUE CALCULATOR)");
            return sb.ToString();
        }

        public static String getCRC()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(C)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0327");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0327");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRCOLON()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(:)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0208");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0506");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0357] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0506");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.085 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRCOMMA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(,)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0565");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0119] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0685");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0804");
            sb.AppendLine("G01 Z[V5+0.0119] Y0.0863");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.074 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRD()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(D)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0833] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0833] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRDOT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(.)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0208");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0357] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.085 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(E)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRF()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(F)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRFOOTER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(END)");
            sb.AppendLine("M868");
            sb.AppendLine("M05");
            sb.AppendLine("G210");
            sb.AppendLine("M30");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRG()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(G)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0327");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0149");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0149");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0149");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(H)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRHASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.0863");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.1042");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0863");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.1042");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0089");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0089");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0268");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.157 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRHEADER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("G13");
            sb.AppendLine("(THIS IS MARKING PROGRAM)");
            sb.AppendLine("(PLEASE CONFIRM THE MARKING LOCATION BEFORE PROCEED)");
            sb.AppendLine("(MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
            sb.AppendLine("(USE SNAP GAUGE TO CHECK THE CLEARANCE)");
            sb.AppendLine("(MARKING TEXTS)");
            sb.AppendLine("(********************)");
            sb.AppendLine("(M 12P76031-BBE)");
            sb.AppendLine("(0004786724-01)");
            sb.AppendLine("(0004786724-01)");
            sb.AppendLine("(COUNTRY OF ORIGIN MALAYSIA)");
            sb.AppendLine("(COUNTRY OF ORIGIN)");
            sb.AppendLine("(SINGAPORE)");
            sb.AppendLine("(LONGEST LINE LENGTH : 4 INCHES)");
            sb.AppendLine("(********************)");
            sb.AppendLine("NOEX V12 = 0.19 (FONT SIZE)");
            sb.AppendLine("NOEX V24 = -11.00 (MARKING Z START POSITION)");
            sb.AppendLine("NOEX V26 = 1.94 (MARKING X LEVEL IN RADIUS)");
            sb.AppendLine("NOEX V175 = 0.19 * 2 (FONT SIZE *2)");
            sb.AppendLine("NOEX V176 = V175/V26");
            sb.AppendLine("NOEX V177 = V176*57.325");
            sb.AppendLine("NOEX V178 = 20.0  (FEEDRATE)");
            sb.AppendLine("NOEX V163 = 0 (LINE COUNTER)");
            sb.AppendLine("NOEX V4 = 1 (CHARACTER COUNTER)");
            sb.AppendLine("NOEX NOEX V5 =V24 (MARKING Z VALUE CALCULATOR)");
            sb.AppendLine("M0");
            sb.AppendLine("G210");
            sb.AppendLine("M12");
            sb.AppendLine("M109");
            sb.AppendLine("MT=02901");
            sb.AppendLine("M321");
            sb.AppendLine("NAT01");
            sb.AppendLine("TL=100100 BT=1 M602");
            sb.AppendLine("M110");
            sb.AppendLine("SB=50 M13 M175");
            sb.AppendLine("G138");
            sb.AppendLine("G19");
            sb.AppendLine("M146");
            sb.AppendLine("G0 Z[V24]Y0.0 ");
            sb.AppendLine("G94");
            sb.AppendLine("M869");
            return sb.ToString();
        }

        public static String getCRHYPHEN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(-)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0089");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.131] Y0.0089");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.161 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(I)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.06 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRJ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(J)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0655] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0357] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0506");
            sb.AppendLine("G01 Z[V5+0.0119] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0119] Y0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.141 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRK()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(K)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0208");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0089");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(L)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRM()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(M)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625  F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.119] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.119] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(N)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRO()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(O)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.1131] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1131] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(P)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0506");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRQ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Q)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0327");
            sb.AppendLine("G01 Z[V5+0.1131] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1131] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0387");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0744");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(R)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0506");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0387");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0268");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0952] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0774] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0655] Y-0.003");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRS()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(S)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0446");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0565");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0446");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0327");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0208");
            sb.AppendLine("G01 Z[V5+0.0298] Y-0.0149");
            sb.AppendLine("G01 Z[V5+0.0417] Y-0.0089");
            sb.AppendLine("G01 Z[V5+0.0774] Y0.003");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0089");
            sb.AppendLine("G01 Z[V5+0.0952] Y0.0149");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0446");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRSLASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(/)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.151 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRSPACE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(SPACE)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.18 (NEXT CHARACTER)");
            sb.AppendLine("");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(T)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0476] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0476] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.006] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0893] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.142 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRU()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(U)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0238] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0238] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.0298] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.0595] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0714] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0893] Y0.0565");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0446");
            sb.AppendLine("G01 Z[V5+0.1071] Y0.0268");
            sb.AppendLine("G01 Z[V5+0.1071] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.006] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRW()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(W)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0119] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0417] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.0714] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.131] Y-0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRX()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(X)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRY()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Y)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.006] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.003");
            sb.AppendLine("G01 Z[V5+0.0536] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0536] Y-0.003");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.144 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRZ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Z)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0179] Y-0.0625");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.1012] Y-0.0625");
            sb.AppendLine("G01 Z[V5+0.0179] Y0.0625");
            sb.AppendLine("G01 Z[V5+0.1012] Y0.0625");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 =V5 + 0.14 (NEXT CHARACTER)");
            return sb.ToString();
        }


        //========= END ======================
    }
}
