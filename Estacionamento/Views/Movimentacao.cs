using System;
using System.Windows.Forms;

namespace Views {
    
    public class Movimentacao {
        
        public static void ListarMovimentacoes() {
            Form movimentacoes = new Form();
            movimentacoes.Text = "Movimentacoes de Veículos";
            movimentacoes.Size = new System.Drawing.Size(700, 500);
            movimentacoes.StartPosition = FormStartPosition.CenterScreen;
            movimentacoes.FormBorderStyle = FormBorderStyle.FixedSingle;
            movimentacoes.MaximizeBox = false;
            movimentacoes.MinimizeBox = false;
            movimentacoes.BackColor = Color.BlueViolet;

            ListView listaMovimentacao = new ListView();
            listaMovimentacao.Size = new System.Drawing.Size(665, 400);
            listaMovimentacao.Location = new System.Drawing.Point(10, 10);
            listaMovimentacao.View = View.Details;
            listaMovimentacao.Columns.Add("Id", 50);
            listaMovimentacao.Columns.Add("Descrição", 611);
            listaMovimentacao.FullRowSelect = true;
            listaMovimentacao.GridLines = true;

            //List<Model.Movimentacao> movimentacoesList = Controller.Movimentacao.ListaMovimentacao();
            //foreach (Model.Movimentacao veiculo in movimentacoesList) {
            //    ListViewItem item = new ListViewItem(veiculo.Id.ToString());
            //    item.SubItems.Add(veiculo.Descricao);
            //    listaMovimentacao.Items.Add(item);
            //}

            Button btnAdicionar = new Button();
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Top = 420;
            btnAdicionar.Left = 10;
            btnAdicionar.Font = new Font(btnAdicionar.Font.FontFamily, 19);
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.ForeColor = Color.BlueViolet;
            btnAdicionar.Size = new System.Drawing.Size(150, 35);
            btnAdicionar.Click += (sender, e) => {
                movimentacoes.Close();
                movimentacoes.Dispose();
                CriarMovimentacao();
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
                string id = listaMovimentacao.SelectedItems[0].Text;
                movimentacoes.Close();
                movimentacoes.Dispose();
                AlterarMovimentacao(Int32.Parse(id));
                movimentacoes.Close();
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
                string id = listaMovimentacao.SelectedItems[0].Text;
                ExcluirMovimentacao(Int32.Parse(id));
                movimentacoes.Dispose();
                movimentacoes.Close();
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
                movimentacoes.Hide();
                movimentacoes.Close();
                movimentacoes.Dispose();
            };

            movimentacoes.Controls.Add(listaMovimentacao);
            movimentacoes.Controls.Add(btnAdicionar);
            movimentacoes.Controls.Add(btnEdit);
            movimentacoes.Controls.Add(BtnRemove);
            movimentacoes.Controls.Add(BtnVoltar);
            movimentacoes.ShowDialog();
        } 

          public static void CriarMovimentacao() {
            Form adicionarMovimentacao = new Form();
            adicionarMovimentacao.Text = "Adicionar Movimentacao de veículo";
            adicionarMovimentacao.Size = new System.Drawing.Size(400, 250);
            adicionarMovimentacao.StartPosition = FormStartPosition.CenterScreen;
            adicionarMovimentacao.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarMovimentacao.MaximizeBox = false;
            adicionarMovimentacao.MinimizeBox = false;
            adicionarMovimentacao.BackColor = Color.BlueViolet;

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


            Label lblDescri = new Label();
            lblDescri.Text = "Descrição:";
            lblDescri.Top = 60;
            lblDescri.Left = 10;
            lblDescri.ForeColor = Color.White;
            lblDescri.Font = new Font(lblDescri.Font.FontFamily, 19);
            lblDescri.Size = new System.Drawing.Size(130, 35);

            TextBox txtDescri = new TextBox();
            txtDescri.Top = 67;
            txtDescri.Left = 140;
            txtDescri.BackColor = Color.LightGray;
            txtDescri.Size = new System.Drawing.Size(230, 35);

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
                    Controllers.Movimentacao.CriarMovimentacao(int.Parse(txtId.Text), txtDescri.Text);
                    adicionarMovimentacao.Hide();
                    adicionarMovimentacao.Close();
                    adicionarMovimentacao.Dispose();
                    ListarMovimentacoes();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar produto: {err.Message}");
                }
                finally 
                {
                    adicionarMovimentacao.Hide();
                    adicionarMovimentacao.Close();
                    adicionarMovimentacao.Dispose();
                    ListarMovimentacoes();                    
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
                adicionarMovimentacao.Close();
            };

            adicionarMovimentacao.Controls.Add(lblId);
            adicionarMovimentacao.Controls.Add(txtId);
            adicionarMovimentacao.Controls.Add(lblDescri);
            adicionarMovimentacao.Controls.Add(txtDescri);
            adicionarMovimentacao.Controls.Add(btnSalvar);
            adicionarMovimentacao.Controls.Add(btnCancelar);
            adicionarMovimentacao.ShowDialog();
        }


        public static void AlterarMovimentacao(int id) {
            Models.Movimentacao veiculo = Controllers.Movimentacao.BuscarMovimentacao(id);
            Form editar = new Form();
            editar.Text = "Editar Movimentacao de veículo";
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

            Label lblDescri = new Label();
            lblDescri.Text = "Descrição:";
            lblDescri.Top = 60;
            lblDescri.Left = 10;
            lblDescri.ForeColor = Color.White;
            lblDescri.Font = new Font(lblDescri.Font.FontFamily, 19);
            lblDescri.Size = new System.Drawing.Size(130, 35);

            TextBox txtDescri = new TextBox();
            txtDescri.Top = 67;
            txtDescri.Left = 140;
            txtDescri.BackColor = Color.LightGray;
            txtDescri.Size = new System.Drawing.Size(230, 35);
            txtDescri.Text = veiculo.Descricao;

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 127;
            btnSalvar.Left = 10;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 19);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Movimentacao.AlterarMovimentacao(id, txtDescri.Text);
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarMovimentacoes();
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
            editar.Controls.Add(lblDescri);
            editar.Controls.Add(txtDescri);
            editar.Controls.Add(btnSalvar);
            editar.Controls.Add(btnCancelar);
            editar.ShowDialog();
    }


    public static void ExcluirMovimentacao(int id) {

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
            Controllers.Movimentacao.ExcluirMovimentacao(id);
            remove.Close();
            remove.Dispose();
            ListarMovimentacoes();          
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
            ListarMovimentacoes();
        };

        remove.Controls.Add(sim);
        remove.Controls.Add(nao);   
        remove.ShowDialog();
        }
    }
}