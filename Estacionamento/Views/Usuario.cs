using System;
using System.Windows.Forms;

namespace Views {
    
    public class Usuario {
        
        public static void ListarUsuario() {
            Form users = new Form();
            users.Text = "Usuario";
            users.Size = new System.Drawing.Size(700, 500);
            users.StartPosition = FormStartPosition.CenterScreen;
            users.FormBorderStyle = FormBorderStyle.FixedSingle;
            users.MaximizeBox = false;
            users.MinimizeBox = false;
            users.BackColor = Color.BlueViolet;

            ListView listaUsers = new ListView();
            listaUsers.Size = new System.Drawing.Size(665, 400);
            listaUsers.Location = new System.Drawing.Point(10, 10);
            listaUsers.View = View.Details;
            listaUsers.Columns.Add("Id:", 100);
            listaUsers.Columns.Add("Nome:", 220);
            listaUsers.Columns.Add("CPF:", 120);
            listaUsers.Columns.Add("PIS:", 120);
            listaUsers.Columns.Add("Permissão:", 100);
            listaUsers.FullRowSelect = true;
            listaUsers.GridLines = true;

            List<Models.Usuario> usuarioList = Models.Usuario.BuscarTodos();
            foreach (Models.Usuario usuario in usuarioList) {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.CPF.ToString());
                item.SubItems.Add(usuario.PIS.ToString());
                item.SubItems.Add(usuario.Permissao);
                listaUsers.Items.Add(item);
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
                users.Close();
                users.Dispose();
                CriarUsuario();
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
                string id = listaUsers.SelectedItems[0].Text;
                users.Close();
                users.Dispose();
                AlterarUsuario(Int32.Parse(id));
                users.Close();
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
                string id = listaUsers.SelectedItems[0].Text;
                ExcluirUsuario(Int32.Parse(id));
                users.Dispose();
                users.Close();
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
                users.Hide();
                users.Close();
                users.Dispose();
            };

            users.Controls.Add(listaUsers);
            users.Controls.Add(btnAdicionar);
            users.Controls.Add(btnEdit);
            users.Controls.Add(BtnRemove);
            users.Controls.Add(BtnVoltar);
            users.ShowDialog();
        } 

          public static void CriarUsuario() {
            Form adicionarUsers = new Form();
            adicionarUsers.Text = "Adicionar Usuario";
            adicionarUsers.Size = new System.Drawing.Size(600, 450);
            adicionarUsers.StartPosition = FormStartPosition.CenterScreen;
            adicionarUsers.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarUsers.MaximizeBox = false;
            adicionarUsers.MinimizeBox = false;
            adicionarUsers.BackColor = Color.BlueViolet;

            Label lblId= new Label();
            lblId.Text = "Id:";
            lblId.Top = 25;
            lblId.Left = 10;
            lblId.ForeColor = Color.White;
            lblId.Font = new Font(lblId.Font.FontFamily, 18);
            lblId.Size = new System.Drawing.Size(250, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 32;
            txtId.Left = 270;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(300, 35);


            Label lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Top = 70;
            lblNome.Left = 10;
            lblNome.ForeColor = Color.White;
            lblNome.Font = new Font(lblNome.Font.FontFamily, 18);
            lblNome.Size = new System.Drawing.Size(250, 35);

            TextBox txtNome = new TextBox();
            txtNome.Top = 77;
            txtNome.Left = 270;
            txtNome.BackColor = Color.LightGray;
            txtNome.Size = new System.Drawing.Size(300, 35);

            Label lblCPF = new Label();
            lblCPF.Text = "CPF:";
            lblCPF.Top = 115;
            lblCPF.Left = 10;
            lblCPF.ForeColor = Color.White;
            lblCPF.Font = new Font(lblCPF.Font.FontFamily, 18);
            lblCPF.Size = new System.Drawing.Size(250, 35);

            TextBox txtCPF = new TextBox();
            txtCPF.Top = 122;
            txtCPF.Left = 270;
            txtCPF.BackColor = Color.LightGray;
            txtCPF.Size = new System.Drawing.Size(300, 35);
            
            Label lblPIS = new Label();
            lblPIS.Text = "PIS:";
            lblPIS.Top = 160;
            lblPIS.Left = 10;
            lblPIS.ForeColor = Color.White;
            lblPIS.Font = new Font(lblPIS.Font.FontFamily, 18);
            lblPIS.Size = new System.Drawing.Size(250, 35);

            TextBox txtPIS = new TextBox();
            txtPIS.Top = 167;
            txtPIS.Left = 270;
            txtPIS.BackColor = Color.LightGray;
            txtPIS.Size = new System.Drawing.Size(300, 35);

            Label lblPermissao = new Label();
            lblPermissao.Text = "Permissão:";
            lblPermissao.Top = 205;
            lblPermissao.Left = 10;
            lblPermissao.ForeColor = Color.White;
            lblPermissao.Font = new Font(lblPermissao.Font.FontFamily, 18);
            lblPermissao.Size = new System.Drawing.Size(250, 35);

            TextBox txtPermissao = new TextBox();
            txtPermissao.Top = 212;
            txtPermissao.Left = 270;
            txtPermissao.BackColor = Color.LightGray;
            txtPermissao.Size = new System.Drawing.Size(300, 35);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha:";
            lblSenha.Top = 250;
            lblSenha.Left = 10;
            lblSenha.ForeColor = Color.White;
            lblSenha.Font = new Font(lblSenha.Font.FontFamily, 18);
            lblSenha.Size = new System.Drawing.Size(250, 35);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 257;
            txtSenha.Left = 270;
            txtSenha.BackColor = Color.LightGray;
            txtSenha.Size = new System.Drawing.Size(300, 35);

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
                    Controllers.Usuario.CriarUsuario(int.Parse(txtId.Text), txtNome.Text, int.Parse(txtCPF.Text), int.Parse(txtPIS.Text), txtPermissao.Text, txtSenha.Text);
                    adicionarUsers.Hide();
                    adicionarUsers.Close();
                    adicionarUsers.Dispose();
                    ListarUsuario();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar usuario: {err.Message}");
                }
                finally 
                {
                    adicionarUsers.Hide();
                    adicionarUsers.Close();
                    adicionarUsers.Dispose();
                    ListarUsuario();                    
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
                adicionarUsers.Close();
            };

            adicionarUsers.Controls.Add(lblId);
            adicionarUsers.Controls.Add(txtId);
            adicionarUsers.Controls.Add(lblNome);
            adicionarUsers.Controls.Add(txtNome);
            adicionarUsers.Controls.Add(lblCPF);
            adicionarUsers.Controls.Add(txtCPF);
            adicionarUsers.Controls.Add(lblPIS);
            adicionarUsers.Controls.Add(txtPIS);
            adicionarUsers.Controls.Add(lblPermissao);
            adicionarUsers.Controls.Add(txtPermissao);
            adicionarUsers.Controls.Add(lblSenha);
            adicionarUsers.Controls.Add(txtSenha);
            adicionarUsers.Controls.Add(btnSalvar);
            adicionarUsers.Controls.Add(btnCancelar);
            adicionarUsers.ShowDialog();
        }


        public static void AlterarUsuario(int id) {
            Models.Usuario usuario = Controllers.Usuario.BuscarUsuario(id);
            Form editar = new Form();
            editar.Text = "Editar usuario";
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
            lblId.Size = new System.Drawing.Size(250, 35);

            TextBox txtId = new TextBox();
            txtId.Top = 32;
            txtId.Left = 270;
            txtId.BackColor = Color.LightGray;
            txtId.Size = new System.Drawing.Size(300, 35);
            txtId.Text = usuario.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Top = 70;
            lblNome.Left = 10;
            lblNome.ForeColor = Color.White;
            lblNome.Font = new Font(lblNome.Font.FontFamily, 18);
            lblNome.Size = new System.Drawing.Size(250, 35);

            TextBox txtNome = new TextBox();
            txtNome.Top = 77;
            txtNome.Left = 270;
            txtNome.BackColor = Color.LightGray;
            txtNome.Size = new System.Drawing.Size(300, 35);

            Label lblCPF = new Label();
            lblCPF.Text = "CPF:";
            lblCPF.Top = 115;
            lblCPF.Left = 10;
            lblCPF.ForeColor = Color.White;
            lblCPF.Font = new Font(lblCPF.Font.FontFamily, 18);
            lblCPF.Size = new System.Drawing.Size(250, 35);

            TextBox txtCPF = new TextBox();
            txtCPF.Top = 122;
            txtCPF.Left = 270;
            txtCPF.BackColor = Color.LightGray;
            txtCPF.Size = new System.Drawing.Size(300, 35);
            
            Label lblPIS = new Label();
            lblPIS.Text = "PIS:";
            lblPIS.Top = 160;
            lblPIS.Left = 10;
            lblPIS.ForeColor = Color.White;
            lblPIS.Font = new Font(lblPIS.Font.FontFamily, 18);
            lblPIS.Size = new System.Drawing.Size(250, 35);

            TextBox txtPIS = new TextBox();
            txtPIS.Top = 167;
            txtPIS.Left = 270;
            txtPIS.BackColor = Color.LightGray;
            txtPIS.Size = new System.Drawing.Size(300, 35);

            Label lblPermissao = new Label();
            lblPermissao.Text = "Permissão:";
            lblPermissao.Top = 205;
            lblPermissao.Left = 10;
            lblPermissao.ForeColor = Color.White;
            lblPermissao.Font = new Font(lblPermissao.Font.FontFamily, 18);
            lblPermissao.Size = new System.Drawing.Size(250, 35);

            TextBox txtPermissao = new TextBox();
            txtPermissao.Top = 212;
            txtPermissao.Left = 270;
            txtPermissao.BackColor = Color.LightGray;
            txtPermissao.Size = new System.Drawing.Size(300, 35);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha:";
            lblSenha.Top = 250;
            lblSenha.Left = 10;
            lblSenha.ForeColor = Color.White;
            lblSenha.Font = new Font(lblSenha.Font.FontFamily, 18);
            lblSenha.Size = new System.Drawing.Size(250, 35);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 257;
            txtSenha.Left = 270;
            txtSenha.BackColor = Color.LightGray;
            txtSenha.Size = new System.Drawing.Size(300, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 330;
            btnSalvar.Left = 70;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 18);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Usuario.AlterarUsuario(int.Parse(txtId.Text), txtNome.Text, int.Parse(txtCPF.Text), int.Parse(txtPIS.Text), txtPermissao.Text, txtSenha.Text);
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarUsuario();
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
            editar.Controls.Add(lblNome);
            editar.Controls.Add(txtNome);
            editar.Controls.Add(lblCPF);
            editar.Controls.Add(txtCPF);
            editar.Controls.Add(lblPIS);
            editar.Controls.Add(txtPIS);
            editar.Controls.Add(lblPermissao);
            editar.Controls.Add(txtPermissao);
            editar.Controls.Add(lblSenha);
            editar.Controls.Add(txtSenha);
            editar.Controls.Add(btnSalvar);
            editar.Controls.Add(btnCancelar);
            editar.ShowDialog();
    }


    public static void ExcluirUsuario(int id) {

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
            Controllers.Usuario.ExcluirUsuario(id);
            remove.Close();
            remove.Dispose();
            ListarUsuario();          
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
            ListarUsuario();
        };

        remove.Controls.Add(sim);
        remove.Controls.Add(nao);   
        remove.ShowDialog();
        }
    }
}