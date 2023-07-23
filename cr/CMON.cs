using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class CMON
    {
        static String NL = Environment.NewLine;

        public static String getHEADER(string pstr, string charsize)
        {
            string line5 = "";
            string line6 = "";
            string line7 = "";


            // string[] ss = pstr.Split("\n");
            string[] lines = pstr.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
          

            for (int x = 0; x < lines.Length; x++)
            {
                Console.WriteLine("" + lines[x]);
            }

            double marking_location = Double.Parse(lines[3]);
            double part_dia = Double.Parse(lines[4]);

            string line0 = lines[0];
            string line1 = lines[1];
            string line2 = lines[2];
            string line3 = lines[3];
            string line4 = lines[4];
            if (lines.Length > 5)
            {
                line5 = lines[5];
            }
            if (lines.Length > 6)
            {
                line6 = lines[6];
            }

            if (lines.Length > 7)
            {
                line7 = lines[7];
            }


            StringBuilder sb = new StringBuilder();
              
            sb.AppendLine("(********************)");
            sb.AppendLine("G13");
            sb.AppendLine("( DATE: " + DateTime.Now.ToString("yyyy-MM-dd") + " AND TIME: " + DateTime.Now.ToString("HH:mm:ss") + ")");
            sb.AppendLine("(THIS IS MARKING PROGRAM)");
            sb.AppendLine("(PLEASE CONFIRM THE MARKING LOCATION BEFORE PROCEED)");
            sb.AppendLine("(MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
            sb.AppendLine("(USE SNAP GAUGE TO CHECK THE CLEARANCE)");
            sb.AppendLine("(MARKING TEXTS)");
            sb.AppendLine("(********************)");
            sb.AppendLine("M0 (" + line0 + ")");
            sb.AppendLine("M0 (" + line1 + ")");
            sb.AppendLine("M0 (" + line2 + ")");

            
            if (lines.Length > 5)
            {
                // sb.AppendLine("M0 (" + line5 + ")");
            }
            if (lines.Length > 6)
            {
                if (!line6.Contains("DLL"))
                    sb.AppendLine("M0 (" + line6 + ")");
            }
            if (lines.Length > 7)
            {
                //length
                if (!line7.Contains("DLL"))
                    sb.AppendLine("M0 (" + line7 + ")");
            }

            sb.AppendLine("");
            sb.AppendLine("(********************)");
            sb.AppendLine("NOEX V12 = " + charsize + " (FONT SIZE)");
            sb.AppendLine("NOEX V24 = " + marking_location + " (MARKING Z START POSITION)");
            sb.AppendLine("NOEX V26 = " + (part_dia / 2) + " (MARKING X LEVEL IN RADIUS)");
            //sb.AppendLine("NOEX V175 = " + charsize + " * 2(FONT SIZE * 2)");
            //sb.AppendLine("NOEX V176 = V175 / V26");
            //sb.AppendLine("NOEX V177 = V176 * 57.325");
            //No need to display
            //sb.AppendLine("NOEX V175 = " + getV175(charsize) + " (FONT SIZE * 2)");
            //sb.AppendLine("NOEX V176 = " + getV176(charsize, part_dia));
            sb.AppendLine("NOEX V177 = " + getV177(charsize, part_dia) +" (C-ROTATION)");


            sb.AppendLine("NOEX V178 = 20.0 (FEEDRATE)");
            sb.AppendLine("NOEX V163 = 0 (LINE COUNTER)");
            sb.AppendLine("NOEX V4 = 1 (CHARACTER COUNTER)");
            sb.AppendLine("NOEX V5 = V24 (MARKING Z VALUE CALCULATOR)");
            sb.AppendLine("M0");
            sb.AppendLine("G210");
            sb.AppendLine("M12");
            sb.AppendLine("M109");
            sb.AppendLine("MT = 10001");
            sb.AppendLine("M321");
            sb.AppendLine("NAT01");
            sb.AppendLine("TL = 100100 BT = 1 M602");
            sb.AppendLine("M110");
            sb.AppendLine("SB = 20 M13 M175");
            sb.AppendLine("G138");
            sb.AppendLine("G19");
            sb.AppendLine("M146");
            sb.AppendLine("G0 Z[V24]Y0.0");
            sb.AppendLine("G94");           
            sb.AppendLine("M869");
            sb.AppendLine("");
            return sb.ToString();
        }

        //charsize + " * 2
        private static double getV175(String charsize)
        {
            return Double.Parse(charsize) * 2;
        }
        //(part_dia / 2)
        private static double getV26(double part_dia)
        {
            return part_dia / 2;
        }

        private static double getV176(String charsize, double part_dia)
        {
            return ((Double.Parse(charsize) * 2)/(part_dia / 2));
        }

      

        //V176 * 57.325
        private static double getV177(String charsize, double part_dia)
        {
            double dd = (getV176(charsize, part_dia) * 57.325);
            return Math.Round(dd, 2);
        }
    }
}
