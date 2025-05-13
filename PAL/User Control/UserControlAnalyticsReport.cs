using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlAnalyticsReport : UserControl
    {
        OleDbConnection myConn;
        public int UserID { get; set; }
        public UserControlAnalyticsReport(int userID)
        {
            InitializeComponent();
            UserID = userID;
            EnsureDatabase();
            LoadCartesianPlot();
        }
        private void EnsureDatabase()
        {
            myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb");
        }
        private void LoadCartesianPlot()
        {
            try
            {
                myConn.Open();

                string query = @"
                   SELECT Attendance.Status, FORMAT(Attendance.AttendanceDate, 'yyyy-MM-dd') AS AttendanceDate, COUNT(Attendance.Status) AS StatusCount
                   FROM Attendance
                   WHERE Attendance.TeacherID = ?
                   GROUP BY Attendance.Status, FORMAT(Attendance.AttendanceDate, 'yyyy-MM-dd');
                   ";

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", UserID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var seriesCollection = new List<ColumnSeries<double>>();
                    var xAxisLabels = new List<string>();

                    while (reader.Read())
                    {
                        string status = reader["Status"]?.ToString() ?? "Unknown";
                        string attendanceDate = reader["AttendanceDate"]?.ToString() ?? "Unknown Date";
                        double count = reader["StatusCount"] != DBNull.Value ? Convert.ToDouble(reader["StatusCount"]) : 0;

                        xAxisLabels.Add($"{status} ({attendanceDate})");

                        seriesCollection.Add(new ColumnSeries<double>
                        {
                            Values = new[] { count },
                            Name = $"{status} ({attendanceDate})",
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue:N0}"
                        });
                    }

                    if (seriesCollection.Count > 0)
                    {
                        UpdateCartesianPlot(seriesCollection, xAxisLabels);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the current user.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cartesian plot: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
        private void UpdateCartesianPlot(List<ColumnSeries<double>> seriesCollection, List<string> xAxisLabels)
        {
            studentsData.Series = seriesCollection;
            studentsData.XAxes = new[]
            {
                         new LiveChartsCore.SkiaSharpView.Axis
                         {
                             Labels = xAxisLabels,
                             LabelsRotation = 15,
                             TextSize = 12
                         }
                     };
            studentsData.YAxes = new[]
            {
                         new LiveChartsCore.SkiaSharpView.Axis
                         {
                             Labeler = value => $"{value:N2}",
                             TextSize = 12
                         }
                     };
            studentsData.Width = 800;
            studentsData.Height = 500;
            studentsData.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            studentsData.Top = 420;
            studentsData.Left = 10;
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredCartesianPlot("daily");
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredCartesianPlot("weekly");
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredCartesianPlot("monthly");
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredCartesianPlot("yearly");
        }
        private void LoadFilteredCartesianPlot(string filterType)
        {
            try
            {
                myConn.Open();

                string dateFilter;
                string query;

                switch (filterType.ToLower())
                {
                    case "daily":
                        dateFilter = "FORMAT(Attendance.AttendanceDate, 'yyyy-MM-dd')";
                        query = $@"
                    SELECT Attendance.Status, {dateFilter} AS FilteredDate, COUNT(Attendance.Status) AS StatusCount
                    FROM Attendance
                    WHERE Attendance.TeacherID = ? AND Attendance.AttendanceDate = Date()
                    GROUP BY Attendance.Status, {dateFilter};
                ";
                        break;

                    case "weekly":
                        query = $@"
                    SELECT Attendance.Status, FORMAT(Attendance.AttendanceDate, 'yyyy-MM-dd') AS FilteredDate, COUNT(Attendance.Status) AS StatusCount
                    FROM Attendance
                    WHERE Attendance.TeacherID = ? 
                        AND Attendance.AttendanceDate >= DateAdd('d', -(Weekday(Date(), 2) - 1), Date())
                        AND Attendance.AttendanceDate <= DateAdd('d', 5 - Weekday(Date(), 2), Date())
                    GROUP BY Attendance.Status, FORMAT(Attendance.AttendanceDate, 'yyyy-MM-dd');
                ";
                        break;

                    case "monthly":
                        dateFilter = "FORMAT(Attendance.AttendanceDate, 'yyyy-MM')";
                        query = $@"
                    SELECT Attendance.Status, {dateFilter} AS FilteredDate, COUNT(Attendance.Status) AS StatusCount
                    FROM Attendance
                    WHERE Attendance.TeacherID = ? AND FORMAT(Attendance.AttendanceDate, 'yyyy-MM') = FORMAT(Date(), 'yyyy-MM')
                    GROUP BY Attendance.Status, {dateFilter};
                ";
                        break;

                    case "yearly":
                        dateFilter = "FORMAT(Attendance.AttendanceDate, 'yyyy')";
                        query = $@"
                    SELECT Attendance.Status, {dateFilter} AS FilteredDate, COUNT(Attendance.Status) AS StatusCount
                    FROM Attendance
                    WHERE Attendance.TeacherID = ? AND FORMAT(Attendance.AttendanceDate, 'yyyy') = FORMAT(Date(), 'yyyy')
                    GROUP BY Attendance.Status, {dateFilter};
                ";
                        break;

                    default:
                        throw new ArgumentException($"Invalid filter type: {filterType}");
                }

                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", UserID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    var seriesCollection = new List<ColumnSeries<double>>();
                    var xAxisLabels = new List<string>();

                    while (reader.Read())
                    {
                        string status = reader["Status"]?.ToString() ?? "Unknown";
                        string filteredDate = reader["FilteredDate"]?.ToString() ?? "Unknown Date";
                        double count = reader["StatusCount"] != DBNull.Value ? Convert.ToDouble(reader["StatusCount"]) : 0;

                        xAxisLabels.Add($"{status} ({filteredDate})");

                        seriesCollection.Add(new ColumnSeries<double>
                        {
                            Values = new[] { count },
                            Name = $"{status} ({filteredDate})",
                            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                            DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue:N0}"
                        });
                    }

                    if (seriesCollection.Count > 0)
                    {
                        UpdateCartesianPlot(seriesCollection, xAxisLabels);
                    }
                    else
                    {
                        MessageBox.Show($"No data found for the current user with {filterType} filter.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filtered cartesian plot: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
    }
}
