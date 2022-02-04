using System.Windows.Forms;
using TopSharpForms = TopSharp_NetFramework.FORMS.Forms;

namespace TiaTools_V3._0.Forms
{
    public partial class Main : Form
    {
        private Form activeForm;

        public Main()
        {
            InitializeComponent();
        }

        private void button_IO_Click(object sender, System.EventArgs e)
        {
            TopSharpForms.CloseForm(activeForm);
            activeForm = TopSharpForms.OpenFormInPanel(new Form_IO(), panel_ChildForm);
        }

        private void button_Messages_Click(object sender, System.EventArgs e)
        {
            TopSharpForms.CloseForm(activeForm);
            activeForm = TopSharpForms.OpenFormInPanel(new Form_Messages(), panel_ChildForm);
        }

        private void button_StateMachines_Click(object sender, System.EventArgs e)
        {
            TopSharpForms.CloseForm(activeForm);
            activeForm = TopSharpForms.OpenFormInPanel(new Form_StateMachines(), panel_ChildForm);
        }
        private void button_ReportManager_Click(object sender, System.EventArgs e)
        {
            TopSharpForms.CloseForm(activeForm);
            activeForm = TopSharpForms.OpenFormInPanel(new Form_ReportManager(), panel_ChildForm);
        }
    }
}
