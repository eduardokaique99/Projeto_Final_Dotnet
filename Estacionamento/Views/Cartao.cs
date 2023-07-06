using System;
using System.Windows.Forms;

namespace Views {
    
    public class Cartao {
        
        public static void ListarCartao() {
            Form tipos = new Form();
            tipos.Text = "Cartao";
            tipos.Size = new System.Drawing.Size(700, 500);
            tipos.StartPosition = FormStartPosition.CenterScreen;
            tipos.FormBorderStyle = FormBorderStyle.FixedSingle;
            tipos.MaximizeBox = false;
            tipos.MinimizeBox = false;
            tipos.BackColor = Color.BlueViolet;

            ListView listaTipo = new ListView();
            listaTipo.Size = new System.Drawing.Size(665, 400);
            listaTipo.Location = new System.Drawing.Point(10, 10);
            listaTipo.View = View.Details;
            listaTipo.Columns.Add("Id", 50);
            listaTipo.Columns.Add("Código", 100);
            listaTipo.FullRowSelect = true;
            listaTipo.GridLines = true;

            List<Models.Cartao> cartaoList = Controllers.Cartao.ListaCartao();
            foreach (Models.Cartao cartao in cartaoList) {
                ListViewItem item = new ListViewItem(cartao.Id.ToString());
                item.SubItems.Add(cartao.Codigo);
                listaTipo.Items.Add(item);
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
                tipos.Close();
                tipos.Dispose();
                CriarCartao();
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
                string id = listaTipo.SelectedItems[0].Text;
                tipos.Close();
                tipos.Dispose();
                AlterarCartao(Int32.Parse(id));
                tipos.Close();
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
                string id = listaTipo.SelectedItems[0].Text;
                ExcluirCartao(Int32.Parse(id));
                tipos.Dispose();
                tipos.Close();
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
                tipos.Hide();
                tipos.Close();
                tipos.Dispose();
            };

            tipos.Controls.Add(listaTipo);
            tipos.Controls.Add(btnAdicionar);
            tipos.Controls.Add(btnEdit);
            tipos.Controls.Add(BtnRemove);
            tipos.Controls.Add(BtnVoltar);
            tipos.ShowDialog();
        } 

          public static void CriarCartao() {
            Form adicionarTipo = new Form();
            adicionarTipo.Text = "Adicionar Cartao";
            adicionarTipo.Size = new System.Drawing.Size(400, 250);
            adicionarTipo.StartPosition = FormStartPosition.CenterScreen;
            adicionarTipo.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarTipo.MaximizeBox = false;
            adicionarTipo.MinimizeBox = false;
            adicionarTipo.BackColor = Color.BlueViolet;

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
            lblDescri.Text = "Código:";
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
                    Controllers.Cartao.CriarCartao(int.Parse(txtId.Text), txtDescri.Text);
                    adicionarTipo.Hide();
                    adicionarTipo.Close();
                    adicionarTipo.Dispose();
                    ListarCartao();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar Cartao: {err.Message}");
                }
                finally 
                {
                    adicionarTipo.Hide();
                    adicionarTipo.Close();
                    adicionarTipo.Dispose();
                    ListarCartao();                    
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
                adicionarTipo.Close();
            };

            adicionarTipo.Controls.Add(lblId);
            adicionarTipo.Controls.Add(txtId);
            adicionarTipo.Controls.Add(lblDescri);
            adicionarTipo.Controls.Add(txtDescri);
            adicionarTipo.Controls.Add(btnSalvar);
            adicionarTipo.Controls.Add(btnCancelar);
            adicionarTipo.ShowDialog();
        }


        public static void AlterarCartao(int id) {
            Models.Cartao cartao = Controllers.Cartao.BuscarCartao(id);
            Form editar = new Form();
            editar.Text = "Editar Cartao";
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
            txtId.Text = cartao.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblDescri = new Label();
            lblDescri.Text = "Código:";
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
            txtDescri.Text = cartao.Codigo;

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 127;
            btnSalvar.Left = 10;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 19);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Cartao.AlterarCartao(id, txtDescri.Text);
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarCartao();
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


    public static void ExcluirCartao(int id) {

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
            Controllers.Cartao.ExcluirCartao(id);
            remove.Close();
            remove.Dispose();
            ListarCartao();          
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
            ListarCartao();
        };

        remove.Controls.Add(sim);
        remove.Controls.Add(nao);   
        remove.ShowDialog();
        }
    }
}