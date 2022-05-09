using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalmManager
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            this.delayedWork();
        }
        private async Task delayedWork()
        {
            await Task.Delay(3000);
            this.Visible = false;
            var f2 = new Main();
            f2.ShowDialog();
        }
    }
}
