using System;
using System.Windows.Forms;

namespace Descartin_LabAct3rd
{
    public partial class Form1 : Form
    {
        // Queue counter
        private int queueNumber = 1;

        public Form1()
        {
            InitializeComponent();

            // Prevent typing arbitrary values
            cmbPatientType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            // Validate patient name
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show(
                    "Please enter the patient name.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPatientName.Focus();
                return;
            }

            // Validate patient age
            if (string.IsNullOrWhiteSpace(txtPatientAge.Text))
            {
                MessageBox.Show(
                    "Please enter the patient age.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPatientAge.Focus();
                return;
            }

            if (!int.TryParse(txtPatientAge.Text, out int age))
            {
                MessageBox.Show(
                    "Please enter a valid age.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPatientAge.Focus();
                return;
            }

            if (age <= 0 || age > 120)
            {
                MessageBox.Show(
                    "Please enter an age between 1 and 120.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPatientAge.Focus();
                return;
            }

            // Validate reason
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show(
                    "Please enter the reason for visit.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtReason.Focus();
                return;
            }

            // Validate patient type
            if (cmbPatientType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a patient type.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPatientType.Focus();
                return;
            }

            // Get selected patient type
            string patientType = cmbPatientType.SelectedItem.ToString().Trim();

            // Determine priority
            string priority;

            switch (patientType)
            {
                case "Emergency":
                    priority = "EMERGENCY";
                    break;

                case "Senior":
                    priority = "SENIOR PRIORITY";
                    break;

                case "Pregnant":
                    priority = "PRIORITY";
                    break;

                case "Regular":
                    priority = "REGULAR";
                    break;

                default:
                    priority = "REGULAR";
                    break;
            }

            // Generate queue number
            string generatedQueueNumber = "Q" + queueNumber.ToString("D3");

            // Display results
            txtQueueNumber.Text = generatedQueueNumber;
            txtOutputPatientType.Text = patientType;
            txtExpectedPriority.Text = priority;

            // Increment queue number
            queueNumber++;

            MessageBox.Show(
                "Patient successfully added to the queue!",
                "Queue Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            txtPatientName.Clear();
            txtPatientAge.Clear();
            txtReason.Clear();
            cmbPatientType.SelectedIndex = -1;

            // Clear output fields
            txtQueueNumber.Clear();
            txtOutputPatientType.Clear();
            txtExpectedPriority.Clear();

            // Return focus
            txtPatientName.Focus();
        }
    }
}

