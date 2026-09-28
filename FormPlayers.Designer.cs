namespace PlayerCards {
    partial class FormPlayers {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbPlayers = new ListBox();
            lblPlayerFirstName = new Label();
            tbPlayerFirstName = new TextBox();
            lblPlayerLastName = new Label();
            tbPlayerLastName = new TextBox();
            lblPlayerNumber = new Label();
            tbPlayerNumber = new TextBox();
            btnAddPlayer = new Button();
            SuspendLayout();
            // 
            // lbPlayers
            // 
            lbPlayers.FormattingEnabled = true;
            lbPlayers.Location = new Point(12, 12);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(362, 424);
            lbPlayers.TabIndex = 0;
            // 
            // lblPlayerFirstName
            // 
            lblPlayerFirstName.AutoSize = true;
            lblPlayerFirstName.Location = new Point(12, 455);
            lblPlayerFirstName.Name = "lblPlayerFirstName";
            lblPlayerFirstName.Size = new Size(37, 20);
            lblPlayerFirstName.TabIndex = 1;
            lblPlayerFirstName.Text = "Ime:";
            // 
            // tbPlayerFirstName
            // 
            tbPlayerFirstName.Location = new Point(107, 452);
            tbPlayerFirstName.Name = "tbPlayerFirstName";
            tbPlayerFirstName.Size = new Size(267, 27);
            tbPlayerFirstName.TabIndex = 2;
            // 
            // lblPlayerLastName
            // 
            lblPlayerLastName.AutoSize = true;
            lblPlayerLastName.Location = new Point(12, 490);
            lblPlayerLastName.Name = "lblPlayerLastName";
            lblPlayerLastName.Size = new Size(65, 20);
            lblPlayerLastName.TabIndex = 3;
            lblPlayerLastName.Text = "Prezime:";
            // 
            // tbPlayerLastName
            // 
            tbPlayerLastName.Location = new Point(107, 487);
            tbPlayerLastName.Name = "tbPlayerLastName";
            tbPlayerLastName.Size = new Size(267, 27);
            tbPlayerLastName.TabIndex = 4;
            // 
            // lblPlayerNumber
            // 
            lblPlayerNumber.AutoSize = true;
            lblPlayerNumber.Location = new Point(12, 523);
            lblPlayerNumber.Name = "lblPlayerNumber";
            lblPlayerNumber.Size = new Size(84, 20);
            lblPlayerNumber.TabIndex = 5;
            lblPlayerNumber.Text = "Broj igrača:";
            // 
            // tbPlayerNumber
            // 
            tbPlayerNumber.Location = new Point(107, 520);
            tbPlayerNumber.Name = "tbPlayerNumber";
            tbPlayerNumber.Size = new Size(267, 27);
            tbPlayerNumber.TabIndex = 6;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(12, 553);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(362, 46);
            btnAddPlayer.TabIndex = 7;
            btnAddPlayer.Text = "Unesi igrača!";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // FormPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 617);
            Controls.Add(btnAddPlayer);
            Controls.Add(tbPlayerNumber);
            Controls.Add(lblPlayerNumber);
            Controls.Add(tbPlayerLastName);
            Controls.Add(lblPlayerLastName);
            Controls.Add(tbPlayerFirstName);
            Controls.Add(lblPlayerFirstName);
            Controls.Add(lbPlayers);
            Name = "FormPlayers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Igrači";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbPlayers;
        private Label lblPlayerFirstName;
        private TextBox tbPlayerFirstName;
        private Label lblPlayerLastName;
        private TextBox tbPlayerLastName;
        private Label lblPlayerNumber;
        private TextBox tbPlayerNumber;
        private Button btnAddPlayer;
    }
}
