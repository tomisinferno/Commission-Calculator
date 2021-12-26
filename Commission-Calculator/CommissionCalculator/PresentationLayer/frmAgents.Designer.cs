
namespace CommissionCalculator
{
    partial class frmAgents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbAgentType = new System.Windows.Forms.GroupBox();
            this.rbSAgent = new System.Windows.Forms.RadioButton();
            this.rbAgent = new System.Windows.Forms.RadioButton();
            this.rbJAgent = new System.Windows.Forms.RadioButton();
            this.lblCommissionEarned = new System.Windows.Forms.Label();
            this.lblCommissionRate = new System.Windows.Forms.Label();
            this.lblBonusOrReduction = new System.Windows.Forms.Label();
            this.txtCommEarned = new System.Windows.Forms.TextBox();
            this.txtCommRate = new System.Windows.Forms.TextBox();
            this.txtBonusOrReduction = new System.Windows.Forms.TextBox();
            this.gbAgentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(44, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(44, 92);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(44, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesAmount.Location = new System.Drawing.Point(44, 222);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(94, 16);
            this.lblSalesAmount.TabIndex = 0;
            this.lblSalesAmount.Text = "Sales Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(47, 291);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(186, 291);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 12;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesAmount.Location = new System.Drawing.Point(145, 222);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(128, 22);
            this.txtSalesAmount.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(145, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(145, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(128, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(145, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbAgentType
            // 
            this.gbAgentType.Controls.Add(this.rbSAgent);
            this.gbAgentType.Controls.Add(this.rbAgent);
            this.gbAgentType.Controls.Add(this.rbJAgent);
            this.gbAgentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgentType.Location = new System.Drawing.Point(406, 28);
            this.gbAgentType.Name = "gbAgentType";
            this.gbAgentType.Size = new System.Drawing.Size(178, 145);
            this.gbAgentType.TabIndex = 4;
            this.gbAgentType.TabStop = false;
            this.gbAgentType.Text = "Agent Type";
            // 
            // rbSAgent
            // 
            this.rbSAgent.AutoSize = true;
            this.rbSAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSAgent.Location = new System.Drawing.Point(19, 110);
            this.rbSAgent.Name = "rbSAgent";
            this.rbSAgent.Size = new System.Drawing.Size(103, 20);
            this.rbSAgent.TabIndex = 7;
            this.rbSAgent.TabStop = true;
            this.rbSAgent.Text = "Senior Agent";
            this.rbSAgent.UseVisualStyleBackColor = true;
            // 
            // rbAgent
            // 
            this.rbAgent.AutoSize = true;
            this.rbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAgent.Location = new System.Drawing.Point(19, 72);
            this.rbAgent.Name = "rbAgent";
            this.rbAgent.Size = new System.Drawing.Size(61, 20);
            this.rbAgent.TabIndex = 6;
            this.rbAgent.TabStop = true;
            this.rbAgent.Text = "Agent";
            this.rbAgent.UseVisualStyleBackColor = true;
            // 
            // rbJAgent
            // 
            this.rbJAgent.AutoSize = true;
            this.rbJAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJAgent.Location = new System.Drawing.Point(19, 34);
            this.rbJAgent.Name = "rbJAgent";
            this.rbJAgent.Size = new System.Drawing.Size(100, 20);
            this.rbJAgent.TabIndex = 5;
            this.rbJAgent.TabStop = true;
            this.rbJAgent.Text = "Junior Agent";
            this.rbJAgent.UseVisualStyleBackColor = true;
            // 
            // lblCommissionEarned
            // 
            this.lblCommissionEarned.AutoSize = true;
            this.lblCommissionEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommissionEarned.Location = new System.Drawing.Point(342, 279);
            this.lblCommissionEarned.Name = "lblCommissionEarned";
            this.lblCommissionEarned.Size = new System.Drawing.Size(132, 16);
            this.lblCommissionEarned.TabIndex = 4;
            this.lblCommissionEarned.Text = "Commission Earned:";
            // 
            // lblCommissionRate
            // 
            this.lblCommissionRate.AutoSize = true;
            this.lblCommissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommissionRate.Location = new System.Drawing.Point(342, 323);
            this.lblCommissionRate.Name = "lblCommissionRate";
            this.lblCommissionRate.Size = new System.Drawing.Size(117, 16);
            this.lblCommissionRate.TabIndex = 4;
            this.lblCommissionRate.Text = "Commission Rate:";
            // 
            // lblBonusOrReduction
            // 
            this.lblBonusOrReduction.AutoSize = true;
            this.lblBonusOrReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusOrReduction.Location = new System.Drawing.Point(345, 367);
            this.lblBonusOrReduction.Name = "lblBonusOrReduction";
            this.lblBonusOrReduction.Size = new System.Drawing.Size(114, 16);
            this.lblBonusOrReduction.TabIndex = 4;
            this.lblBonusOrReduction.Text = "Bonus/Reduction:";
            // 
            // txtCommEarned
            // 
            this.txtCommEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommEarned.Location = new System.Drawing.Point(480, 278);
            this.txtCommEarned.Name = "txtCommEarned";
            this.txtCommEarned.ReadOnly = true;
            this.txtCommEarned.Size = new System.Drawing.Size(104, 22);
            this.txtCommEarned.TabIndex = 9;
            // 
            // txtCommRate
            // 
            this.txtCommRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommRate.Location = new System.Drawing.Point(480, 322);
            this.txtCommRate.Name = "txtCommRate";
            this.txtCommRate.ReadOnly = true;
            this.txtCommRate.Size = new System.Drawing.Size(104, 22);
            this.txtCommRate.TabIndex = 10;
            // 
            // txtBonusOrReduction
            // 
            this.txtBonusOrReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonusOrReduction.Location = new System.Drawing.Point(480, 366);
            this.txtBonusOrReduction.Name = "txtBonusOrReduction";
            this.txtBonusOrReduction.ReadOnly = true;
            this.txtBonusOrReduction.Size = new System.Drawing.Size(104, 22);
            this.txtBonusOrReduction.TabIndex = 11;
            // 
            // frmAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.txtBonusOrReduction);
            this.Controls.Add(this.txtCommRate);
            this.Controls.Add(this.txtCommEarned);
            this.Controls.Add(this.lblBonusOrReduction);
            this.Controls.Add(this.lblCommissionRate);
            this.Controls.Add(this.lblCommissionEarned);
            this.Controls.Add(this.gbAgentType);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSalesAmount);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmAgents";
            this.Text = "Agents Commission";
            this.gbAgentType.ResumeLayout(false);
            this.gbAgentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbAgentType;
        private System.Windows.Forms.RadioButton rbSAgent;
        private System.Windows.Forms.RadioButton rbAgent;
        private System.Windows.Forms.RadioButton rbJAgent;
        private System.Windows.Forms.Label lblCommissionEarned;
        private System.Windows.Forms.Label lblCommissionRate;
        private System.Windows.Forms.Label lblBonusOrReduction;
        private System.Windows.Forms.TextBox txtCommEarned;
        private System.Windows.Forms.TextBox txtCommRate;
        private System.Windows.Forms.TextBox txtBonusOrReduction;
    }
}

