namespace CS311_Project_2_CPA
{
    public partial class Craps : Form
    {
        public Craps()
        {
            balance = 100.00m;
            InitializeComponent();
            IsFirstThrow = true;
            lblBalance.Text = balance.ToString("C");   
        }//end empty-argument constructor

        //Event handler for btnRoll event Click
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Calculate_Score();  
        }//end btnRoll_Click

        //Event handler for btnBet event Click
        private void btnBet_Click(object sender, EventArgs e)
        {
            txtBoxWager.Enabled = true;
            this.txtBoxWager.ReadOnly = false;
            this.btnBet.Enabled = false;
        }//end btnBet_Click

        //Event handler for textBox event TextChanged
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
        }//end txtBox_TextChanged

        //Event handler for btnEnter event Click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtBoxWager.Enabled = false;
            wager = decimal.Parse(txtBoxWager.Text);
            if (!Withdraw(wager))
                return;
            btnEnter.Enabled = false;
            btnRoll.Enabled = true;
            
        }//end btnEnter_Click

        /**
         *@return string corresponding to common dice names
         *@param int corresponding to a roll
         */ 
        private string DiceNames(int roll)
        {
            switch(roll)
            {
                case 2:
                    return "Snake Eyes";
                case 3:
                    return "Trey";
                case 7:
                    return "Seven";
                case 11:
                    return "Yo-Leven";
                case 12:
                    return "Box Cars";
                default:
                    return string.Empty; 
            }
        }//end DiceNames
    }//end partial class
}//end namespace