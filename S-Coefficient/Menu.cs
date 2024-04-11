using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace S_Coefficient
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CalcStart_Click(object sender, EventArgs e)
        {
            // review:男性/女性の選択肢はGUIで既に制約されている
            Debug.Assert(AMbutton.Checked != AFbutton.Checked);
            var sex = (AMbutton.Checked ? Sex.Male : Sex.Female);

            CalcSfactor CalcS = new CalcSfactor();
            if (PCHIP.Checked == true)
                CalcS.InterpolationMethod = "PCHIP";
            else if (Interpolation.Checked == true)
                CalcS.InterpolationMethod = "線形補間";

            (string mes, string info) = CalcS.CalcS(sex);
            MessageBox.Show(mes, info);
        }
    }
}
