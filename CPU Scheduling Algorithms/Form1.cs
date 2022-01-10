using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling_Algorithms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtConsole);
            Console.SetOut(writer);
            GanttChartPanel.Invalidate();
            GanttChartPanel.Controls.Clear();
            label2.Hide();
            //RRPanel.Visible = false;
            CountTime.Hide();
            txtConsole.Clear();
            txtConsole.Refresh();
        }
        //=============================================================================================================================
        //Struct
        public struct RGB
        {
            public int x, y, z;
        }
        public struct Process
        {
            public string id;
            public int arrival_time, burst_time, turnaround_time, exit_time, waiting_time, service_time, priority, remaining_time, i;
        }
        class ProcessInList
        {
            public Process Value { get; set; }
        }
        //=============================================================================================================================
        //Controller
        private void GanttChartPanel_Scroll(object sender, ScrollEventArgs e)
        {
            GanttChartPanel.Update();
        }
        private void FCFS_menu_Click(object sender, EventArgs e)
        {
            Algorithm.Text = "FCFS";
            if (dataGridView1.Columns["Priority"] != null)
            {
                dataGridView1.Columns.Remove("Priority");
            }
            RRPanel.Visible = false;
            panel1.Enabled = false;
            MainForm_Load(sender, e);
        }

        private void SJF_menu_Click(object sender, EventArgs e)
        {
            Algorithm.Text = "SJF";
            if (dataGridView1.Columns["Priority"] != null)
            {
                dataGridView1.Columns.Remove("Priority");
            }
            RRPanel.Visible = false;
            panel1.Enabled = true;
            MainForm_Load(sender, e);
        }

        private void Priority_menu_Click(object sender, EventArgs e)
        {
            Algorithm.Text = "Priority";
            if (dataGridView1.Columns["Priority"] == null)
            {
                dataGridView1.Columns.Add("Priority", "Độ ưu tiên");
            }
            RRPanel.Visible = false;
            panel1.Enabled = true;
            MainForm_Load(sender, e);
        }

        private void RR_menu_Click(object sender, EventArgs e)
        {
            Algorithm.Text = "Round Robin";
            if (dataGridView1.Columns["Priority"] != null)
            {
                dataGridView1.Columns.Remove("Priority");
            }
            RRPanel.Show();
            panel1.Enabled = false;
            MainForm_Load(sender, e);
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            Process[] process = new Process[100];
            int i = 0;
            int flag = 0;

            //Refresh 
            this.Refresh();
            txtConsole.Clear();
            txtConsole.Refresh();
            GanttChartPanel.Controls.Clear();

            //Check type of Algorithm
            if (dataGridView1.RowCount <= 1)
            {
                //MessageBox.Show("Vui lòng nhập dữ liệu trước khi chạy!!!!");
                MessageBox.Show("Vui lòng nhập dữ liệu trước khi chạy!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            if (Algorithm.Text == "SJF")
            {
                if (NonPreemptiveBtn.Checked == true)
                {
                    flag = 0;
                    Console.Write("SJF độc quyền");
                }
                else
                {
                    flag = 1;
                    Console.Write("SJF không độc quyền");
                }
            }
            if (Algorithm.Text == "FCFS")
            {
                flag = 2;
                Console.Write("FCFS");
                txtConsole.AppendText(Environment.NewLine);//<=== FIX ERROR: STACK OVERFLOW OF Console.Write();  
            }
            if (Algorithm.Text == "Priority")
            {
                if (NonPreemptiveBtn.Checked == true)
                {
                    flag = 3;
                    Console.Write("Priority độc quyền");
                }
                else
                {
                    flag = 4;
                    Console.Write("Priority không độc quyền");
                }
            }
            if (Algorithm.Text == "Round Robin")
            {
                flag = 5;
                if (qInput.Value <= 0)
                {
                    MessageBox.Show("Quantum phải lớn hơn 0!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                    return;
                }
                Console.Write("RR");
            }

            //Take data from GridView
            if (Algorithm.Text == "Priority")
            {
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Rows[row].Cells.Count; col++)
                    {
                        if (col == 0)
                        {
                            process[i].id = dataGridView1.Rows[row].Cells[col].Value.ToString();
                        }
                        if (col == 1)
                        {
                            process[i].arrival_time = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        }
                        if (col == 2)
                        {
                            process[i].burst_time = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        }
                        if (dataGridView1.Rows[row].Cells[col].Value != null)
                        {
                            if (col == 3)
                            {
                                process[i++].priority = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                            return;
                        }
                    }
                }
            }
            else
            {
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Rows[row].Cells.Count; col++)
                    {
                        if (col == 0)
                        {
                            process[i].id = dataGridView1.Rows[row].Cells[col].Value.ToString();
                        }
                        if (col == 1)
                        {
                            process[i].arrival_time = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        }
                        if (col == 2)
                        {
                            process[i++].burst_time = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        }
                    }
                }
            }


            //Run function
            GanttChart(process, dataGridView1.Rows.Count, flag);
        }
        private void GanttChart(Process[] a, int n, int choose)
        {
            Graphics g = GanttChartPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Font f = new Font("Microsoft Sans Serif", 10);

            CountTime.Text = "" + 0;
            label2.Show();
            CountTime.Show();
            CountTime.Refresh();
            label2.Refresh();

            switch (choose)
            {
                case 0://SJF
                    SJF(a, n);
                    break;
                case 1://SRTF
                    SRTF(a, n);
                    break;
                case 2://FCFS
                    FCFS(a, n);
                    break;
                case 3://Piority Non-Preemptive
                    Priority_NonPreemptive(a, n);
                    break;
                case 4://Piority Preemptive
                    Priority_Preemptive(a, n);
                    break;
                case 5://RR
                    RoundRobin(a, n);
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
            GanttChartPanel.Controls.Clear();
            GanttChartPanel.Refresh();
            txtConsole.Clear();
            txtConsole.Refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[1].ReadOnly = false;
            if (Algorithm.Text == "Priority")
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count, new object[] { "P" + (dataGridView1.Rows.Count + 1), dataGridView1.Rows.Count, dataGridView1.Rows.Count + 1, dataGridView1.Rows.Count + 1 });
            }
            else
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count, new object[] { "P" + (dataGridView1.Rows.Count + 1), dataGridView1.Rows.Count, dataGridView1.Rows.Count + 1 });

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            GanttChartPanel.Refresh();
            dataGridView1.AllowUserToAddRows = false;
            if (dataGridView1.Rows.Count != 2 && dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
            else
            {
                return;
            }
        }
        private void NonPreemptiveBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        //=============================================================================================================================
        //===============================================[ F U N C T I O N S ]=========================================================
        /*
            
                                                            - A u t h o r -
                                                         __   __  _  _     ___   
                                                         \ \ / / | \| |   |   \  
                                                          \ V /  | .` |   | |) | 
                                                          _\_/_  |_|\_|   |___/  
                                                        _| """"|_|"""""|_|"""""| 
                                                        "`-0-0-'"`-0-0-'"`-0-0-' 

        
        */
        //=============================================================================================================================
        //SJF độc quyền
        public static void swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
        public static void arrangeArrival(Process[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].arrival_time > a[j].arrival_time)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public static void completionTime(Process[] a, int n)
        {
            int temp, min_idx = -1;
            //Calculate first process
            a[0].exit_time = a[0].arrival_time + a[0].burst_time;
            a[0].turnaround_time = a[0].exit_time - a[0].arrival_time;
            a[0].waiting_time = a[0].turnaround_time - a[0].burst_time;
            //Calculate all process left
            for (int i = 1; i < n; i++)
            {
                temp = a[i - 1].exit_time;
                int low = a[i].burst_time;
                //Find min
                for (int j = i; j < n; j++)
                {
                    if (temp >= a[j].arrival_time && low >= a[j].burst_time)
                    {
                        low = a[j].burst_time;
                        min_idx = j;
                    }
                }
                //Calculate min process
                a[min_idx].exit_time = temp + a[min_idx].burst_time;
                a[min_idx].turnaround_time = a[min_idx].exit_time - a[min_idx].arrival_time;
                a[min_idx].waiting_time = a[min_idx].turnaround_time - a[min_idx].burst_time;
                //Swap
                swap(ref a[min_idx], ref a[i]);
            }
        }
        public static double averageWaitingTime(Process[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].waiting_time;
            }
            return sum / n;
        }
        public static void sortPID(Process[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int compare = String.Compare(a[i].id, a[j].id);
                    if (compare > 0)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public static double sumOfTime(Process[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].burst_time;
            }
            return sum;
        }
        public void SJF(Process[] a, int n)
        {
            Random rand = new Random();
            RGB[] colorProcess = new RGB[100];
            int xx, yy, zz, i;
            arrangeArrival(a, n);
            completionTime(a, n);

            for (i = 0; i < n; i++)
            {
                //Random color 
                xx = rand.Next(50, 255);
                yy = rand.Next(50, 255);
                zz = rand.Next(50, 255);

                colorProcess[i].x = xx;
                colorProcess[i].y = yy;
                colorProcess[i].z = zz;
            }

            for (i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].exit_time - a[i].arrival_time;
                a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
            }
            int count = 0, remain = 0;
            Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
            for (i = 0; i < n; i++)
            {

                TextBox txb1 = new TextBox();
                if (a[i].burst_time == 1)
                {
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(19, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                }
                else
                {
                    remain = a[i].burst_time;
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(20, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                    remain--;
                }
                while (remain != 0)
                {
                    if (remain == 1)
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(19, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    else
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(20, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    //Count time                
                    CountTime.Text = "" + count;
                    CountTime.Refresh();
                }
                //Count time                
                CountTime.Text = "" + count;
                CountTime.Refresh();
            }

            sortPID(a, n);
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time); ;
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));

        }
        //====================================================
        //SJF không độc quyền 
        public void SRTF(Process[] a, int n)
        {
            Random rand = new Random();
            int[] processGantt = new int[100];
            RGB[] colorStandar = new RGB[100];
            RGB[] colorProcess = new RGB[100];
            int xx, yy, zz;

            int[] x = new int[100];
            int i, smallest, count = 0, time, end;
            double avg = 0, tt = 0;

            //Define color of Process
            for (i = 0; i < n; i++)
            {
                //Random color
                xx = rand.Next(70, 255);
                yy = rand.Next(70, 255);
                zz = rand.Next(50, 255);
                //Red - Green - Black
                colorStandar[i].x = xx;
                colorStandar[i].y = yy;
                colorStandar[i].z = zz;
            }

            for (i = 0; i < n; i++)
                x[i] = a[i].burst_time;
            //---------------------------
            //Calulating..
            x[9] = 9999; //Declare Max
            for (time = 0; count != n; time++)
            {
                smallest = 9;
                for (i = 0; i < n; i++)
                {
                    if (a[i].arrival_time <= time && x[i] < x[smallest] && x[i] > 0)
                    {
                        processGantt[time] = i;
                        colorProcess[time] = colorStandar[i];
                        smallest = i;
                    }

                }
                x[smallest]--;
                if (x[smallest] == 0)
                {
                    count++;

                    end = time + 1;
                    a[smallest].exit_time = end;
                    a[smallest].turnaround_time = end - a[smallest].arrival_time;
                }
            }

            for (i = 0; i < n; i++)
            {
                a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
            }

            for (i = 0; i < n; i++)
            {
                avg = avg + a[i].waiting_time;
                tt = tt + a[i].turnaround_time;
            }
            //---------------------------
            //Drawing...
            label2.Visible = true;
            CountTime.Visible = true;
            count = 0;
            Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);

            for (i = 0; i <= time; i++)
            {

                if (i == time)
                {
                    TextBox txb = new TextBox();
                    txb.Location = new Point(i * 20, 2);
                    txb.Multiline = true;
                    txb.Font = font;
                    txb.Text = string.Format(" ");
                    txb.Text += "\r\n";
                    txb.Text += "\r\n" + i;
                    txb.BorderStyle = 0;
                    txb.BackColor = System.Drawing.Color.FromArgb(255, 60, 90, 190);
                    txb.AutoSize = false;
                    txb.ReadOnly = true;
                    txb.Margin = new Padding(0, 0, 0, 0);
                    txb.Size = new Size(15, 50);
                    GanttChartPanel.Controls.Add(txb);
                }
                else
                {
                    if (i == 0)
                    {
                        drawProcess(processGantt, colorProcess, font, i, i, 20, 50);
                    }
                    else
                    {
                        if (processGantt[i] != processGantt[i - 1])
                        {
                            drawProcess(processGantt, colorProcess, font, i, i, 20, 50);
                        }
                        else
                        {
                            TextBox txb = new TextBox();
                            txb.Location = new Point(i * 20, 2);
                            txb.Multiline = true;
                            txb.Font = font;
                            txb.Text = string.Format(" ");
                            txb.BorderStyle = 0;
                            txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                            txb.AutoSize = false;
                            txb.ReadOnly = true;
                            txb.Margin = new Padding(0, 0, 0, 0);
                            txb.Size = new Size(20, 50);
                            GanttChartPanel.Controls.Add(txb);
                        }
                    }
                }

                //Count time                
                CountTime.Text = "" + i;
                CountTime.Refresh();

            }
            //Show result
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }

        public void FCFS(Process[] a, int n)
        {
            arrangeArrival(a, n);

            // waiting time for first process is 0
            a[0].service_time = a[0].arrival_time;
            a[0].waiting_time = 0;

            // calculating waiting time
            for (int i = 1; i < n; i++)
            {
                a[i].service_time = a[i - 1].service_time + a[i - 1].burst_time;
                a[i].waiting_time = a[i].service_time - a[i].arrival_time;
                if (a[i].waiting_time < 0)
                {
                    a[i].waiting_time = 0;
                }
            }
            // calculating turnaround time 
            for (int i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].burst_time + a[i].waiting_time;
            }

            drawProcess(a, n);

            //Show result
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (int i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }
        public static void arrangePriority(Process[] a, int n)
        {
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].priority > a[j].priority)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public void Priority_NonPreemptive(Process[] a, int n)
        {
            Random rand = new Random();
            RGB[] colorProcess = new RGB[100];
            int xx, yy, zz, i;

            arrangePriority(a, n);
            // waiting time for first process is 0
            a[0].service_time = a[0].arrival_time;
            a[0].waiting_time = 0;
            // calculating waiting time
            for (i = 1; i < n; i++)
            {
                a[i].service_time = a[i - 1].service_time + a[i - 1].burst_time;
                a[i].waiting_time = a[i].service_time - a[i].arrival_time;
                if (a[i].waiting_time < 0)
                {
                    a[i].waiting_time = 0;
                }
            }
            // calculating turnaround time 
            for (i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].burst_time + a[i].waiting_time;
            }

            for (i = 0; i < n; i++)
            {
                //Random color 
                xx = rand.Next(50, 255);
                yy = rand.Next(50, 255);
                zz = rand.Next(50, 255);

                colorProcess[i].x = xx;
                colorProcess[i].y = yy;
                colorProcess[i].z = zz;
            }

            int count = 0, remain = 0;
            Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
            for (i = 0; i < n; i++)
            {

                TextBox txb1 = new TextBox();
                if (a[i].burst_time == 1)
                {
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(19, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                }
                else
                {
                    remain = a[i].burst_time;
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(20, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                    remain--;
                }
                while (remain != 0)
                {
                    if (remain == 1)
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(19, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    else
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(20, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    //Count time                
                    CountTime.Text = "" + count;
                    CountTime.Refresh();
                }
                //Count time                
                CountTime.Text = "" + count;
                CountTime.Refresh();
            }

            sortPID(a, n);
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time); ;
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }
        private void Priority_Preemptive(Process[] a, int n)
        {
            int i, smallest, count = 0, time, end;
            int[] x = new int[100];
            int[] y = new int[100];

            Random rand = new Random();
            int[] processGantt = new int[100];
            RGB[] colorStandar = new RGB[100];
            RGB[] colorProcess = new RGB[100];
            int xx, yy, zz;

            for (i = 0; i < n; i++)
            {
                x[i] = a[i].burst_time;
                y[i] = a[i].priority;
            }

            //Define color of Process
            for (i = 0; i < n; i++)
            {
                //Random color
                xx = rand.Next(70, 255);
                yy = rand.Next(70, 255);
                zz = rand.Next(50, 255);
                //Red - Green - Black
                colorStandar[i].x = xx;
                colorStandar[i].y = yy;
                colorStandar[i].z = zz;
            }


            //-------------------------
            //Declare max
            x[9] = 1000;
            y[9] = 10;

            for (time = 0; count != n; time++)
            {
                smallest = 9;

                for (i = 0; i < n; i++)
                {
                    if (a[i].arrival_time <= time && y[i] < y[smallest] && x[i] > 0)
                    {
                        smallest = i;
                        processGantt[time] = i;
                        colorProcess[time] = colorStandar[i];
                    }
                }
                x[smallest]--;
                if (x[smallest] == 0)//Process already done
                {
                    count++;

                    end = time + 1;
                    a[smallest].exit_time = end;
                    a[smallest].turnaround_time = end - a[smallest].arrival_time;
                }

                for (i = 0; i < n; i++)
                {
                    a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
                }
            }


            //---------------------------
            //Drawing...
            label2.Visible = true;
            CountTime.Visible = true;
            count = 0;
            Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);

            for (i = 0; i <= time; i++)
            {

                if (i == time)
                {
                    TextBox txb = new TextBox();
                    txb.Location = new Point(i * 20, 2);
                    txb.Multiline = true;
                    txb.Font = font;
                    txb.Text = string.Format(" ");
                    txb.Text += "\r\n";
                    txb.Text += "\r\n" + i;
                    txb.BorderStyle = 0;
                    txb.BackColor = System.Drawing.Color.FromArgb(255, 60, 90, 190);
                    txb.AutoSize = false;
                    txb.ReadOnly = true;
                    txb.Margin = new Padding(0, 0, 0, 0);
                    txb.Size = new Size(15, 50);
                    GanttChartPanel.Controls.Add(txb);
                }
                else
                {
                    if (i == 0)
                    {
                        drawProcess(processGantt, colorProcess, font, i, i, 20, 50);
                    }
                    else
                    {
                        if (processGantt[i] != processGantt[i - 1])
                        {
                            drawProcess(processGantt, colorProcess, font, i, i, 20, 50);
                        }
                        else
                        {
                            TextBox txb = new TextBox();
                            txb.Location = new Point(i * 20, 2);
                            txb.Multiline = true;
                            txb.Font = font;
                            txb.Text = string.Format(" ");
                            txb.BorderStyle = 0;
                            txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                            txb.AutoSize = false;
                            txb.ReadOnly = true;
                            txb.Margin = new Padding(0, 0, 0, 0);
                            txb.Size = new Size(20, 50);
                            GanttChartPanel.Controls.Add(txb);
                        }
                    }
                }

                //Count time                
                CountTime.Text = "" + i;
                CountTime.Refresh();

            }
            //Show result
            float S_wait = 0, S_turnarround = 0;
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTunarround Time");
            for (i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                //Console.Write("   {0}\t    {1,10}\t\t{2,-10}\t   {3,-20}", a[i].id, a[i].arrival_time, a[i].burst_time, a[i].priority);
                Console.Write(" {0}\t\t", a[i].id);
                Console.Write(" {0}\t\t{1}", a[i].waiting_time, a[i].turnaround_time);
                S_wait += (float)a[i].waiting_time;
                S_turnarround += (float)a[i].turnaround_time;
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Average waiting time: {0}", S_wait / n);
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Average turnarround time: {0}", S_turnarround / n);
        }

        public int NextArrivalTime(Process[] a, int current, int n)
        {
            for (int i = current + 1; i < n; i++)
            {
                if (a[i].arrival_time > a[current].arrival_time)
                {
                    return i;
                }
            }
            return -1;
        }
        public int totalTime(Process[] a, int n)
        {
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                S += a[i].burst_time;
            }
            return S;
        }

        public void RoundRobin(Process[] a, int n)
        {
            int quantum = (int)qInput.Value;

            Random rand = new Random();
            int[] processGantt = new int[99999];
            int[] processTime = new int[99999];
            int[] processLength = new int[99999];
            RGB[] colorStandar = new RGB[99999];
            RGB[] colorProcess = new RGB[99999];
            int xx, yy, zz;

            int i, count = 0, time;
            double avg = 0, tt = 0;

            for (i = 0; i < n; i++)
            {
                a[i].i = i;
                a[i].remaining_time = a[i].burst_time;
            }

            //Define color of Process
            for (i = 0; i < n; i++)
            {

                do
                {
                    //Random color
                    xx = rand.Next(0, 255);
                    yy = rand.Next(0, 255);
                    zz = rand.Next(0, 255);
                } while (xx == yy && yy == zz || (xx + yy + zz) / 3 <= 100);

                //Red - Green - Black
                colorStandar[i].x = xx;
                colorStandar[i].y = yy;
                colorStandar[i].z = zz;
            }

            //---------------------------
            // sort arrvial time
            arrangeArrival(a, n);
            //---------------------------
            //Calulating..        
            i = 0;
            int current_pos, last_pos = -1;
            a[i].waiting_time = 0;
            current_pos = a[i].arrival_time;
            int next_arrival_pos = NextArrivalTime(a, i, n);

            LinkedList<Process> list = new LinkedList<Process>();//Sử dụng giống Queue :V
            list.AddLast(a[i]);
            for (int tmp = i + 1; tmp < n; tmp++)
            {
                if (a[tmp].arrival_time == a[i].arrival_time)
                {
                    list.AddLast(a[tmp]);
                }
            }

            string seq = "";
            Console.Write("");
            while (list.Count() != 0)
            {
                Process current = list.First();//check first position
                last_pos = current.i;//Store last position
                seq += (last_pos + 1) + "->";//Test sequence

                //Store infomations to draw Grantt chart
                processGantt[current_pos] = last_pos + 1;//Seq
                processTime[current_pos] = current_pos;//Time line
                colorProcess[current_pos] = colorStandar[last_pos];//Color for each process


                list.RemoveFirst();
                next_arrival_pos = NextArrivalTime(a, i, n);//Find next process
                if (next_arrival_pos != -1)
                {
                    if (current.remaining_time <= quantum)
                    {
                        current_pos += current.remaining_time;
                        current.waiting_time = current_pos - current.burst_time - current.arrival_time;
                        current.turnaround_time = current.burst_time + current.waiting_time;

                        i++;
                        if (i >= n)
                        {
                            break;
                        }
                        list.AddLast(a[i]);
                    }
                    else
                    {
                        current_pos += quantum;
                        current.remaining_time -= quantum;
                        if (a[next_arrival_pos].arrival_time == current_pos)
                        {
                            for (int z = 0; z < n; z++)
                            {
                                if (current_pos > a[z].arrival_time && z != next_arrival_pos)
                                {
                                    list.AddLast(a[z]);
                                    i = z;
                                }
                            }
                            list.AddLast(current);
                            list.AddLast(a[next_arrival_pos]);
                            i = next_arrival_pos;
                            for (int z = next_arrival_pos + 1; z < n; z++)
                            {
                                if (a[z].arrival_time == a[next_arrival_pos].arrival_time)
                                {
                                    list.AddLast(a[z]);
                                    i = z;
                                }
                            }
                        }
                        else
                        {
                            if (a[next_arrival_pos].arrival_time < current_pos)
                            {
                                list.AddLast(a[next_arrival_pos]);
                                i = next_arrival_pos;
                                for (int z = next_arrival_pos + 1; z < n; z++)
                                {
                                    if (a[z].arrival_time < current_pos)
                                    {
                                        list.AddLast(a[z]);
                                        i = z;
                                    }
                                }
                                list.AddLast(current);

                            }
                        }
                    }
                }
                else
                {
                    if (current.remaining_time <= quantum)
                    {
                        current_pos += current.remaining_time;
                        current.waiting_time = current_pos - current.burst_time - current.arrival_time;
                        current.turnaround_time = current.burst_time + current.waiting_time;
                    }
                    else
                    {
                        current_pos += quantum;
                        current.remaining_time -= quantum;
                        list.AddLast(current);
                    }
                }

                a[last_pos] = current;
            }
            //Tính toán các thời gian trung bình
            for (i = 0; i < n; i++)
            {
                avg = avg + a[i].waiting_time;
                tt = tt + a[i].turnaround_time;
            }
            //---------------------------
            //Drawing...
            label2.Visible = true;
            CountTime.Visible = true;
            count = 0;
            Font font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular);
            time = totalTime(a, n);
            int last_color = -1;
            for (i = 0; i <= time; i++)
            {
                if (processTime[i] == i)
                {
                    TextBox txb = new TextBox();
                    txb.Location = new Point(i * 22 + 2, 2);
                    txb.Name = string.Format("P{0}", i);
                    txb.Tag = string.Format("[{0}]", i);
                    txb.Multiline = true;
                    txb.BorderStyle = 0;
                    txb.Font = font;
                    txb.Text = string.Format("P{0}", processGantt[i]);
                    txb.Text += "\r\n";
                    txb.Text += "\r\n" + i;
                    txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb.AutoSize = false;
                    txb.ReadOnly = true;
                    txb.Margin = new Padding(0, 0, 0, 0);
                    txb.Size = new Size(22, 50);
                    GanttChartPanel.Controls.Add(txb);
                    last_color = i;
                }
                else
                {
                    TextBox txb = new TextBox();
                    txb.Location = new Point(i * 22, 2);
                    txb.Multiline = true;
                    txb.Font = font;
                    txb.Text = string.Format(" ");
                    txb.BorderStyle = 0;
                    txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[last_color].x, colorProcess[last_color].y, colorProcess[last_color].z);
                    txb.AutoSize = false;
                    txb.ReadOnly = true;
                    txb.Margin = new Padding(0, 0, 0, 0);
                    txb.Size = new Size(22, 50);
                    GanttChartPanel.Controls.Add(txb);
                }

                //Count time                
                CountTime.Text = "" + i;
                CountTime.Refresh();
            }
            //Show result
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                txtConsole.AppendText(Environment.NewLine);
                Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            txtConsole.AppendText(Environment.NewLine);
            Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }

        public void drawProcess(Process[] a, int n)
        {
            Font font = new Font("Microsoft Sans Serif", 10);
            RGB[] colorProcess = new RGB[100];
            Random rand = new Random();
            int count = 0, i, remain = 0;
            //Define color of Process
            for (i = 0; i < n; i++)
            {
                //Random color
                //Red - Green - Black
                colorProcess[i].x = rand.Next(70, 255);
                colorProcess[i].y = rand.Next(70, 255);
                colorProcess[i].z = rand.Next(50, 255);
            }
            for (i = 0; i < n; i++)
            {

                TextBox txb1 = new TextBox();
                if (a[i].burst_time == 1)
                {
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(19, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                }
                else
                {
                    remain = a[i].burst_time;
                    txb1.Location = new Point(count * 20, 2);
                    txb1.Multiline = true;
                    txb1.Font = font;
                    txb1.Text = " " + a[i].id;
                    txb1.Text += "\r\n";
                    txb1.Text += "\r\n" + count;
                    txb1.BorderStyle = 0;
                    txb1.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                    txb1.AutoSize = false;
                    txb1.ReadOnly = true;
                    txb1.Margin = new Padding(0, 0, 0, 0);
                    txb1.Size = new Size(20, 50);
                    GanttChartPanel.Controls.Add(txb1);
                    count++;
                    remain--;
                }
                while (remain != 0)
                {
                    if (remain == 1)
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(19, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    else
                    {
                        TextBox txb = new TextBox();
                        txb.Location = new Point(count * 20, 2);
                        txb.Multiline = true;
                        txb.Font = font;
                        txb.Text = " ";
                        txb.BorderStyle = 0;
                        txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
                        txb.AutoSize = false;
                        txb.ReadOnly = true;
                        txb.Margin = new Padding(0, 0, 0, 0);
                        txb.Size = new Size(20, 50);
                        GanttChartPanel.Controls.Add(txb);
                        count++;
                        remain--;
                    }
                    //Count time                
                    CountTime.Text = "" + count;
                    CountTime.Refresh();
                }
                //Count time                
                CountTime.Text = "" + count;
                CountTime.Refresh();
            }
        }
        public void drawProcess(int[] processGantt, RGB[] colorProcess, Font font, int i, int k, int sizex, int sizey)
        {
            TextBox txb = new TextBox();
            txb.Location = new Point(k * 20, 2);
            txb.Name = string.Format("P{0}", k);
            txb.Tag = string.Format("[{0}]", k);
            txb.Multiline = true;
            txb.BorderStyle = 0;
            txb.Font = font;
            txb.Text = string.Format("P{0}", processGantt[i] + 1);
            txb.Text += "\r\n";
            txb.Text += "\r\n" + i;
            txb.BackColor = System.Drawing.Color.FromArgb(255, colorProcess[i].x, colorProcess[i].y, colorProcess[i].z);
            txb.AutoSize = false;
            txb.ReadOnly = true;
            txb.Margin = new Padding(0, 0, 0, 0);
            txb.Size = new Size(sizex, sizey);
            GanttChartPanel.Controls.Add(txb);
        }
    }
}
//End~~~