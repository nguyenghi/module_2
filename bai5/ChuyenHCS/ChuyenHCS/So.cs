using System;
using System.Collections.Generic;
using System.Text;

namespace ChuyenHCS
{
    class So
    {
        public string giatri { get; set; }
        public string hcs { get; set; }

        
        
        public  double ChuyenHCS( string giatri, string hcs)
        {
            double ketqua =0;
            switch (hcs)
            {
                case "2":
                case "8":


                    for (int i = 0; i < giatri.Length; i++)
                    {
                        string value = giatri[i].ToString().ToLower();

                        ketqua += Convert.ToDouble(value) * Math.Pow(Convert.ToDouble(hcs), giatri.Length - 1 - i);
                    }

                    return ketqua;
                    
                case "16":
                    for (int i = 0; i < giatri.Length; i++)
                    {
                        string value = giatri[i].ToString().ToLower();

                        switch (value)
                        {
                            case "a":
                                value = "10";
                                break;
                            case "b":
                                value = "11";
                                break;
                            case "c":
                                value = "12";
                                break;
                            case "d":
                                value = "13";
                                break;
                            case "e":
                                value = "14";
                                break;
                            case "f":
                                value = "15";
                                break;

                        }
                        ketqua += Convert.ToDouble(value) * Math.Pow(Convert.ToDouble(hcs), giatri.Length - 1 - i);


                    }
                   
                    return ketqua;
                    
            }

                    return ketqua;

        }


    }
}
