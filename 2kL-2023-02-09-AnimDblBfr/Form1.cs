namespace _2kL_2023_02_09_AnimDblBfr
{
    public partial class Form1 : Form
    {
        private Painter p;
        public Form1()
        {
            InitializeComponent();
            p = new Painter(mainPanel.CreateGraphics());
            p.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            p.AddNew();
        }
    }
}