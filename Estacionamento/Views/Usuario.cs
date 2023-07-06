using System;
using System.Windows.Forms;

namespace Views {
    
    public class Usuario {
        
        public static void ListarUsuario() {
            Form tipos = new Form();
            tipos.Text = "Usuario";
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
            listaTipo.Columns.Add("Id:", 50);
            listaTipo.Columns.Add("Nome:", 150);
            listaTipo.Columns.Add("CPF:", 150);
            listaTipo.Columns.Add("PIS:", 150);
            listaTipo.FullRowSelect = true;
            listaTipo.GridLines = true;

            List<Models.Usuario> usuarioList = Models.Usuario.BuscarTodos();
            foreach (Models.Usuario usuario in usuarioList) {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Nome);
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
                CriarUsuario();
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
                AlterarUsuario(Int32.Parse(id));
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
                ExcluirUsuario(Int32.Parse(id));
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

          public static void CriarUsuario() {
            Form adicionarTipo = new Form();
            adicionarTipo.Text = "Adicionar Usuario";
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
            lblDescri.Text = "Nome:";
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

            Label lblCPF = new Label();
            lblCPF.Text = "CPF:";
            lblCPF.Top = 60;
            lblCPF.Left = 10;
            lblCPF.ForeColor = Color.White;
            lblCPF.Font = new Font(lblCPF.Font.FontFamily, 19);
            lblCPF.Size = new System.Drawing.Size(130, 35);

            TextBox txtCPF = new TextBox();
            txtCPF.Top = 67;
            txtCPF.Left = 140;
            txtCPF.BackColor = Color.LightGray;
            txtCPF.Size = new System.Drawing.Size(230, 35);
            
            Label lblPIS = new Label();
            lblPIS.Text = "PIS:";
            lblPIS.Top = 60;
            lblPIS.Left = 10;
            lblPIS.ForeColor = Color.White;
            lblPIS.Font = new Font(lblPIS.Font.FontFamily, 19);
            lblPIS.Size = new System.Drawing.Size(130, 35);

            TextBox txtPIS = new TextBox();
            txtPIS.Top = 67;
            txtPIS.Left = 140;
            txtPIS.BackColor = Color.LightGray;
            txtPIS.Size = new System.Drawing.Size(230, 35);

            Label lblPermissao = new Label();
            lblPermissao.Text = "Permissão:";
            lblPermissao.Top = 60;
            lblPermissao.Left = 10;
            lblPermissao.ForeColor = Color.White;
            lblPermissao.Font = new Font(lblPermissao.Font.FontFamily, 19);
            lblPermissao.Size = new System.Drawing.Size(130, 35);

            TextBox txtPermissao = new TextBox();
            txtPermissao.Top = 67;
            txtPermissao.Left = 140;
            txtPermissao.BackColor = Color.LightGray;
            txtPermissao.Size = new System.Drawing.Size(230, 35);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha:";
            lblSenha.Top = 60;
            lblSenha.Left = 10;
            lblSenha.ForeColor = Color.White;
            lblSenha.Font = new Font(lblSenha.Font.FontFamily, 19);
            lblSenha.Size = new System.Drawing.Size(130, 35);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 67;
            txtSenha.Left = 140;
            txtSenha.BackColor = Color.LightGray;
            txtSenha.Size = new System.Drawing.Size(230, 35);

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
                    Controllers.Usuario.CriarUsuario(int.Parse(txtId.Text), txtDescri.Text, int.Parse(txtCPF.Text), int.Parse(txtPIS.Text), txtPermissao.Text, txtSenha.Text);
                    adicionarTipo.Hide();
                    adicionarTipo.Close();
                    adicionarTipo.Dispose();
                    ListarUsuario();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar usuario: {err.Message}");
                }
                finally 
                {
                    adicionarTipo.Hide();
                    adicionarTipo.Close();
                    adicionarTipo.Dispose();
                    ListarUsuario();                    
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
            adicionarTipo.Controls.Add(lblCPF);
            adicionarTipo.Controls.Add(txtCPF);
            adicionarTipo.Controls.Add(lblPIS);
            adicionarTipo.Controls.Add(txtPIS);
            adicionarTipo.Controls.Add(lblPermissao);
            adicionarTipo.Controls.Add(txtPermissao);
            adicionarTipo.Controls.Add(lblSenha);
            adicionarTipo.Controls.Add(txtSenha);
            adicionarTipo.Controls.Add(btnSalvar);
            adicionarTipo.Controls.Add(btnCancelar);
            adicionarTipo.ShowDialog();
        }


        public static void AlterarUsuario(int id) {
            Models.Usuario usuario = Controllers.Usuario.BuscarUsuario(id);
            Form editar = new Form();
            editar.Text = "Editar usuario";
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
            txtId.Text = usuario.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblDescri = new Label();
            lblDescri.Text = "Nome:";
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

            Label lblCPF = new Label();
            lblCPF.Text = "CPF:";
            lblCPF.Top = 60;
            lblCPF.Left = 10;
            lblCPF.ForeColor = Color.White;
            lblCPF.Font = new Font(lblCPF.Font.FontFamily, 19);
            lblCPF.Size = new System.Drawing.Size(130, 35);

            TextBox txtCPF = new TextBox();
            txtCPF.Top = 67;
            txtCPF.Left = 140;
            txtCPF.BackColor = Color.LightGray;
            txtCPF.Size = new System.Drawing.Size(230, 35);
            
            Label lblPIS = new Label();
            lblPIS.Text = "PIS:";
            lblPIS.Top = 60;
            lblPIS.Left = 10;
            lblPIS.ForeColor = Color.White;
            lblPIS.Font = new Font(lblPIS.Font.FontFamily, 19);
            lblPIS.Size = new System.Drawing.Size(130, 35);

            TextBox txtPIS = new TextBox();
            txtPIS.Top = 67;
            txtPIS.Left = 140;
            txtPIS.BackColor = Color.LightGray;
            txtPIS.Size = new System.Drawing.Size(230, 35);

            Label lblPermissao = new Label();
            lblPermissao.Text = "Permissão:";
            lblPermissao.Top = 60;
            lblPermissao.Left = 10;
            lblPermissao.ForeColor = Color.White;
            lblPermissao.Font = new Font(lblPermissao.Font.FontFamily, 19);
            lblPermissao.Size = new System.Drawing.Size(130, 35);

            TextBox txtPermissao = new TextBox();
            txtPermissao.Top = 67;
            txtPermissao.Left = 140;
            txtPermissao.BackColor = Color.LightGray;
            txtPermissao.Size = new System.Drawing.Size(230, 35);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha:";
            lblSenha.Top = 60;
            lblSenha.Left = 10;
            lblSenha.ForeColor = Color.White;
            lblSenha.Font = new Font(lblSenha.Font.FontFamily, 19);
            lblSenha.Size = new System.Drawing.Size(130, 35);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 67;
            txtSenha.Left = 140;
            txtSenha.BackColor = Color.LightGray;
            txtSenha.Size = new System.Drawing.Size(230, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 127;
            btnSalvar.Left = 10;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 19);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Usuario.AlterarUsuario(int.Parse(txtId.Text), txtDescri.Text, int.Parse(txtCPF.Text), int.Parse(txtPIS.Text), txtPermissao.Text, txtSenha.Text);
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarUsuario();
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