using OCSMarkingDLL.cr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL
{
    public class Marking
    {
        public static String Version = "V1.2.7";
        //GC035300
        //IC035300

        private static bool is_init = false;
        public static string MAC_GC035300 = "GC035300";       
        public static string MAC_LH035300 = "LH035300";
        public static string MAC_IC035300 = "IC035300";
        public static string MAC_IC035400 = "IC035400";

        //Aug8th
        public static string MAC_IC042100 = "IC042100";//
        public static string MAC_GC042200 = "GC042200";//
        public static string MAC_GC042100 = "GC042100";//
        public static string MAC_LH046100 = "LH046100";//
        public static string MAC_LH046200 = "LH046200";//

        /*public static string Marking_size_0_25inch = "0P25inch";
        public static string Marking_size_0_19inch = "0P19inch";
        public static string Marking_size_0_125inch = "0P125inch";
        public static string Marking_size_0_090inch = "0P090inch";*/

        public static string Marking_size_0_25inch = "0P25inch";
        public static string Marking_size_0_19inch = "0P19inch";
        public static string Marking_size_0_125inch = "0P125inch";
        public static string Marking_size_0_090inch = "0P090inch";

        public static string BU_IC= "ICI";
        public static string BU_GC = "GC";
        public static string BU_LH = "LH";

        private static String NEW_LINE = "\n";
        private static string val_0 = string.Empty;
        private static string val_1 = string.Empty;
        private static string val_2 = string.Empty;
        private static string val_3 = string.Empty;
        private static string val_4 = string.Empty;
        private static string val_5 = string.Empty;
        private static string val_6 = string.Empty;
        private static string val_7 = string.Empty;
        private static string val_8 = string.Empty;
        private static string val_9 = string.Empty;
        private static string val_A = string.Empty;
        private static string val_B = string.Empty;
        private static string val_C = string.Empty;
        private static string val_D = string.Empty;
        private static string val_E = string.Empty;
        private static string val_F = string.Empty;
        private static string val_G = string.Empty;
        private static string val_H = string.Empty;
        private static string val_I = string.Empty;
        private static string val_J = string.Empty;
        private static string val_K = string.Empty;
        private static string val_L = string.Empty;
        private static string val_M = string.Empty;
        private static string val_N = string.Empty;
        private static string val_O = string.Empty;
        private static string val_P = string.Empty;
        private static string val_Q = string.Empty;
        private static string val_R = string.Empty;
        private static string val_S = string.Empty;
        private static string val_T = string.Empty;
        private static string val_U = string.Empty;
        private static string val_V = string.Empty;
        private static string val_W = string.Empty;
        private static string val_X = string.Empty;
        private static string val_Y = string.Empty;
        private static string val_Z = string.Empty;
        private static string val_C_RETURN = string.Empty;
        private static string val_COLON = string.Empty;
        private static string val_COMMA = string.Empty;
        private static string val_DOT = string.Empty;
        private static string val_FOOTER = string.Empty;
        private static string val_HASH = string.Empty;
        private static string val_HEADER = string.Empty;
        private static string val_SLASH = string.Empty;

        private static string val_Space = string.Empty;
        private static string val_Hyphen = string.Empty;
        private static string val_Ampersand = string.Empty;
       
        private static string prefix_prod_ord = "P:";
        private static string prefix_GC_prod_ord = "M ";
        private static string prefix_part_num_GC = prefix_GC_prod_ord;
        private static string prefix_part_num_IC = "M:";
        private static  string prefix_batch_num = "B:";

        private static String customs1 = "COUNTRY OF ORIGIN";
        private static String customs2 = "SINGAPORE";


        private static string PREIVIEW_STR = "";

        String req_id = string.Empty;

        private static string getReqId()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        /**
         * a.	Machine ID
            b.	Character Size
            c.	BU
            d.  prod_ord_num
            e.	Material Number
            f.	Old Material Number
            g.  dwg revision (serial num)         
            h.	custom string (optional)
            i. thread desc -1
            j. thread desc -2

           h.	Batch Number = reqmoved as per request
         */
        public static String GetMarkingInfo(String machine_id,  string char_size, string bu, string prod_ord_num, string material_num,
            string old_material_number, string serial_num,  string customs, string thread1, string thread2)
        {
            PREIVIEW_STR = "";
            String reqId = getReqId();

            //check machine
            if (!checkMachine(machine_id))
            {
                return "Unknown Machine";
            }

            if (!checkCharList(char_size))
            {
                return "Unknown Font Size";
            }


            PREIVIEW_STR = GetMarkingPreview(machine_id, char_size, bu, prod_ord_num, material_num, old_material_number, serial_num, thread1, thread2);


            //if (!is_init)
            //{
            readValFromDB("", char_size);
                is_init = true;
           // }
            /*  String eia_final_output = getProgram("<") + getProgram(NEW_LINE) + (getProgram(v_prod_order) + getProgram(NEW_LINE) + getProgram(v_old_material_num)
                + getProgram(NEW_LINE) + getProgram(v_batch_num) + getProgram(NEW_LINE) + getProgram(v_customs) + getProgram(">"));*/
            

            String res = string.Empty;

  
            //removing previx zero
            // material_num =  removePrefixZero(material_num);
            //serial_num = removePrefixZero(serial_num);
            // old_material_number = removePrefixZero(old_material_number);

            if (bu.Equals(Marking.BU_GC))
            {
                //GC
               res =  doGenerateGC( machine_id,  char_size, material_num,
             old_material_number, serial_num,  customs,  thread1,  thread2);
            }
            else if (bu.Equals(Marking.BU_LH))
            {
                res = doGenerateGC(machine_id, char_size, material_num,
            old_material_number, serial_num, customs, thread1, thread2);
            }
            else if (bu.Equals(Marking.BU_IC))
            {
                //IC
                res = doGenerateICI(machine_id, char_size, prod_ord_num, material_num,
              old_material_number, serial_num, customs, thread1, thread2);
            }
            else
            {
                res = "Unknown BU";
                
            }

            return res;
             
        }

        //total_char_len = total_chars * font_size * 0.8

        public static String GetMarkingPreview(String machine_id, string char_size, string bu, string prod_ord_num, string material_num,
           string old_material_number,   string serial_num,  string thread1, string thread2)
        {
            String reqId = getReqId();

          /*  if (PREIVIEW_STR.Length > 1)
            {
                return PREIVIEW_STR;
            }*/

            String marking_final_output = string.Empty;
            String NL = Environment.NewLine;
            int line1_len = 0;
            int line2_len = 0;
            int line3_len = 0;
            int line4_len = 0;
            int customs_len = customs1.Length;

            if (bu.Equals(Marking.BU_GC))
            {
                marking_final_output = (prefix_GC_prod_ord + material_num + NL + old_material_number + NL + serial_num );
                line1_len = (prefix_GC_prod_ord + material_num).Length;
                line2_len = old_material_number.Length;
                line3_len = serial_num.Length;

                if (thread1.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread1;
                }
                if (thread2.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread2;
                }

                marking_final_output = marking_final_output + NL + customs1 + NL + customs2;
            }
            else if (bu.Equals(Marking.BU_LH))
            {
                marking_final_output = (prefix_GC_prod_ord + material_num + NL + old_material_number + NL + serial_num   );
                line1_len = (prefix_GC_prod_ord + material_num).Length;
                line2_len = old_material_number.Length;
                line3_len = serial_num.Length;

                if (thread1.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread1;
                }
                if (thread2.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread2;
                }
                marking_final_output = marking_final_output + NL + customs1 + NL + customs2;
            }

            else if (bu.Equals(Marking.BU_IC))
            {
                marking_final_output = (prefix_prod_ord + prod_ord_num + NL + (prefix_part_num_IC+ material_num) + NL + old_material_number
                  + NL + (prefix_batch_num + serial_num ) );

                line1_len = (prefix_prod_ord + prod_ord_num).Length;
                line2_len = (prefix_part_num_IC + material_num).Length;
                line3_len = old_material_number.Length;
                line4_len = (prefix_batch_num + serial_num).Length;

                if (thread1.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread1;
                }
                if (thread2.Length > 1)
                {
                    marking_final_output = marking_final_output + NL + thread2;
                }

                marking_final_output = marking_final_output + NL + customs1 + NL + customs2;
            }
             

            //put all lenghth
            var list = new List<int> { line1_len, line2_len, line3_len, line4_len, customs_len, thread1.Length, thread2.Length };

            int max = findMax(list);
            double ch_size = 0d;

            if (char_size.Equals(Marking_size_0_25inch))
            {
                ch_size = 0.25;
            }
            else if (char_size.Equals(Marking_size_0_19inch))
            {
                ch_size = 0.19;
            }
            else if (char_size.Equals(Marking_size_0_125inch))
            {
                ch_size = 0.125;
            }
            else if (char_size.Equals(Marking_size_0_090inch))
            {
                ch_size = 0.090;
            }

            double final_size = (max * (ch_size * 0.8));
            Console.WriteLine("char_size=" + char_size + " , max=" + max + " , ch_size="+ ch_size + " , final size " + final_size.ToString("0.#"));

            marking_final_output = marking_final_output + NL + "LONGEST LINE LENGTH : "+ final_size.ToString("0.#") + " INCHES";
            marking_final_output = marking_final_output + NL + "DLL VERSION : " + Version+"("+ reqId + ")("+ ch_size+"\")";

            return marking_final_output;
        }

        private static int findMax(List<int> list)
        {
            // var list = new List<int> { 21, 2, 3, 4, 5, 6, 7, 16, 17 };
            int max = list.Max(z => z);
            Console.WriteLine("MAX=>" + list.Max(z => z));
            return max;
        }


        private static String removePrefixZero(String str)
        {
            string myStr = str.TrimStart(new Char[] { '0' });
            myStr = myStr.Length > 0 ? myStr : "0";
            return myStr;
        }


        private static ArrayList charList = null;
        private static ArrayList macList = null;

       

        private static bool checkMachine(String machine)
        {
            if (macList == null)
            {
                macList = new ArrayList();
                macList.Add(MAC_GC035300);
                macList.Add(MAC_LH035300);
                macList.Add(MAC_IC035300);
                macList.Add(MAC_IC035400);
                //Aug8th
                macList.Add(MAC_IC042100);
                macList.Add(MAC_GC042200);
                macList.Add(MAC_GC042100);
                macList.Add(MAC_LH046100);
                macList.Add(MAC_LH046200);
            }

            if (macList.Contains(machine))
            {
                return true;
            }
            return false;
        }

        private static bool checkCharList(string charsize)
        {
            if (charList == null)
            {
                charList = new ArrayList();
                charList.Add(Marking_size_0_25inch);
                charList.Add(Marking_size_0_125inch);
                charList.Add(Marking_size_0_090inch);
                charList.Add(Marking_size_0_19inch);
            }

            if (charList.Contains(charsize))
            {
                return true;
            }


            return false;
        }


        private static String doGenerateGC(String machine_id, string char_size, string partnum,
            string old_material_number, string serial_num,   string customs, string thread1, string thread2)
        {

            // String v_prod_order = prefix_GC_prod_ord + prod_ord_num;
            String v_part_order = prefix_part_num_GC + partnum;
            String v_old_material_num = old_material_number;
            String v_batch_num = serial_num;
            //string v_drw_rev = "-" + drawing_rev;
            string v_customs = "COUNTRY OF ORIGIN";
            string v_customs2 = "SINGAPORE";
            string v_thread_1 = thread1;
            string v_thread_2 = thread2;
            string final_batch = v_batch_num;// + v_drw_rev;

            String eia_final_output = getProgram("<") + getProgram(NEW_LINE) + (getProgram(v_part_order) + getProgram(NEW_LINE) + getProgram(v_old_material_num)
              + getProgram(NEW_LINE) + getProgram(final_batch) );

            if (v_thread_1.Length > 1)
            {
                eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_thread_1);
            }
            if (v_thread_2.Length > 1)
            {
                eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_thread_2);
            }

            eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_customs) + getProgram(NEW_LINE) + getProgram(v_customs2) + getProgram(">");

            return eia_final_output;
        }


        private static String doGenerateICI(String machine_id, string char_size,  string prod_ord_num, string partnum,
            string old_material_number, string serial_num,   string customs, string thread1, string thread2)
        {
           
            String v_prod_order = prefix_prod_ord + prod_ord_num;
            String v_part_order = prefix_part_num_IC + partnum;
            String v_old_material_num =  old_material_number;
            String v_batch_num = prefix_batch_num + serial_num;
           // string v_drw_rev = "-" + drawing_rev;
            string final_batch_num = v_batch_num;//+ v_drw_rev
            string v_customs = "COUNTRY OF ORIGIN";
            string v_customs2 = "SINGAPORE";
            string v_thread_1 = thread1;
            string v_thread_2 = thread2;          

            String eia_final_output = getProgram("<") + getProgram(NEW_LINE) + (getProgram(v_prod_order)
                + getProgram(NEW_LINE) + (getProgram(v_part_order))
                + getProgram(NEW_LINE) + getProgram(v_old_material_num)
                 + getProgram(NEW_LINE) + getProgram(final_batch_num));

            if (v_thread_1.Length > 1)
            {
                eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_thread_1);
            }
            if (v_thread_2.Length > 1)
            {
                eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_thread_2);
            }

            eia_final_output = eia_final_output + getProgram(NEW_LINE) + getProgram(v_customs) + getProgram(NEW_LINE) + getProgram(v_customs2) + getProgram(">");
            return eia_final_output;
        }
        /**
      * P : Production Order
         M : Part Number
         B : Batch Number  REV : Drawing Rev
         CUSTOM ORIGIN SG
         (No Thread/ 1 Thread)
         (2nd Thread )
         *When no thread last marking stops at CUSTOM ORIGIN SG
      * 
      */
        private static String getProgram(String str)
        {
            String v_program = string.Empty;
            for (int x = 0; x < str.Length; x++)
            {
                char v_char = (char)str.ElementAt(x);
                v_program = v_program + getValForChar(v_char) + "\n";
            }

            return v_program;
        }



        private static String getValForChar(char v_char)
        {
            String val = string.Empty;
            if (v_char.Equals('0'))
            {
                val = val_0;
            }
            else if (v_char.Equals('1'))
            {
                val = val_1;
            }
            else if (v_char.Equals('2'))
            {
                val = val_2;
            }
            else if (v_char.Equals('3'))
            {
                val = val_3;
            }
            else if (v_char.Equals('4'))
            {
                val = val_4;
            }
            else if (v_char.Equals('5'))
            {
                val = val_5;
            }
            else if (v_char.Equals('6'))
            {
                val = val_6;
            }
            else if (v_char.Equals('7'))
            {
                val = val_7;
            }
            else if (v_char.Equals('8'))
            {
                val = val_8;
            }
            else if (v_char.Equals('9'))
            {
                val = val_9;
            }
            else if (v_char.Equals('A'))
            {
                val = val_A;
            }
            else if (v_char.Equals('B'))
            {
                val = val_B;
            }
            else if (v_char.Equals('C'))
            {
                val = val_C;
            }
            else if (v_char.Equals('D'))
            {
                val = val_D;
            }
            else if (v_char.Equals('E'))
            {
                val = val_E;
            }
            else if (v_char.Equals('F'))
            {
                val = val_F;
            }
            else if (v_char.Equals('G'))
            {
                val = val_G;
            }
            else if (v_char.Equals('H'))
            {
                val = val_H;
            }
            else if (v_char.Equals('I'))
            {
                val = val_I;
            }
            else if (v_char.Equals('J'))
            {
                val = val_J;
            }
            else if (v_char.Equals('K'))
            {
                val = val_K;
            }
            else if (v_char.Equals('L'))
            {
                val = val_L;
            }
            else if (v_char.Equals('M'))
            {
                val = val_M;
            }
            else if (v_char.Equals('N'))
            {
                val = val_N;
            }
            else if (v_char.Equals('O'))
            {
                val = val_O;
            }
            else if (v_char.Equals('P'))
            {
                val = val_P;
            }
            else if (v_char.Equals('Q'))
            {
                val = val_Q;
            }
            else if (v_char.Equals('R'))
            {
                val = val_R;
            }
            else if (v_char.Equals('S'))
            {
                val = val_S;
            }
            else if (v_char.Equals('T'))
            {
                val = val_T;
            }
            else if (v_char.Equals('U'))
            {
                val = val_U;
            }
            else if (v_char.Equals('V'))
            {
                val = val_V;
            }
            else if (v_char.Equals('W'))
            {
                val = val_W;
            }
            else if (v_char.Equals('X'))
            {
                val = val_X;
            }
            else if (v_char.Equals('Y'))
            {
                val = val_Y;
            }
            else if (v_char.Equals('Z'))
            {
                val = val_Z;
            }
            else if (v_char.Equals('\n'))
            {
                val = val_C_RETURN;
            }
            else if (v_char.Equals(':'))
            {
                val = val_COLON;
            }
            else if (v_char.Equals(','))
            {
                val = val_COMMA;
            }
            else if (v_char.Equals('.'))
            {
                val = val_DOT;
            }
            else if (v_char.Equals('#'))
            {
                val = val_HASH;
            }
            else if (v_char.Equals('/'))
            {
                val = val_SLASH;
            }
            else if (v_char.Equals(' '))
            {
                val = val_Space;
            }
            else if (v_char.Equals('-'))
            {
                val = val_Hyphen;
            }
            else if (v_char.Equals('&'))
            {
                val = val_Ampersand;
            }
            else if (v_char.Equals('<'))
            {
                val = val_HEADER;
            }
            else if (v_char.Equals('>'))
            {
                val = val_FOOTER;
            }
            return val;
        }


        private static void readValFromDB(string machine, string size)
        {
            if (size.Equals(Marking_size_0_25inch))
            {
                val_0 = MainCR0P25.getCR0();
                val_1 = MainCR0P25.getCR1();
                val_2 = MainCR0P25.getCR2();
                val_3 = MainCR0P25.getCR3();
                val_4 = MainCR0P25.getCR4();
                val_5 = MainCR0P25.getCR5();
                val_6 = MainCR0P25.getCR6();
                val_7 = MainCR0P25.getCR7();
                val_8 = MainCR0P25.getCR8();
                val_9 = MainCR0P25.getCR9();
                //STR
                val_A = MainCR0P25.getCRA();
                val_B = MainCR0P25.getCRB();
                val_C = MainCR0P25.getCRC();
                val_D = MainCR0P25.getCRD();
                val_E = MainCR0P25.getCRE();
                val_F = MainCR0P25.getCRF();
                val_G = MainCR0P25.getCRG();
                val_H = MainCR0P25.getCRH();
                val_I = MainCR0P25.getCRI();
                val_J = MainCR0P25.getCRJ();
                val_K = MainCR0P25.getCRK();
                val_L = MainCR0P25.getCRL();
                val_M = MainCR0P25.getCRM();
                val_N = MainCR0P25.getCRN();
                val_O = MainCR0P25.getCRO();
                val_P = MainCR0P25.getCRP();
                val_Q = MainCR0P25.getCRQ();
                val_R = MainCR0P25.getCRR();
                val_S = MainCR0P25.getCRS();
                val_T = MainCR0P25.getCRT();
                val_U = MainCR0P25.getCRU();
                val_V = MainCR0P25.getCRV();
                val_W = MainCR0P25.getCRW();
                val_X = MainCR0P25.getCRX();
                val_Y = MainCR0P25.getCRY();
                val_Z = MainCR0P25.getCRZ();
                //SPECIAL
                val_C_RETURN = MainCR0P25.getCRCR();
                val_COLON = MainCR0P25.getCRCOLON();
                val_COMMA = MainCR0P25.getCRCOMMA();
                val_DOT = MainCR0P25.getCRDOT();
                val_FOOTER = MainCR0P25.getCRFOOTER();
                val_HASH = MainCR0P25.getCRHASH();
                val_HEADER = MainCR0P25.getCRHEADER(PREIVIEW_STR);
                val_SLASH = MainCR0P25.getCRSLASH();

                val_Ampersand = MainCR0P25.getCRAMP();
                val_Space = MainCR0P25.getCRSPACE();
                val_Hyphen = MainCR0P25.getCRHYPHEN();
            }else if (size.Equals(Marking_size_0_19inch))
            {
                val_0 = MainCR0P190.getCR0();
                val_1 = MainCR0P190.getCR1();
                val_2 = MainCR0P190.getCR2();
                val_3 = MainCR0P190.getCR3();
                val_4 = MainCR0P190.getCR4();
                val_5 = MainCR0P190.getCR5();
                val_6 = MainCR0P190.getCR6();
                val_7 = MainCR0P190.getCR7();
                val_8 = MainCR0P190.getCR8();
                val_9 = MainCR0P190.getCR9();
                //STR
                val_A = MainCR0P190.getCRA();
                val_B = MainCR0P190.getCRB();
                val_C = MainCR0P190.getCRC();
                val_D = MainCR0P190.getCRD();
                val_E = MainCR0P190.getCRE();
                val_F = MainCR0P190.getCRF();
                val_G = MainCR0P190.getCRG();
                val_H = MainCR0P190.getCRH();
                val_I = MainCR0P190.getCRI();
                val_J = MainCR0P190.getCRJ();
                val_K = MainCR0P190.getCRK();
                val_L = MainCR0P190.getCRL();
                val_M = MainCR0P190.getCRM();
                val_N = MainCR0P190.getCRN();
                val_O = MainCR0P190.getCRO();
                val_P = MainCR0P190.getCRP();
                val_Q = MainCR0P190.getCRQ();
                val_R = MainCR0P190.getCRR();
                val_S = MainCR0P190.getCRS();
                val_T = MainCR0P190.getCRT();
                val_U = MainCR0P190.getCRU();
                val_V = MainCR0P190.getCRV();
                val_W = MainCR0P190.getCRW();
                val_X = MainCR0P190.getCRX();
                val_Y = MainCR0P190.getCRY();
                val_Z = MainCR0P190.getCRZ();
                //SPECIAL
                val_C_RETURN = MainCR0P190.getCRCR();
                val_COLON = MainCR0P190.getCRCOLON();
                val_COMMA = MainCR0P190.getCRCOMMA();
                val_DOT = MainCR0P190.getCRDOT();
                val_FOOTER = MainCR0P190.getCRFOOTER();
                val_HASH = MainCR0P190.getCRHASH();
                val_HEADER = MainCR0P190.getCRHEADER(PREIVIEW_STR);
                val_SLASH = MainCR0P190.getCRSLASH();

                val_Ampersand = MainCR0P190.getCRAMP();
                val_Space = MainCR0P190.getCRSPACE();
                val_Hyphen = MainCR0P190.getCRHYPHEN();
            }else if (size.Equals(Marking_size_0_125inch))
            {
                val_0 = MainCR0P125.getCR0();
                val_1 = MainCR0P125.getCR1();
                val_2 = MainCR0P125.getCR2();
                val_3 = MainCR0P125.getCR3();
                val_4 = MainCR0P125.getCR4();
                val_5 = MainCR0P125.getCR5();
                val_6 = MainCR0P125.getCR6();
                val_7 = MainCR0P125.getCR7();
                val_8 = MainCR0P125.getCR8();
                val_9 = MainCR0P125.getCR9();
                //STR
                val_A = MainCR0P125.getCRA();
                val_B = MainCR0P125.getCRB();
                val_C = MainCR0P125.getCRC();
                val_D = MainCR0P125.getCRD();
                val_E = MainCR0P125.getCRE();
                val_F = MainCR0P125.getCRF();
                val_G = MainCR0P125.getCRG();
                val_H = MainCR0P125.getCRH();
                val_I = MainCR0P125.getCRI();
                val_J = MainCR0P125.getCRJ();
                val_K = MainCR0P125.getCRK();
                val_L = MainCR0P125.getCRL();
                val_M = MainCR0P125.getCRM();
                val_N = MainCR0P125.getCRN();
                val_O = MainCR0P125.getCRO();
                val_P = MainCR0P125.getCRP();
                val_Q = MainCR0P125.getCRQ();
                val_R = MainCR0P125.getCRR();
                val_S = MainCR0P125.getCRS();
                val_T = MainCR0P125.getCRT();
                val_U = MainCR0P125.getCRU();
                val_V = MainCR0P125.getCRV();
                val_W = MainCR0P125.getCRW();
                val_X = MainCR0P125.getCRX();
                val_Y = MainCR0P125.getCRY();
                val_Z = MainCR0P125.getCRZ();
                //SPECIAL
                val_C_RETURN = MainCR0P125.getCRCR();
                val_COLON = MainCR0P125.getCRCOLON();
                val_COMMA = MainCR0P125.getCRCOMMA();
                val_DOT = MainCR0P125.getCRDOT();
                val_FOOTER = MainCR0P125.getCRFOOTER();
                val_HASH = MainCR0P125.getCRHASH();
                val_HEADER = MainCR0P125.getCRHEADER(PREIVIEW_STR);
                val_SLASH = MainCR0P125.getCRSLASH();

                val_Ampersand = MainCR0P125.getCRAMP();
                val_Space = MainCR0P125.getCRSPACE();
                val_Hyphen = MainCR0P125.getCRHYPHEN();
            }else if (size.Equals(Marking_size_0_090inch))
            {
                val_0 = MainCR0P090.getCR0();
                val_1 = MainCR0P090.getCR1();
                val_2 = MainCR0P090.getCR2();
                val_3 = MainCR0P090.getCR3();
                val_4 = MainCR0P090.getCR4();
                val_5 = MainCR0P090.getCR5();
                val_6 = MainCR0P090.getCR6();
                val_7 = MainCR0P090.getCR7();
                val_8 = MainCR0P090.getCR8();
                val_9 = MainCR0P090.getCR9();
                //STR
                val_A = MainCR0P090.getCRA();
                val_B = MainCR0P090.getCRB();
                val_C = MainCR0P090.getCRC();
                val_D = MainCR0P090.getCRD();
                val_E = MainCR0P090.getCRE();
                val_F = MainCR0P090.getCRF();
                val_G = MainCR0P090.getCRG();
                val_H = MainCR0P090.getCRH();
                val_I = MainCR0P090.getCRI();
                val_J = MainCR0P090.getCRJ();
                val_K = MainCR0P090.getCRK();
                val_L = MainCR0P090.getCRL();
                val_M = MainCR0P090.getCRM();
                val_N = MainCR0P090.getCRN();
                val_O = MainCR0P090.getCRO();
                val_P = MainCR0P090.getCRP();
                val_Q = MainCR0P090.getCRQ();
                val_R = MainCR0P090.getCRR();
                val_S = MainCR0P090.getCRS();
                val_T = MainCR0P090.getCRT();
                val_U = MainCR0P090.getCRU();
                val_V = MainCR0P090.getCRV();
                val_W = MainCR0P090.getCRW();
                val_X = MainCR0P090.getCRX();
                val_Y = MainCR0P090.getCRY();
                val_Z = MainCR0P090.getCRZ();
                //SPECIAL
                val_C_RETURN = MainCR0P090.getCRCR();
                val_COLON = MainCR0P090.getCRCOLON();
                val_COMMA = MainCR0P090.getCRCOMMA();
                val_DOT = MainCR0P090.getCRDOT();
                val_FOOTER = MainCR0P090.getCRFOOTER();
                val_HASH = MainCR0P090.getCRHASH();
                val_HEADER = MainCR0P090.getCRHEADER(PREIVIEW_STR);
                val_SLASH = MainCR0P090.getCRSLASH();

                val_Ampersand = MainCR0P090.getCRAMP();
                val_Space = MainCR0P090.getCRSPACE();
                val_Hyphen = MainCR0P090.getCRHYPHEN();
            }

            

        }



    }//class
}
