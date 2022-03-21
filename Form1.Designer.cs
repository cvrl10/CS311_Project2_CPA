namespace CS311_Project_2_CPA
{
    using Properties;
    partial class Craps : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private decimal balance;
        private decimal wager;
        private int myPoint;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDice1 = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBoxWager = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblDiceNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice1.Location = new System.Drawing.Point(166, 233);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(129, 58);
            this.lblDice1.TabIndex = 0;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(166, 91);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(129, 139);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(301, 91);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(129, 139);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 3;
            this.picBox2.TabStop = false;
            // 
            // lblDice2
            // 
            this.lblDice2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice2.Location = new System.Drawing.Point(301, 233);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(129, 58);
            this.lblDice2.TabIndex = 4;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(301, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(213, 35);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            this.btnRoll.Enabled = false;
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(523, 175);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRoll.Size = new System.Drawing.Size(217, 59);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(523, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(214, 64);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBet.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBet.Location = new System.Drawing.Point(523, 296);
            this.btnBet.Name = "btnBet";
            this.btnBet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBet.Size = new System.Drawing.Size(217, 59);
            this.btnBet.TabIndex = 0;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBoxWager
            // 
            this.txtBoxWager.AcceptsReturn = true;
            this.txtBoxWager.Location = new System.Drawing.Point(523, 253);
            this.txtBoxWager.Name = "txtBoxWager";
            this.txtBoxWager.PlaceholderText = "enter your bet";
            this.txtBoxWager.ReadOnly = true;
            this.txtBoxWager.Size = new System.Drawing.Size(106, 27);
            this.txtBoxWager.TabIndex = 1;
            this.txtBoxWager.UseWaitCursor = true;
            this.txtBoxWager.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(635, 253);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(105, 27);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblDiceNames
            // 
            this.lblDiceNames.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiceNames.Location = new System.Drawing.Point(166, 291);
            this.lblDiceNames.Name = "lblDiceNames";
            this.lblDiceNames.Size = new System.Drawing.Size(264, 57);
            this.lblDiceNames.TabIndex = 11;
            this.lblDiceNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiceNames);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtBoxWager);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.lblDice1);
            this.Name = "Craps";
            this.Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }//end InitializeComponent

        #endregion

        private PictureBox picBox1;
        private PictureBox picBox2;
        private Label lblDice1;
        private Label lblDice2;
        private Label lblBalance;

        /* does the proccesing for the roll
         */
        private void Calculate_Score()
        {
            Random roll1 = new Random();
            Random roll2 = new Random();
            int die1 = roll1.Next(1, 7);
            int die2 = roll2.Next(1, 7);
            picBox1.Image = (Image)Resources.ResourceManager.GetObject($"{die1}");
            picBox2.Image = (Image)Resources.ResourceManager.GetObject($"{die2}");
            lblDice1.Text = die1.ToString();
            lblDice2.Text = die2.ToString();
            int total = Sum(die1, die2);
            lblDiceNames.Text = DiceNames(total);
            if (this.IsFirstThrow)
            {
                switch (total)
                {
                    case 7:
                    case 11:
                        lblResult.Text = "You Win!";
                        balance += wager;
                        lblBalance.Text = $"{balance:C}";
                        break;
                    case 2:
                    case 3:
                    case 12:
                        lblResult.Text = "You Lose!";
                        balance -= wager;
                        lblBalance.Text = $"{balance:C}"; 
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                        lblResult.Text = $"Point is {total}";
                        break;
                }
                this.IsFirstThrow = false;
                myPoint = total;
                if (IsOver(total))
                    EndGame();
            }
            else
            {
                string result;
                if (total == myPoint)
                    result = "You Win!";
                else
                    result = $"Your point is {myPoint}\nand you rolled {total}";
                switch (total)
                {
                    case 7:
                        lblResult.Text = "You Lose!";
                        balance -= wager;
                        lblBalance.Text = $"{balance:C}";
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                        lblResult.Text = result;
                        break;
                }
                if (total == 7 || total == myPoint)
                {
                    if (total == myPoint)
                    {
                        balance += wager;
                        lblBalance.Text = $"{balance:C}";
                    }
                    EndGame();
                } 
            }
        }//end calculate_score

        private Button btnRoll;

        /*expresion-bodied method that returns the sum of the two arguments
         */ 
        private int Sum(int first, int second) => first + second;

        /*expresion-bodied method that returns the sum of the two arguments
         */ 
        private decimal Sum(decimal first, decimal second) => first + second;

        /* auto-implemented bool property that sets the first throw of dice to true on the first throw,
         * @return true if this is the first throw and false otherwise.
         */
        private bool IsFirstThrow {get; set;}

        /* @returns true if the user wins or lose the game on the first throw
         */
        private bool IsOver(int total)
        {
                switch (total)
                {
                    case 7:
                    case 11:
                    case 2:
                    case 3:
                    case 12:
                        return true;
                    default:
                        return false;
                }
        }//end IsOver

        /*ends the game when the user either wins or lose the game
         */
        private void EndGame()
        {
            btnRoll.Enabled = false;
            btnBet.Enabled = true;
            this.IsFirstThrow = true;
            txtBoxWager.Text = null;
            btnEnter.Enabled = false;
        }//end EndGame

        private Label lblResult;
        private Button btnBet;
        private TextBox txtBoxWager;
        private Button btnEnter;

        /* @return true if the user has enough money in their bank to cover the bet
         * @param wager, the monetary value of the bet
         */
        private bool Withdraw(decimal wager)
        {
            if (Sum(balance, -wager) < 0)
            {
                MessageBox.Show("Insufficient balance");
                EndGame();
                return false;
            }
            else
                return true;
        }//end Withdraw

        private Label lblDiceNames;
    }
}