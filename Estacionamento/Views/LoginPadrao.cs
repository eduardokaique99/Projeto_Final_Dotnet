using System;
using System.Windows.Forms;
using System.Drawing;

namespace Views {

    public class LoginPadrao {

        public static void Padroes() {
            
            Form menu = new Form();
            menu.Text = "Início";
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

            Button btnTipo = new Button();
            btnTipo.Text = "Tipos de Veículos";
            btnTipo.Font = new Font(btnTipo.Font.FontFamily, 18);
            btnTipo.Top = 20;
            btnTipo.Left = 20;
            btnTipo.Size = new System.Drawing.Size(1045, 140);
            btnTipo.BackColor = Color.BlueViolet;
            btnTipo.ForeColor = Color.White;
            btnTipo.Click += (sender, e) => {
                //TipoVeiculo.ListarTipos();
            };

            Button btnVeiculo = new Button();
            btnVeiculo.Text = "Veículos";
            btnVeiculo.Font = new Font(btnVeiculo.Font.FontFamily, 18);
            btnVeiculo.Top = 170;
            btnVeiculo.Left = 20;
            btnVeiculo.Size = new System.Drawing.Size(1045, 140);
            btnVeiculo.BackColor = Color.BlueViolet;
            btnVeiculo.ForeColor = Color.White;
            btnVeiculo.Click += (sender, e) => {
                //produtos.Close();
                //produtos.Dispose();
                //AdicionarProduto();
            };

            Button btnMov = new Button();
            btnMov.Text = "Movimentação";
            btnMov.Font = new Font(btnMov.Font.FontFamily, 18);
            btnMov.Top = 320;
            btnMov.Left = 20;
            btnMov.Size = new System.Drawing.Size(1045, 140);
            btnMov.BackColor = Color.BlueViolet;
            btnMov.ForeColor = Color.White;
            btnMov.Click += (sender, e) => {
                //produtos.Close();
                //produtos.Dispose();
                //AdicionarProduto();   
            };

            menu.Controls.Add(btnTipo);
            menu.Controls.Add(btnVeiculo);
            menu.Controls.Add(btnMov);
            menu.Controls.Add(panel);
            
            menu.ShowDialog();
        }
    }
}