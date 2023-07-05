using System;
using System.Windows.Forms;
using System.Drawing;

namespace View {

    public class LoginADM {

        public static void ADM() {
            
            Form menu = new Form();
            menu.Text = "Administrador";
            menu.Size = new System.Drawing.Size(1100, 518);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.BackColor = Color.BlueViolet;
            
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(1065, 458);
            panel.Top = 10;
            panel.Left = 10;

            Button btnUser = new Button();
            btnUser.Text = "Usuários";
            btnUser.Font = new Font(btnUser.Font.FontFamily, 19);
            btnUser.Top = 20;
            btnUser.Left = 20;
            btnUser.Size = new System.Drawing.Size(1045, 80);
            btnUser.BackColor = Color.BlueViolet;
            btnUser.ForeColor = Color.White;
            btnUser.Click += (sender, e) => {
                menu.Close();
                menu.Dispose();
                //View.Usuario.Usuario();
            };

            Button btnTurno = new Button();
            btnTurno.Text = "Turnos";
            btnTurno.Font = new Font(btnTurno.Font.FontFamily, 19);
            btnTurno.Top = 110;
            btnTurno.Left = 20;
            btnTurno.Size = new System.Drawing.Size(1045, 80);
            btnTurno.BackColor = Color.BlueViolet;
            btnTurno.ForeColor = Color.White;
            btnTurno.Click += (sender, e) => {
                menu.Close();
                menu.Dispose();
                //View.Turno.Turnos();   
            };

            Button btnTipo = new Button();
            btnTipo.Text = "Tipos de Veículos";
            btnTipo.Font = new Font(btnTipo.Font.FontFamily, 19);
            btnTipo.Top = 200;
            btnTipo.Left = 20;
            btnTipo.Size = new System.Drawing.Size(1045, 80);
            btnTipo.BackColor = Color.BlueViolet;
            btnTipo.ForeColor = Color.White;
            btnTipo.Click += (sender, e) => {
                menu.Close();
                menu.Dispose();
                View.TipoVeiculo.ListarTipos();   
            };

            Button btnVeiculo = new Button();
            btnVeiculo.Text = "Veículos";
            btnVeiculo.Font = new Font(btnVeiculo.Font.FontFamily, 19);
            btnVeiculo.Top = 290;
            btnVeiculo.Left = 20;
            btnVeiculo.Size = new System.Drawing.Size(1045, 80);
            btnVeiculo.BackColor = Color.BlueViolet;
            btnVeiculo.ForeColor = Color.White;
            btnVeiculo.Click += (sender, e) => {
                menu.Close();
                menu.Dispose();
                View.Veiculo.ListarVeiculos(); 
            };

            Button btnMov = new Button();
            btnMov.Text = "Movimentação";
            btnMov.Font = new Font(btnMov.Font.FontFamily, 19);
            btnMov.Top = 380;
            btnMov.Left = 20;
            btnMov.Size = new System.Drawing.Size(1045, 80);
            btnMov.BackColor = Color.BlueViolet;
            btnMov.ForeColor = Color.White;
            btnMov.Click += (sender, e) => {
                menu.Close();
                menu.Dispose();
                View.Movimentacao.ListarMovimentacoes();  
            };

            
            menu.Controls.Add(btnUser);
            menu.Controls.Add(btnTurno);
            menu.Controls.Add(btnTipo);
            menu.Controls.Add(btnVeiculo);
            menu.Controls.Add(btnMov);
            menu.Controls.Add(panel);
            
            menu.ShowDialog();
        }
    }
}