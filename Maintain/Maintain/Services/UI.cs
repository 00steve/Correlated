using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Maintain.Services
{
    class UI
    {
        private MainForm form;


        public UI(MainForm form)
        {
            this.form = form;


            setupInputs();

        }

        private void setupInputs()
        {
            form.QuitButton.Click += new EventHandler(this.onQuitButtonClick);
        }


        private void onQuitButtonClick(Object sender, EventArgs e)
        {
            form.Quit();
        }
    }
}
