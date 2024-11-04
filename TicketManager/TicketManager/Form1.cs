using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        private List<Ticket> tickets = new List<Ticket>();
        private string currentPrefix = "AAA";
        private int ticketCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var description = Txt_Input.Text;
            var detailedExplanation = Txt_DetailedExplanation.Text;

            if (string.IsNullOrWhiteSpace(description) && string.IsNullOrWhiteSpace(detailedExplanation))
            {
                MessageBox.Show("Both Description and Detailed Explanation cannot be empty.");
            }
            else if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description cannot be empty.");
            }
            else if (string.IsNullOrWhiteSpace(detailedExplanation))
            {
                MessageBox.Show("Detailed Explanation cannot be empty.");
            }
            else
            {
                var ticket = new Ticket
                {
                    Id = GenerateTicketId(),
                    Description = description,
                    DetailedExplanation = detailedExplanation,
                    Status = "Open",
                    EditCount = 0 // Initialize edit count
                };
                tickets.Add(ticket);
                Txt_Input.Clear();
                Txt_DetailedExplanation.Clear();
                Cmb_Status.SelectedIndex = 0; // Reset status to Open
                DisplayTickets();
                MessageBox.Show("Ticket created successfully.");
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (List_Tickets.SelectedItem is Ticket selectedTicket)
            {
                MessageBox.Show(selectedTicket.DetailedExplanation, "Ticket Details");
            }
            else
            {
                MessageBox.Show("Select a ticket to view.");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (List_Tickets.SelectedItem is Ticket selectedTicket)
            {
                var newDetailedExplanation = Txt_DetailedExplanation.Text;

                if (string.IsNullOrWhiteSpace(newDetailedExplanation))
                {
                    MessageBox.Show("Detailed Explanation cannot be empty.");
                }
                else
                {
                    // Update detailed explanation and increment edit count
                    selectedTicket.EditCount++;
                    selectedTicket.DetailedExplanation += $"\nEDIT {selectedTicket.EditCount}: {newDetailedExplanation}";
                    selectedTicket.Status = Cmb_Status.SelectedItem.ToString();
                    DisplayTickets();
                    MessageBox.Show("Ticket updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Select a ticket to update.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (List_Tickets.SelectedItem is Ticket selectedTicket)
            {
                tickets.Remove(selectedTicket);
                DisplayTickets();
                MessageBox.Show("Ticket deleted successfully.");
            }
            else
            {
                MessageBox.Show("Select a ticket to delete.");
            }
        }

        private string GenerateTicketId()
        {
            ticketCounter++;

            if (ticketCounter > 999)
            {
                ticketCounter = 1;
                currentPrefix = IncrementPrefix(currentPrefix);
            }

            return $"{currentPrefix}{ticketCounter:D3}";
        }

        private string IncrementPrefix(string prefix)
        {
            char[] chars = prefix.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] < 'Z')
                {
                    chars[i]++;
                    break;
                }
                else
                {
                    chars[i] = 'A';
                }
            }
            return new string(chars);
        }

        private void DisplayTickets()
        {
            List_Tickets.DataSource = null; // Reset the data source to refresh
            List_Tickets.DataSource = tickets; // Set the new data source
            List_Tickets.DisplayMember = "Display"; // Show formatted ticket info
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize your form or controls here
            Cmb_Status.SelectedIndex = 0; // Default status to "Open"
        }
    }

    public class Ticket
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string DetailedExplanation { get; set; }
        public string Status { get; set; }
        public int EditCount { get; set; } // Track the number of edits

        // Use this property to format how the ticket is displayed in the list
        public string Display => $"{Id} [{Status}] - {Description}";

        public override string ToString()
        {
            return Display; // To ensure the ListBox displays correctly
        }
    }
}

