using Controllers;

namespace Views
{
   /* public class Usuario
    {
        public static void listarUsuario()
        {
            Form form = new Form();
            form.Text = "Lista de Usuários";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => {listarForm.Dispose();};

            ListView lista = new ListView();
            lista.Location = new System.Drawing.Point(10,10);
            lista.Size = new System.Drawing.Size(480,350);
            lista.View = System.Windows.Forms.View.Details;

            lista.Columns.Add("Id");
            lista.Columns.Add("Nome");
            lista.Columns.Add("CPF");
            lista.Columns.Add("PIS");

            foreach(Model.Usuario usuario in Model.Usuario.usuarios){
                lista.Items.Add(new ListViewItem(new string[] {usuario.id.ToString(), usuario.nome.ToString()}));
            }

            Button CadastrarUsuarioButton = new Button();
            CadastrarUsuarioButton.Text = "Incluir";
            CadastrarUsuarioButton.Top = 360;
            CadastrarUsuarioButton.Left = 10;
            CadastrarUsuarioButton.Width = 70;
            CadastrarUsuarioButton.Click += (sender, e) => {View.Usuario.addUsuario();
            
                form.Close();
                form.Dispose();            
            };

            Button AlterarUsuarioButton = new Button();
            AlterarUsuarioButton.Text = "Alterar";
            AlterarUsuarioButton.Top = 360;
            AlterarUsuarioButton.Left = 90;
            AlterarUsuarioButton.Width = 60;
            AlterarUsuarioButton.Click += (sender, e) => {View.Usuario.addUsuario();
            
                form.Close();
                form.Dispose();
            };

            Button ExcluirUsuarioButton = new Button();
            ExcluirUsuarioButton.Text = "Excluir";
            ExcluirUsuarioButton.Top = 360;
            ExcluirUsuarioButton.Left = 160;
            ExcluirUsuarioButton.Width = 60;
            ExcluirUsuarioButton.Click += (sender, e) => {View.Usuario.addUsuario();
            
                form.Close();
                form.Dispose();
            };

            Button SairUsuarioButton = new Button();
            SairUsuarioButton.Text = "Voltar";
            SairUsuarioButton.Top = 360;
            SairUsuarioButton = 230;
            SairUsuarioButton = 60;
            SairUsuarioButton.Click += (sender, e) => {View.Usuario.addUsuario();};

            form.Controller.Add(CadastrarUsuarioButton);
            form.Controller.Add(AlterarUsuarioButton);
            form.Controller.Add(ExcluirUsuarioButton);
            form.Controller.Add(SairUsuarioButton);
            form.Controller.Add(lista);
            form.Controller.Add(lista);
            form.ShowDialog();
        }

        public static void AdicionarUsuario(){

            Form form = new Form();
            form.Text = "Usuários";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => {form.Dispose();};

            Label LBLIncluirUsuario = new Label();
            LBLIncluirUsuario.Text = "Cadastrar usuários";
            LBLIncluirUsuario.Top = 10;
            LBLIncluirUsuario.Left = 200;
            LBLIncluirUsuario.Width = 300;

            Label LBLIncluirNome = new Label();
            LBLIncluirNome.Text = "Nome: ";
            LBLIncluirNome.Location = new Ponit (100, 30);
            LBLIncluirNome.AutoSize = true;
            LBLIncluirNome.Controller.Add(LBLIncluirNome);

            TextBox TextoNome = new TextBox();
            TextoNome.Top = 55;
            TextoNome.Left = 100;
            TextoNome.Width = 300;

            Label LBLIncluirCPF = new Label();
            LBLIncluirCPF.Text = "CPF";
            LBLIncluirCPF.Location = new Point (100,60);
            LBLIncluirCPF.AutoSize = true;
            LBLIncluirCPF.Controller.Add(LBLIncluirCPF);

            TextBox TextoCPF = new TextBox();
            TextoCPF.Top = 85;
            TextoCPF.Left = 130;
            TextoCPF.Width = 330;

            Label LBLIncluirPIS = new Label();
            LBLIncluirPIS.Text = "PIS";
            LBLIncluirCPF.Location = new Point (100, 90);
            LBLIncluirPIS.AutoSize = true;
            LBLIncluirPIS.Controller.Add(LBLIncluirPIS);

            TextBox TextoPIS = new TextBox();
            TextoPIS.Top = 105;
            TextoPIS.Left = 160;
            TextoPIS.Width = 360;

            Button CadastrarUsuarioButton = new Button();
            CadastrarUsuarioButton.Text = "Cadastrar";
            CadastrarUsuarioButton.Top = 360;
            CadastrarUsuarioButton.Left = 220;
            CadastrarUsuarioButton.Width = 70;
            CadastrarUsuarioButton.Click += (sender, e) => {Controller.Usuario.CadastrarUsuarioButton(new Model.Usuario(id, TextoNome.Text));
            
                form.Close();
                form.Dispose();
                View.Usuario.listarUsuario();
            };

            Button SairUsuarioButton = new Button();
            SairUsuarioButton.Text = "Voltar";
            SairUsuarioButton.Top = 360;
            SairUsuarioButton.Left = 300;
            SairUsuarioButton.Width = 60;
            SairUsuarioButton.Click += (sender, e) => {form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLIncluirUsuario);
            form.Controller.Add(LBLIncluirNome);
            form.Controller.Add(LBLIncluirCPF);
            form.Controller.Add(LBLIncluirPIS);
            form.Controller.Add(TextoNome);
            form.Controller.Add(TextoCPF);
            form.Controller.Add(TextoPIS);
            form.Controller.Add(CadastrarUsuarioButton);
            form.Controller.Add(SairUsuarioButton);
            form.ShowDialog();
        }

        public static void AlterarUsuario(){

            Form form = new Form();
            form.Text = "Usuários";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => {form.Dispose();};

            Label LBLAlterarUsuario = new Label();
            LBLAlterarUsuario.Text = "Alterar usuários";
            LBLAlterarUsuario.Top = 10;
            LBLAlterarUsuario.Left = 200;
            LBLAlterarUsuario.Width = 300;

            Label LBLAlterarId = new Label();
            LBLAlterarId.Text = "Id: ";
            LBLAlterarId.Location = new point(100,30);
            LBLAlterarId.AutoSize = true;
            form.Controller.Add(LBLAlterarId);

            TextBox TextoAlterarId = new TextBox();
            TextoAlterarId.Top = 60;
            TextoAlterarId.Left = 100;
            TextoAlterarId.Width = 300;

            Label LBLAlterarNome = new Label();
            LBLAlterarNome.Text = "Nome: ";
            LBLAlterarNome.Location = new Point(100, 90);
            LBLAlterarNome.AutoSize = true;
            form.Controller.Add(LBLAlterarNome);

            TextBox TextoAlterarNome = new TextBox();
            TextoAlterarNome.Top = 120;
            TextoAlterarNome.Left = 100;
            TextoAlterarNome.Width = 300;

            Label LBLAlterarCPF = new Label();
            LBLAlterarCPF.Text = "CPF";
            LBLAlterarCPF.Location = new Point (100,60);
            LBLAlterarCPF.AutoSize = true;
            LBLAlterarCPF.Controller.Add(LBLIncluirCPF);

            TextBox TextoAlterarCPF = new TextBox();
            TextoAlterarCPF.Top = 85;
            TextoAlterarCPF.Left = 130;
            TextoAlterarCPF.Width = 330;

            Label LBLAlterarPIS = new Label();
            LBLAlterarPIS.Text = "PIS";
            LBLAlterarCPF.Location = new Point (100, 90);
            LBLAlterarPIS.AutoSize = true;
            LBLAlterarPIS.Controller.Add(LBLIncluirPIS);

            TextBox TextoAlterarPIS = new TextBox();
            TextoAlterarPIS.Top = 105;
            TextoAlterarPIS.Left = 160;
            TextoAlterarPIS.Width = 360;

            Button AlterarUsuarioButton = new Button();
            AlterarUsuarioButton.Text = "Alterar";
            AlterarUsuarioButton.Top = 360;
            AlterarUsuarioButton.Left = 220;
            AlterarUsuarioButton.Width = 70;
            AlterarUsuarioButton.Click += (sender, e) => {Controller.Usuario.AlterarUsuario(new Model.Usuario(TextoAlterarNome,int.Parse(TextoAlterarCPF), int.Parse(TextoAlterarPIS)));
                
                form.Close();
                form.Dispose();
                View.Usuario.listarUsuario();
            };

            Button SairUsuarioButton = new Button();
            SairUsuarioButton.Text = "Voltar";
            SairUsuarioButton.Top = 360;
            SairUsuarioButton.Left = 300;
            SairUsuarioButton.Width = 60;
            SairUsuarioButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLAlterarUsuario);
            form.Controller.Add(LBLAlterarId);
            form.Controller.Add(LBLAlterarNome);
            form.Controller.Add(LBLAlterarCPF);
            form.Controller.Add(LBLAlterarPIS);
            form.Controller.Add(TextoAlterarId);
            form.Controller.Add(TextoAlterarNome);
            form.Controller.Addo(TextoAlterarCPF);
            form.Controller.Add(TextoAlterarPIS);
            form.Controller.Add(AlterarUsuarioButton);
            form.Controller.Add(SairUsuarioButton);
            form.ShowDialog();
        }

        public static void ExcluirUsuario(){

            Form form = new Form();
            form.Text = "Usuários";
            form.Width = 500;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.FormClosed += (sender, e) => {form.Dispose();};
        
            Label LBLExcuir = new Label();
            LBLExcuir.Text = "Excluir Usuário";
            LBLExcuir.Top = 10;
            LBLExcuir.Left = 200;
            LBLExcuir.Width = 300;

            Label LBLExcluirId = new Label();
            LBLExcluirId.Text = "Id:";
            LBLExcluirId.Location = new Point(100, 30);
            LBLExcluirId.AutoSize = true;
            form.Controls.Add(LBLExcluirId);

            TextBox TextoExcluirId = new TextBox();
            TextoExcluirId.Top = 60;
            TextoExcluirId.Left = 100;
            TextoExcluirId.Width = 300;

            Button ExcluirUsuarioButton = new Button();
            ExcluirUsuarioButton.Text = "Excluir";
            ExcluirUsuarioButton.Top = 360;
            ExcluirUsuarioButton.Left = 220;
            ExcluirUsuarioButton.Width = 60;
            ExcluirUsuarioButton.Click += (sender, e) => { 
                Controllers.Usuario.excluirUsuarios (int.Parse(TextoExcluirId.Text));
                form.Close(); 
                form.Dispose();
                Views.Usuario.listarUsuario();
                };

            Button SairUsuarioButton = new Button();
            SairUsuarioButton.Text = "Voltar";
            SairUsuarioButton.Top = 360;
            SairUsuarioButton.Left = 300;
            SairUsuarioButton.Width = 60;
            SairUsuarioButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLExcuir);
            form.Controller.Add(LBLExcluirId);
            form.Controller.Add(TextoExcluirId);
            form.Controller.Add(ExcluirUsuarioButton);
            form.Controller.Add(SairUsuarioButton);
            form.ShowDialog();
        }
    }*/
}