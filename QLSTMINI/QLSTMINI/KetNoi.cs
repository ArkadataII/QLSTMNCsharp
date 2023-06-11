using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLSTMINI
{
    class KetNoi
    {
        public static string sql,s,ktn;
        public static DataTable dt;
        public static SqlConnection connectDB()
        {
            string connString = @"Data Source=ARKADATA-1503\SQLEXPRESS;Initial Catalog=QLSTMN_C;Persist Security Info=True;User ID=sa;Password=15032002";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static DataTable getData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ktTrungMa(string tenbang, string tentruong, bool ktThem, string manhap, string macu)
        {
            string sql = "";//  "+ gt +"
            if (ktThem == true)
                sql = "Select " + tentruong + " From " + tenbang + " Where " + tentruong + " = N'" + manhap + "'";
            else
                sql = "Select " + tentruong + " From " + tenbang + " Where "
                    + tentruong + " = N'" + manhap + "' And " + tentruong + " <>N'" + macu + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public static string TuTaoMa(string tentruong, string loaima, string dinhdang)
        {
            //tự động tạo 1 mã nhân viên mới mỗi khi thêm phiếu
            sql = "Select * From " + tentruong;
            dt = KetNoi.getData(sql);
            if (dt.Rows.Count <= 0) // Kiểm tra xem trong csdl co dữ liệu chưa
            // nếu chưa có
            {
                    loaima = dinhdang + "0" + "1";
            }
            else
            {// có rồi
                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count )
                    {
                        if (i < 9)
                            loaima = dinhdang + "0" + (i + 1).ToString();
                        else
                            loaima = dinhdang + (i + 1).ToString(); ;
                    }
                    else
                    {
                        if (i < 9)
                            ktn = dinhdang + "0" + (i + 1).ToString();
                        else
                            ktn = dinhdang + (i + 1).ToString();
                        try
                        {
                            if (ktn != (dt.Rows[i][0].ToString()))
                            {
                                loaima = ktn;
                                break;
                            }
                        }
                        catch { }
                    }
                }
            }
            return loaima;
        }

        public static void ToExcel(DataGridView dg1,string filename,string s,string c)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //tạo tiêu đề
                Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("A1", c + "1");
                head.MergeCells = true;
                head.Value2 = s;
                head.Font.Bold = true;
                head.Font.Size = "18";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                head.Interior.ColorIndex = 15;

                // export header trong DataGridView
                for (int i = 0; i < dg1.ColumnCount; i++)
                {
                    worksheet.Cells[2, i + 1] = dg1.Columns[i].HeaderText;
                    worksheet.Cells[2, i + 1].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    worksheet.Cells[2, i + 1].Font.Bold = true;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dg1.RowCount; i++)
                {
                    for (int j = 0; j < dg1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = dg1.Rows[i].Cells[j].Value.ToString();
                        worksheet.Cells[i + 3, j + 1].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(filename);

                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
