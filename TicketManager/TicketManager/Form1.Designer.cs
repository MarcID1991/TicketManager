using System;

namespace TicketManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.List_Tickets = new System.Windows.Forms.ListBox();
            this.Lbl_Input = new System.Windows.Forms.Label();
            this.Txt_DetailedExplanation = new System.Windows.Forms.TextBox();
            this.Lbl_DetailedExplanation = new System.Windows.Forms.Label();
            this.Cmb_Status = new System.Windows.Forms.ComboBox();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(59, 48);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(300, 20);
            this.Txt_Input.TabIndex = 0;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(127, 126);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create Ticket";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(437, 97);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 2;
            this.BtnView.Text = "View Ticket";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(208, 126);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update Ticket";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(535, 97);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete Ticket";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // List_Tickets
            // 
            this.List_Tickets.FormattingEnabled = true;
            this.List_Tickets.Location = new System.Drawing.Point(417, 129);
            this.List_Tickets.Name = "List_Tickets";
            this.List_Tickets.Size = new System.Drawing.Size(231, 147);
            this.List_Tickets.TabIndex = 5;
            // 
            // Lbl_Input
            // 
            this.Lbl_Input.AutoSize = true;
            this.Lbl_Input.Location = new System.Drawing.Point(155, 32);
            this.Lbl_Input.Name = "Lbl_Input";
            this.Lbl_Input.Size = new System.Drawing.Size(93, 13);
            this.Lbl_Input.TabIndex = 6;
            this.Lbl_Input.Text = "Ticket Description";
            // 
            // Txt_DetailedExplanation
            // 
            this.Txt_DetailedExplanation.Location = new System.Drawing.Point(20, 176);
            this.Txt_DetailedExplanation.Multiline = true;
            this.Txt_DetailedExplanation.Name = "Txt_DetailedExplanation";
            this.Txt_DetailedExplanation.Size = new System.Drawing.Size(374, 100);
            this.Txt_DetailedExplanation.TabIndex = 7;
            // 
            // Lbl_DetailedExplanation
            // 
            this.Lbl_DetailedExplanation.AutoSize = true;
            this.Lbl_DetailedExplanation.Location = new System.Drawing.Point(165, 160);
            this.Lbl_DetailedExplanation.Name = "Lbl_DetailedExplanation";
            this.Lbl_DetailedExplanation.Size = new System.Drawing.Size(104, 13);
            this.Lbl_DetailedExplanation.TabIndex = 8;
            this.Lbl_DetailedExplanation.Text = "Detailed Explanation";
            this.Lbl_DetailedExplanation.Click += new System.EventHandler(this.Lbl_DetailedExplanation_Click);
            // 
            // Cmb_Status
            // 
            this.Cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Status.FormattingEnabled = true;
            this.Cmb_Status.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Done"});
            this.Cmb_Status.Location = new System.Drawing.Point(149, 99);
            this.Cmb_Status.Name = "Cmb_Status";
            this.Cmb_Status.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Status.TabIndex = 9;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(184, 83);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.Lbl_Status.TabIndex = 10;
            this.Lbl_Status.Text = "Status";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(659, 289);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.Cmb_Status);
            this.Controls.Add(this.Lbl_DetailedExplanation);
            this.Controls.Add(this.Txt_DetailedExplanation);
            this.Controls.Add(this.Lbl_Input);
            this.Controls.Add(this.List_Tickets);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.Txt_Input);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Lbl_DetailedExplanation_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox List_Tickets;
        private System.Windows.Forms.Label Lbl_Input;
        private System.Windows.Forms.TextBox Txt_DetailedExplanation;
        private System.Windows.Forms.Label Lbl_DetailedExplanation;
        private System.Windows.Forms.ComboBox Cmb_Status;
        private System.Windows.Forms.Label Lbl_Status;
    }
}