using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class MainCR0P090
    {
        //============ start ===============
        //19th July 2022

        //10th June 2023

        public static String getCRHEADER(string pstr)
        {
            return CMON.getHEADER(pstr, Consts.P090);
        }

        public static String getCR0()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(0)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0257] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.06] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0279 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.06 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(2)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0364");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0364");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0193");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(3)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.045 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0429] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.06] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0279");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(4)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045  F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR5()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(5)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.06] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0279");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR6()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(6)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0321");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0429] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.06] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0429] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR7()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(7)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.03] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR8()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(8)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCR9()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(9)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.015");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0257] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0193");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0429] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0321");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(A)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0043] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.015");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.06] Y0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRAMP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(&)");
            sb.AppendLine("G00G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0986] Y-0.0064");
            sb.AppendLine("G01 X[V26-0.005]F[V178]");
            sb.AppendLine("G01 Z[V5+0.0986] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0943] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.09] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0857] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0814] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.03] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0857] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0943] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0986] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0986] Y0.0364");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.118 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(B)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0364");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0193");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.015");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0279");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
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
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0236");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0236");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRCOLON()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(:)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.015");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0364");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0257] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0364");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.045 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRCOMMA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(,)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0407");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0086] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0493");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0579");
            sb.AppendLine("G01 Z[V5+0.0086] Y0.0621");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.037 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRD()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(D)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.06] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.06] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRDOT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(.)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.015");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0257] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.045 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(E)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRF()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(F)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
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
            return sb.ToString();
        }

        public static String getCRG()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(G)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0236");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0107");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0107");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0107");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.11 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(H)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRHASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.0621");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.075");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0621");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.075");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0064");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0064");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0193");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.092 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRHEADER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("(DATE:  AND TIME: )");
            sb.AppendLine("(THIS IS MARKING PROGRAM)");
            sb.AppendLine("(PLEASE CONFIRM THE MARKING LOCATION BEFORE PROCEED)");
            sb.AppendLine("(MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
            sb.AppendLine("(USE SNAP GAUGE TO CHECK THE CLEARANCE)");
            sb.AppendLine("(MARKING TEXTS)");
            sb.AppendLine("(********************)");
            sb.AppendLine("M0 (LINE1)");
            sb.AppendLine("M0 (LINE2)");
            sb.AppendLine("M0 (LINE3)");
            sb.AppendLine("M0 (LINE4)");
            sb.AppendLine("M0 (LINE5)");
            sb.AppendLine("M0 (LINE6)");
            sb.AppendLine("M0 (LINE7)");
            sb.AppendLine("M0 (LINE8)");
            sb.AppendLine("(********************)");
            sb.AppendLine("G13");
            sb.AppendLine("NOEX V12 = 0.19 (FONT SIZE)");
            sb.AppendLine("NOEX V24 = -11.00 (MARKING Z START POSITION)");
            sb.AppendLine("NOEX V26 = 1.94 (MARKING X LEVEL IN RADIUS)");
            sb.AppendLine("NOEX V175 = 0.19 * 2 (FONT SIZE *2)");
            sb.AppendLine("NOEX V176 = V175/V26");
            sb.AppendLine("NOEX V177 = V176*57.325");
            sb.AppendLine("NOEX V178 = 20.0  (FEEDRATE)");
            sb.AppendLine("NOEX V163 = 0 (LINE COUNTER)");
            sb.AppendLine("NOEX V4 = 1 (CHARACTER COUNTER)");
            sb.AppendLine("NOEX V5 = V24 (MARKING Z VALUE CALCULATOR)");
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
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0064");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0943] Y0.0064");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.11 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(I)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.04 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRJ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(J)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0471] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0257] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0364");
            sb.AppendLine("G01 Z[V5+0.0086] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0086] Y0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.08 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRK()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(K)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.015");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0064");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(L)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.09 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRM()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(M)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045  F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0857] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0857] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.11 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(N)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRO()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(O)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0814] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0814] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(P)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045 F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0364");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRQ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Q)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0236");
            sb.AppendLine("G01 Z[V5+0.0814] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0814] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.0279");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0536");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(R)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0364");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0279");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.0193");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.0686] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0557] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0471] Y-0.0021");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRS()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(S)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.0321");
            sb.AppendLine("G01 X[V26+0.06] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0514] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0407");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0321");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.0236");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.015");
            sb.AppendLine("G01 Z[V5+0.0214] Y-0.0107");
            sb.AppendLine("G01 Z[V5+0.03] Y-0.0064");
            sb.AppendLine("G01 Z[V5+0.0557] Y0.0021");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0064");
            sb.AppendLine("G01 Z[V5+0.0686] Y0.0107");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.0321");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRSLASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(/)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.093 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRSPACE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" (SPACE)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.08 (NEXT CHARACTER)");
            sb.AppendLine("");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(T)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0343] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0343] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0043] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0643] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.09 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRU()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(U)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0171] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0171] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0214] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.03] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0429] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0514] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0643] Y0.0407");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.0321");
            sb.AppendLine("G01 Z[V5+0.0771] Y0.0193");
            sb.AppendLine("G01 Z[V5+0.0771] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0043] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRW()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("(W)");
            sb.AppendLine("G00 Z[V26 + 0.25]");
            sb.AppendLine("G01 X[V5 + 0.0086] Y - 0.045");
            sb.AppendLine("G01 Z[V26 - 0.005] F25.0");
            sb.AppendLine("G01 X[V5 + 0.03] Y0.045");
            sb.AppendLine("G01 X[V5 + 0.0514] Y - 0.045");
            sb.AppendLine("G01 X[V5 + 0.0729] Y0.045");
            sb.AppendLine("G01 X[V5 + 0.0943] Y - 0.045");
            sb.AppendLine("G00 Z[V26 + 0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.111(NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }
        //from 019
        public static String getCRX()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("(X)");
            sb.AppendLine("G00 Z[V26 + 0.25]");
            sb.AppendLine("G01 X[V5 + 0.0129] Y - 0.045");
            sb.AppendLine("G01 Z[V26 - 0.005] F[178]");
            sb.AppendLine("G01 X[V5 + 0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26 + 0.05]");
            sb.AppendLine("G01 X[V5 + 0.0729] Y - 0.045");
            sb.AppendLine("G01 Z[V26 - 0.005] F25.0");
            sb.AppendLine("G01 X[V5 + 0.0129] Y0.045");
            sb.AppendLine("G00 Z[V26 + 0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1(NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }


        public static String getCRY()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Y)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0043] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0021");
            sb.AppendLine("G01 Z[V5+0.0386] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G01 X[V26-0.005] F[V178]");
            sb.AppendLine("G01 Z[V5+0.0386] Y-0.0021");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        public static String getCRZ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Z)");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("G01 Z[V5+0.0129] Y-0.045  F[V178]");
            sb.AppendLine("G01 X[V26-0.005]");
            sb.AppendLine("G01 Z[V5+0.0729] Y-0.045");
            sb.AppendLine("G01 Z[V5+0.0129] Y0.045");
            sb.AppendLine("G01 Z[V5+0.0729] Y0.045");
            sb.AppendLine("G00 X[V26+0.25]");
            sb.AppendLine("NOEX V5 = V5 + 0.1 (NEXT CHARACTER)");
            return sb.ToString();
        }

        //========= END ======================
    }
}
