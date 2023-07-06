using System;
using Models;
using Controllers;
using System.Windows.Forms;

namespace Views {
    
    public class Veiculo {

        
        public static void ListarVeiculos() {
            Form veiculos = new Form();
            veiculos.Text = "Veiculos de Veículos";
            veiculos.Size = new System.Drawing.Size(700, 500);
            veiculos.StartPosition = FormStartPosition.CenterScreen;
            veiculos.FormBorderStyle = FormBorderStyle.FixedSingle;
            veiculos.MaximizeBox = false;
            veiculos.MinimizeBox = false;
            veiculos.BackColor = Color.BlueViolet;

            ListView listaVeiculo = new ListView();
            listaVeiculo.Size = new System.Drawing.Size(665, 400);
            listaVeiculo.Location = new System.Drawing.Point(10, 10);
            listaVeiculo.View = View.Details;

            listaVeiculo.Columns.Add("Id", 50);
            listaVeiculo.Columns.Add("Placa", 50);
            listaVeiculo.Columns.Add("Id Movimen.", 50);
            listaVeiculo.Columns.Add("Id Tipo", 50);
            listaVeiculo.Columns.Add("Id Cartão", 50);
            listaVeiculo.FullRowSelect = true;
            listaVeiculo.GridLines = true;
            veiculos.Controls.Add(listaVeiculo);

            List<Models.Veiculo> veiculoList = (List<Models.Veiculo>)Controllers.Veiculo.BuscarVeiculos();
            foreach (Models.Veiculo veiculo in veiculoList) {
                ListViewItem item = new ListViewItem(veiculo.Id.ToString());
                item.SubItems.Add(veiculo.Placa);
                //item.SubItems.Add(veiculo.IdMovimentacao);
                //item.SubItems.Add(veiculo.IdTipo);
                //item.SubItems.Add(veiculo.IdCartao);
                listaVeiculo.Items.Add(item);
            }

            Button btnAdicionar = new Button();
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Top = 420;
            btnAdicionar.Left = 10;
            btnAdicionar.Font = new Font(btnAdicionar.Font.FontFamily, 19);
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.ForeColor = Color.BlueViolet;
            btnAdicionar.Size = new System.Drawing.Size(150, 35);
            btnAdicionar.Click += (sender, e) => {
                veiculos.Close();
                veiculos.Dispose();
                CriarVeiculo();
            };
            
            
            Button btnEdit = new Button();
            btnEdit.Text = "Editar";
            btnEdit.Top = 420;
            btnEdit.Left = 181;
            btnEdit.Font = new Font(btnEdit.Font.FontFamily, 19);
            btnEdit.BackColor = Color.White;
            btnEdit.ForeColor = Color.BlueViolet;
            btnEdit.Size = new System.Drawing.Size(150, 35);
            btnEdit.Click += (sender, e) => {
                string id = listaVeiculo.SelectedItems[0].Text;
                veiculos.Close();
                veiculos.Dispose();
                AlterarVeiculo(Int32.Parse(id));
                veiculos.Close();
            };


            Button BtnRemove = new Button();
            BtnRemove.Text = "Remove";
            BtnRemove.Top = 420;
            BtnRemove.Left = 352;
            BtnRemove.Font = new Font(BtnRemove.Font.FontFamily, 19);
            BtnRemove.BackColor = Color.White;
            BtnRemove.ForeColor = Color.BlueViolet;
            BtnRemove.Size = new System.Drawing.Size(150, 35);
            BtnRemove.Click += (sender, e) => {
                string id = listaVeiculo.SelectedItems[0].Text;
                ExcluirVeiculo(Int32.Parse(id));
                veiculos.Dispose();
                veiculos.Close();
            };

            Button BtnVoltar = new Button();
            BtnVoltar.Text = "Voltar";
            BtnVoltar.Top = 420;
            BtnVoltar.Left = 523;
            BtnVoltar.Font = new Font(BtnVoltar.Font.FontFamily, 19);
            BtnVoltar.BackColor = Color.White;
            BtnVoltar.ForeColor = Color.BlueViolet;
            BtnVoltar.Size = new System.Drawing.Size(150, 35);
            BtnVoltar.Click += (sender, e) => {
                veiculos.Hide();
                veiculos.Close();
                veiculos.Dispose();
            };

            veiculos.Controls.Add(listaVeiculo);
            veiculos.Controls.Add(btnAdicionar);
            veiculos.Controls.Add(btnEdit);
            veiculos.Controls.Add(BtnRemove);
            veiculos.Controls.Add(BtnVoltar);
            veiculos.ShowDialog();
        } 

          public static void CriarVeiculo() {
            Form adicionarVeiculo = new Form();
            adicionarVeiculo.Text = "Adicionar Veiculo de veículo";
            adicionarVeiculo.Size = new System.Drawing.Size(400, 250);
            adicionarVeiculo.StartPosition = FormStartPosition.CenterScreen;
            adicionarVeiculo.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarVeiculo.MaximizeBox = false;
            adicionarVeiculo.MinimizeBox = false;
            adicionarVeiculo.BackColor = Color.BlueViolet;

            Label lblId= new Label();
            lblId.Text = "Id:";
            lblId.Top = 25;
            lblId.Left = 10;
            lblId.ForeColor = Color.White;
            lblId.Font = new Font(lblId.Font.FontFamily, 19);
            lblId.Size = new System.Drawing.Size(130, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 32;
            txtId.Left = 140;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(230, 35);

            Label lblPlaca = new Label();
            lblPlaca.Text = "Placa:";
            lblPlaca.Top = 60;
            lblPlaca.Left = 10;
            lblPlaca.ForeColor = Color.White;
            lblPlaca.Font = new Font(lblPlaca.Font.FontFamily, 19);
            lblPlaca.Size = new System.Drawing.Size(130, 35);

            TextBox txtPlaca = new TextBox();
            txtPlaca.Top = 67;
            txtPlaca.Left = 140;
            txtPlaca.BackColor = Color.LightGray;
            txtPlaca.Size = new System.Drawing.Size(230, 35);

            Label lblIdMovimentacao = new Label();
            lblIdMovimentacao.Text = "Id Movimentação:";
            lblIdMovimentacao.Top = 60;
            lblIdMovimentacao.Left = 10;
            lblIdMovimentacao.ForeColor = Color.White;
            lblIdMovimentacao.Font = new Font(lblIdMovimentacao.Font.FontFamily, 19);
            lblIdMovimentacao.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdMovimentacao = new TextBox();
            txtIdMovimentacao.Top = 67;
            txtIdMovimentacao.Left = 140;
            txtIdMovimentacao.BackColor = Color.LightGray;
            txtIdMovimentacao.Size = new System.Drawing.Size(230, 35);

            Label lblIdTipo = new Label();
            lblIdTipo.Text = "Id Tipo:";
            lblIdTipo.Top = 85;
            lblIdTipo.Left = 10;
            lblIdTipo.ForeColor = Color.White;
            lblIdTipo.Font = new Font(lblIdTipo.Font.FontFamily, 19);
            lblIdTipo.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdTipo = new TextBox();
            txtIdTipo.Top = 92;
            txtIdTipo.Left = 140;
            txtIdTipo.BackColor = Color.LightGray;
            txtIdTipo.Size = new System.Drawing.Size(230, 35);

            Label lblIdCartao = new Label();
            lblIdCartao.Text = "Id Cartão:";
            lblIdCartao.Top = 120;
            lblIdCartao.Left = 10;
            lblIdCartao.ForeColor = Color.White;
            lblIdCartao.Font = new Font(lblIdCartao.Font.FontFamily, 19);
            lblIdCartao.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdCartao = new TextBox();
            txtIdCartao.Top = 127;
            txtIdCartao.Left = 140;
            txtIdCartao.BackColor = Color.LightGray;
            txtIdCartao.Size = new System.Drawing.Size(230, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 127;
            btnSalvar.Left = 20;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 19);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                try
                {
                    Controllers.Veiculo.CriarVeiculo(int.Parse(txtId.Text), txtPlaca.Text, int.Parse(txtIdMovimentacao.Text), int.Parse(txtIdTipo.Text), int.Parse(txtIdCartao.Text));
                    adicionarVeiculo.Hide();
                    adicionarVeiculo.Close();
                    adicionarVeiculo.Dispose();
                    ListarVeiculos();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar produto: {err.Message}");
                }
                finally 
                {
                    adicionarVeiculo.Hide();
                    adicionarVeiculo.Close();
                    adicionarVeiculo.Dispose();
                    ListarVeiculos();                    
                }
                               
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Top = 127;
            btnCancelar.Left = 220;
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.BlueViolet;
            btnCancelar.Font = new Font(btnCancelar.Font.FontFamily, 19);
            btnCancelar.Size = new System.Drawing.Size(150, 35);
            btnCancelar.Click += (sender, e) => {
                adicionarVeiculo.Close();
            };

            adicionarVeiculo.Controls.Add(lblId);
            adicionarVeiculo.Controls.Add(txtId);
            adicionarVeiculo.Controls.Add(lblPlaca);
            adicionarVeiculo.Controls.Add(txtPlaca);
            adicionarVeiculo.Controls.Add(lblIdMovimentacao);
            adicionarVeiculo.Controls.Add(txtIdMovimentacao);
            adicionarVeiculo.Controls.Add(lblIdTipo);
            adicionarVeiculo.Controls.Add(txtIdTipo);
            adicionarVeiculo.Controls.Add(lblIdCartao);
            adicionarVeiculo.Controls.Add(txtIdCartao);
            adicionarVeiculo.Controls.Add(btnSalvar);
            adicionarVeiculo.Controls.Add(btnCancelar);
            adicionarVeiculo.ShowDialog();
        }


        public static void AlterarVeiculo(int id) {
            Models.Veiculo veiculo = Controllers.Veiculo.BuscarVeiculo(id);
            Form editar = new Form();
            editar.Text = "Editar Veiculo de veículo";
            editar.Size = new System.Drawing.Size(400, 250);
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.FormBorderStyle = FormBorderStyle.FixedSingle;
            editar.MaximizeBox = false;
            editar.MinimizeBox = false;
            editar.BackColor = Color.BlueViolet;

            Label lblId= new Label();
            lblId.Text = "Id:";
            lblId.Top = 25;
            lblId.Left = 10;
            lblId.ForeColor = Color.White;
            lblId.Font = new Font(lblId.Font.FontFamily, 19);
            lblId.Size = new System.Drawing.Size(130, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 32;
            txtId.Left = 140;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(230, 35);
            txtId.Text = veiculo.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblPlaca = new Label();
            lblPlaca.Text = "Placa:";
            lblPlaca.Top = 60;
            lblPlaca.Left = 10;
            lblPlaca.ForeColor = Color.White;
            lblPlaca.Font = new Font(lblPlaca.Font.FontFamily, 19);
            lblPlaca.Size = new System.Drawing.Size(130, 35);

            TextBox txtPlaca = new TextBox();
            txtPlaca.Top = 67;
            txtPlaca.Left = 140;
            txtPlaca.BackColor = Color.LightGray;
            txtPlaca.Size = new System.Drawing.Size(230, 35);

            Label lblIdMovimentacao = new Label();
            lblIdMovimentacao.Text = "Id Movimentação:";
            lblIdMovimentacao.Top = 60;
            lblIdMovimentacao.Left = 10;
            lblIdMovimentacao.ForeColor = Color.White;
            lblIdMovimentacao.Font = new Font(lblIdMovimentacao.Font.FontFamily, 19);
            lblIdMovimentacao.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdMovimentacao = new TextBox();
            txtIdMovimentacao.Top = 67;
            txtIdMovimentacao.Left = 140;
            txtIdMovimentacao.BackColor = Color.LightGray;
            txtIdMovimentacao.Size = new System.Drawing.Size(230, 35);

            Label lblIdTipo = new Label();
            lblIdTipo.Text = "Id Tipo:";
            lblIdTipo.Top = 85;
            lblIdTipo.Left = 10;
            lblIdTipo.ForeColor = Color.White;
            lblIdTipo.Font = new Font(lblIdTipo.Font.FontFamily, 19);
            lblIdTipo.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdTipo = new TextBox();
            txtIdTipo.Top = 92;
            txtIdTipo.Left = 140;
            txtIdTipo.BackColor = Color.LightGray;
            txtIdTipo.Size = new System.Drawing.Size(230, 35);

            Label lblIdCartao = new Label();
            lblIdCartao.Text = "Id Cartão:";
            lblIdCartao.Top = 120;
            lblIdCartao.Left = 10;
            lblIdCartao.ForeColor = Color.White;
            lblIdCartao.Font = new Font(lblIdCartao.Font.FontFamily, 19);
            lblIdCartao.Size = new System.Drawing.Size(130, 35);

            TextBox txtIdCartao = new TextBox();
            txtIdCartao.Top = 127;
            txtIdCartao.Left = 140;
            txtIdCartao.BackColor = Color.LightGray;
            txtIdCartao.Size = new System.Drawing.Size(230, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 127;
            btnSalvar.Left = 10;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 19);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Veiculo.AlterarVeiculo(int.Parse(txtId.Text), txtPlaca.Text, int.Parse(txtIdMovimentacao.Text), int.Parse(txtIdTipo.Text), int.Parse(txtIdCartao.Text));
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarVeiculos();
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Top = 127;
            btnCancelar.Left = 220;
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.BlueViolet;
            btnCancelar.Font = new Font(btnCancelar.Font.FontFamily, 19);
            btnCancelar.Size = new System.Drawing.Size(150, 35);
            btnCancelar.Click += (sender, e) => {
                editar.Close();
                editar.Dispose();
            };

            editar.Controls.Add(lblId);
            editar.Controls.Add(txtId);
            editar.Controls.Add(lblPlaca);
            editar.Controls.Add(txtPlaca);
            editar.Controls.Add(lblIdMovimentacao);
            editar.Controls.Add(txtIdMovimentacao);
            editar.Controls.Add(lblIdTipo);
            editar.Controls.Add(txtIdTipo);
            editar.Controls.Add(lblIdCartao);
            editar.Controls.Add(txtIdCartao);
            editar.Controls.Add(btnSalvar);
            editar.Controls.Add(btnCancelar);
            editar.ShowDialog();
    }


    public static void ExcluirVeiculo(int id) {

        Form remove = new Form();
        remove.Text = "Remover";
        remove.Size = new System.Drawing.Size(188, 83);
        remove.StartPosition = FormStartPosition.CenterScreen;
        remove.FormBorderStyle = FormBorderStyle.FixedSingle;
        remove.MaximizeBox = false;
        remove.MinimizeBox = false;

        Button sim = new Button();
        sim.Text = "Sim";
        sim.Top = 10;
        sim.Left = 10;
        sim.Size = new System.Drawing.Size(70, 25);
        sim.Click += (sender, e) => {
            Controllers.Veiculo.ExcluirVeiculo(id);
            remove.Close();
            remove.Dispose();
            ListarVeiculos();          
        };

        Button nao = new Button();
        nao.Text = "Não";
        nao.Top = 10;
        nao.Left = 90;
        nao.Size = new System.Drawing.Size(70, 25);
        nao.Click += (sender, e) => {
            remove.Hide();
            remove.Close();
            remove.Dispose();
            ListarVeiculos();
        };

        remove.Controls.Add(sim);
        remove.Controls.Add(nao);   
        remove.ShowDialog();
        }
    }
}