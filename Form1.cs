using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrife
{
    public partial class Form1 : Form
    {
        private string _valore1 = string.Empty;
        private string _valore2 = string.Empty;

        private Boolean _primoGiro = true;
        private Int32 _conteggioValore = 1;

        private String _operazione = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) //un unico evento per ogni tasto numerico cliccato
        {
            Button button = (Button)sender;

            string valore = button.Text;

            if (_primoGiro == true)
            {
                labelRisultato.Text = string.Empty;
                _primoGiro = false;
            }

            if (_conteggioValore == 1)
            {
                _valore1 = labelRisultato.Text;
                _valore1 = _valore1 + valore;
                labelRisultato.Text = _valore1;
            }
            else if (_conteggioValore == 2)
            {
                _valore2 = labelRisultato.Text;
                _valore2 = _valore2 + valore;
                labelRisultato.Text = _valore2;
            }

        }

        private void buttonOperazione_Click(object sender, EventArgs e) //un unico evento per ogni tasto operazione
        {
            Button button = (Button)sender;

           _operazione = button.Text;

            _primoGiro = true;

            _conteggioValore++;
        }

        private void buttonRisultato_Click(object sender, EventArgs e)
        {
            Int32 val1 = 0;
            Int32.TryParse(_valore1, out val1);

            Int32 val2 = 0;
            Int32.TryParse(_valore2, out val2);

            Int32 valore = 0;
            
            switch (_operazione)
            {
                case "+":
                    valore = val1 + val2;
                    break;
                case "-":
                    valore = val1 - val2;
                    break;
                case "x":
                    valore = val1 * val2;
                    break;
                case "/":
                    valore = val1 / val2; 
                    break;
            }

            labelRisultato.Text = valore.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
