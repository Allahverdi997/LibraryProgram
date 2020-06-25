//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace LibraryWinFormsUI
//{
//    class Class1
//    {
//        public void Alma()
//        {
//            string control = "";
//            string controlname = "";

//            PropertyInfo[] props = typeof(Kitablar).GetProperties();

//            foreach (PropertyInfo pi in props)
//            {
//                foreach (Control con in groupBox2.Controls)
//                {
//                    control = con.Name;
//                    if (con is ComboBox || con is TextBox || con is NumericUpDown)
//                    {
//                        if (con.Name.Contains("TedarikciID"))
//                        {
//                            controlname = control.Remove(0, 9);
//                            if (pi.Name == controlname && con.Text != "")
//                            {
//                                pi.SetValue(k, con.Text);
//                            }
//                        }
//                        else
//                        {
//                            controlname = control.Remove(0, 3);
//                            if (pi.Name == controlname)
//                            {
//                                string tip = pi.PropertyType.Name;
//                                switch (tip)
//                                {
//                                    case "String": pi.SetValue(k, con.Text);
//                                        break;
//                                    case "Int32": pi.SetValue(k, Convert.ToInt32(con.Text));
//                                        break;
//                                    case "Decimal": pi.SetValue(k, Convert.ToDecimal(con.Text));
//                                        break;
//                                    case "Short": pi.SetValue(k, Convert.ToInt16(con.Text));
//                                        break;
//                                    case "Double": pi.SetValue(k, Convert.ToDouble(con.Text));
//                                        break;
//                                    case "DateTime": pi.SetValue(k, Convert.ToDateTime(con.Text));
//                                        break;
//                                }

//                            }
//                        }
//                    }
//                }

//            }
//        }
//    }
//}
