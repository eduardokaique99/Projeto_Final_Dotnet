using System;
using System.Windows.Forms;

namespace Views {
    
    public class Cartao {
        
        public static void ListarCartao() {
            Form cards = new Form();
            cards.Text = "Cartao";
            cards.Size = new System.Drawing.Size(700, 500);
            cards.StartPosition = FormStartPosition.CenterScreen;
            cards.FormBorderStyle = FormBorderStyle.FixedSingle;
            cards.MaximizeBox = false;
            cards.MinimizeBox = false;
            cards.BackColor = Color.BlueViolet;

            ListView listaCartao = new ListView();
            listaCartao.Size = new System.Drawing.Size(665, 400);
            listaCartao.Location = new System.Drawing.Point(10, 10);
            listaCartao.View = View.Details;
            listaCartao.Columns.Add("Id", 50);
            listaCartao.Columns.Add("Código", 611);
            listaCartao.FullRowSelect = true;
            listaCartao.GridLines = true;

            List<Models.Cartao> cartaoList = (List<Models.Cartao>)Controllers.Cartao.BuscarCartaos();
            foreach (Models.Cartao cartao in cartaoList) {
                ListViewItem item = new ListViewItem(cartao.Id.ToString());
                item.SubItems.Add(cartao.Codigo);
                listaCartao.Items.Add(item);
            }

            Button btnAdicionar = new Button();
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Top = 420;
            btnAdicionar.Left = 10;
            btnAdicionar.Font = new Font(btnAdicionar.Font.FontFamily, 18);
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.ForeColor = Color.BlueViolet;
            btnAdicionar.Size = new System.Drawing.Size(150, 35);
            btnAdicionar.Click += (sender, e) => {
                cards.Close();
                cards.Dispose();
                CriarCartao();
            };
            
            
            Button btnEdit = new Button();
            btnEdit.Text = "Editar";
            btnEdit.Top = 420;
            btnEdit.Left = 181;
            btnEdit.Font = new Font(btnEdit.Font.FontFamily, 18);
            btnEdit.BackColor = Color.White;
            btnEdit.ForeColor = Color.BlueViolet;
            btnEdit.Size = new System.Drawing.Size(150, 35);
            btnEdit.Click += (sender, e) => {
                string id = listaCartao.SelectedItems[0].Text;
                cards.Close();
                cards.Dispose();
                AlterarCartao(Int32.Parse(id));
                cards.Close();
            };


            Button BtnRemove = new Button();
            BtnRemove.Text = "Remove";
            BtnRemove.Top = 420;
            BtnRemove.Left = 352;
            BtnRemove.Font = new Font(BtnRemove.Font.FontFamily, 18);
            BtnRemove.BackColor = Color.White;
            BtnRemove.ForeColor = Color.BlueViolet;
            BtnRemove.Size = new System.Drawing.Size(150, 35);
            BtnRemove.Click += (sender, e) => {
                string id = listaCartao.SelectedItems[0].Text;
                ExcluirCartao(Int32.Parse(id));
                cards.Dispose();
                cards.Close();
            };

            Button BtnVoltar = new Button();
            BtnVoltar.Text = "Voltar";
            BtnVoltar.Top = 420;
            BtnVoltar.Left = 523;
            BtnVoltar.Font = new Font(BtnVoltar.Font.FontFamily, 18);
            BtnVoltar.BackColor = Color.White;
            BtnVoltar.ForeColor = Color.BlueViolet;
            BtnVoltar.Size = new System.Drawing.Size(150, 35);
            BtnVoltar.Click += (sender, e) => {
                cards.Hide();
                cards.Close();
                cards.Dispose();
            };

            cards.Controls.Add(listaCartao);
            cards.Controls.Add(btnAdicionar);
            cards.Controls.Add(btnEdit);
            cards.Controls.Add(BtnRemove);
            cards.Controls.Add(BtnVoltar);
            cards.ShowDialog();
        } 

          public static void CriarCartao() {
            Form adicionarCartao = new Form();
            adicionarCartao.Text = "Adicionar Cartao";
            adicionarCartao.Size = new System.Drawing.Size(600, 450);
            adicionarCartao.StartPosition = FormStartPosition.CenterScreen;
            adicionarCartao.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarCartao.MaximizeBox = false;
            adicionarCartao.MinimizeBox = false;
            adicionarCartao.BackColor = Color.BlueViolet;

            Label lblId= new Label();
            lblId.Text = "Id:";
            lblId.Top = 25;
            lblId.Left = 10;
            lblId.ForeColor = Color.White;
            lblId.Font = new Font(lblId.Font.FontFamily, 18);
            lblId.Size = new System.Drawing.Size(130, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 25;
            txtId.Left = 270;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(230, 35);


            Label lblCodigo = new Label();
            lblCodigo.Text = "Código:";
            lblCodigo.Top = 70;
            lblCodigo.Left = 10;
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Font = new Font(lblCodigo.Font.FontFamily, 18);
            lblCodigo.Size = new System.Drawing.Size(130, 35);

            TextBox txtCodigo = new TextBox();
            txtCodigo.Top = 70;
            txtCodigo.Left = 270;
            txtCodigo.BackColor = Color.LightGray;
            txtCodigo.Size = new System.Drawing.Size(230, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 330;
            btnSalvar.Left = 70;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 18);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                try
                {
                    Controllers.Cartao.CriarCartao(int.Parse(txtId.Text), txtCodigo.Text);
                    adicionarCartao.Hide();
                    adicionarCartao.Close();
                    adicionarCartao.Dispose();
                    ListarCartao();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar Cartao: {err.Message}");
                }
                finally 
                {
                    adicionarCartao.Hide();
                    adicionarCartao.Close();
                    adicionarCartao.Dispose();
                    ListarCartao();                    
                }
                               
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Top = 330;
            btnCancelar.Left = 360;
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.BlueViolet;
            btnCancelar.Font = new Font(btnCancelar.Font.FontFamily, 18);
            btnCancelar.Size = new System.Drawing.Size(150, 35);
            btnCancelar.Click += (sender, e) => {
                adicionarCartao.Close();
            };

            adicionarCartao.Controls.Add(lblId);
            adicionarCartao.Controls.Add(txtId);
            adicionarCartao.Controls.Add(lblCodigo);
            adicionarCartao.Controls.Add(txtCodigo);
            adicionarCartao.Controls.Add(btnSalvar);
            adicionarCartao.Controls.Add(btnCancelar);
            adicionarCartao.ShowDialog();
        }


        public static void AlterarCartao(int id) {
            Models.Cartao cartao = Controllers.Cartao.BuscarCartao(id);
            Form editar = new Form();
            editar.Text = "Editar Cartao";
            editar.Size = new System.Drawing.Size(600, 450);
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
            lblId.Font = new Font(lblId.Font.FontFamily, 18);
            lblId.Size = new System.Drawing.Size(130, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 32;
            txtId.Left = 140;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(230, 35);
            txtId.Text = cartao.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblCodigo = new Label();
            lblCodigo.Text = "Código:";
            lblCodigo.Top = 60;
            lblCodigo.Left = 10;
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Font = new Font(lblCodigo.Font.FontFamily, 18);
            lblCodigo.Size = new System.Drawing.Size(130, 35);

            TextBox txtCodigo = new TextBox();
            txtCodigo.Top = 67;
            txtCodigo.Left = 140;
            txtCodigo.BackColor = Color.LightGray;
            txtCodigo.Size = new System.Drawing.Size(230, 35);
            txtCodigo.Text = cartao.Codigo;

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 330;
            btnSalvar.Left = 70;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 18);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Cartao.AlterarCartao(id, txtCodigo.Text);
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarCartao();
            };

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Top = 330;
            btnCancelar.Left = 360;
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.BlueViolet;
            btnCancelar.Font = new Font(btnCancelar.Font.FontFamily, 18);
            btnCancelar.Size = new System.Drawing.Size(150, 35);
            btnCancelar.Click += (sender, e) => {
                editar.Close();
                editar.Dispose();
            };

            editar.Controls.Add(lblId);
            editar.Controls.Add(txtId);
            editar.Controls.Add(lblCodigo);
            editar.Controls.Add(txtCodigo);
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