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
            string line8 = "";
            string line9 = "";

            // string[] ss = pstr.Split("\n");
            string[] lines = pstr.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Console.WriteLine("Lines len = " + lines.Length);

            string line0 = lines[0];
            string line1 = lines[1];
            string line2 = lines[2];
            string line3 = lines[3];
            string line4 = lines[4];
            line5 = lines[5];
            

            if (lines.Length > 6)
            {
                string str = lines[6];
                if ((!str.Contains("DLL")) && str.Length > 0)
                    line6 = str;
            }

            if (lines.Length > 7)
            {
                string str = lines[7];
                if ((!str.Contains("DLL")) && str.Length >0)
                    line7 = str;
            }

            if (lines.Length > 8)
            {
                string str = lines[8];
                if ((!str.Contains("DLL")) && str.Length > 0)
                    line8 = str;
            }

            if (lines.Length > 9)
            {
                string str = lines[9];
                if ((!str.Contains("DLL")) && str.Length > 0)
                    line9 = str;
            }



            StringBuilder sb = new StringBuilder();

            sb.AppendLine("M0 ( DATE: " + DateTime.Now.ToString("yyyy-MM-dd") + " AND TIME: " + DateTime.Now.ToString("HH:mm:ss") + ")"); //
            sb.AppendLine("M0 (THIS IS MARKING PROGRAM)");
            sb.AppendLine("M0 (PLEASE CONFIRM THE MARKING LOCATION BEFORE PROCEED)");
            sb.AppendLine("M0 (MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
            sb.AppendLine("M0 (USE SNAP GAUGE TO CHECK THE CLEARANCE)");
            sb.AppendLine("M0 (MARKING TEXTS)");
            sb.AppendLine("(********************)");
            sb.AppendLine("M0 (" + line0 +")");
            sb.AppendLine("M0 (" + line1 + ")");
            sb.AppendLine("M0 (" + line2 + ")");
            sb.AppendLine("M0 (" + line3 + ")");
            sb.AppendLine("M0 (" + line4 + ")");
            sb.AppendLine("M0 (" + line5 + ")");

            if (lines.Length > 6)
            {
                string str = line6;
                if ((!str.Contains("DLL")) && str.Length > 0)
                    sb.AppendLine("M0 (" + line6 + ")");
            }

            if (lines.Length > 7)
            {
                string str = line7;
                if ((!str.Contains("DLL")) && str.Length > 0)
                    sb.AppendLine("M0 (" + str + ")");
            }

            if (lines.Length > 8)
            {
                string str = lines[8];
                if ((!str.Contains("DLL")) && str.Length > 0)                    
                    sb.AppendLine("M0 (" + str + ")");
            }

            if (lines.Length > 9)
            {
                string str = lines[9];
                if ((!str.Contains("DLL")) && str.Length > 0)
                    sb.AppendLine("M0 (" + str + ")");
            }

            

            sb.AppendLine("(********************)");
            // sb.AppendLine("");
            sb.AppendLine("#2 = "+ charsize + " (FONT SIZE)");
            sb.AppendLine("#24 = #5041 (MARKING X START POSITION)");
            sb.AppendLine("#26 = #555/2 (MARKING Z LEVEL IN RADIUS)");
            sb.AppendLine("#175 = "+ charsize + " * 2 (FONT SIZE *2)");
            sb.AppendLine("#176 = #175/#26");
            sb.AppendLine("#177 = #176*57.325");
            sb.AppendLine("#178 = 35.0  (FEEDRATE)" );
            sb.AppendLine("#3 = 1 		(LINE COUNTER)");
            sb.AppendLine("#4 = 1 		(CHARACTER COUNTER)");
            sb.AppendLine("#5 = #24 	(MARKING X VALUE CALCULATOR)");
            sb.AppendLine("M0 ");
            return sb.ToString();
        }




    }
}
