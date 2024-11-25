using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
            LoadTicketData();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_add_new_Click(object sender, EventArgs e)
        {

        }

        private void Counters_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Column headers styling
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView2.EnableHeadersVisualStyles = false;

                // Auto-size columns and rows
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Grid lines and borders
                dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView2.GridColor = Color.DarkGray;

                // Row styling
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView2.DefaultCellStyle.BackColor = Color.White;
                dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                // Center cell content
                dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Hide row headers
                dataGridView2.RowHeadersVisible = false;

                // Set read-only and selection mode
                dataGridView2.ReadOnly = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Set cell padding
                dataGridView2.DefaultCellStyle.Padding = new Padding(5);
            }
        }

        public class Ticket
        {
            public int TicketNumber { get; set; }
            public string Counter { get; set; }
        }
        // Method to load sample ticket data into the DataGridView
        private void LoadTicketData()
        {
            // Create a list of ticket data
            List<Ticket> tickets = new List<Ticket>
            {
                new Ticket { TicketNumber = 101, Counter = "Counter 1" },
                new Ticket { TicketNumber = 102, Counter = "Counter 2" },
                new Ticket { TicketNumber = 103, Counter = "Counter 1" },
                new Ticket { TicketNumber = 104, Counter = "Counter 3" }
            };

            // Set the data source of the DataGridView to the list of tickets
            dataGridView2.DataSource = tickets;

            // Adjust column headers for a cleaner look
            dataGridView2.Columns[0].HeaderText = "Ticket Number";
            dataGridView2.Columns[1].HeaderText = "Assigned Counter";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}