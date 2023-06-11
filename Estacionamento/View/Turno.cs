using Controller;

namespace View
{
    public class Turno
    {
        public static void listarTurno()
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
            lista.Columns.Add("Período");
            lista.Columns.Add("Escala");

            foreach(Model.Turno turno in Model.Turno.turnos){
                lista.Items.Add(new ListViewItem(new string[] {turno.id.ToString(), turno.nome.ToString()}));
            }

            Button CadastrarTurnoButton = new Button();
            CadastrarTurnoButton.Text = "Incluir";
            CadastrarTurnoButton.Top = 360;
            CadastrarTurnoButton.Left = 10;
            CadastrarTurnoButton.Width = 70;
            CadastrarTurnoButton.Click += (sender, e) => {View.Turno.addTurno();
            
                form.Close();
                form.Dispose();            
            };

            Button AlterarTurnoButton = new Button();
            AlterarTurnoButton.Text = "Alterar";
            AlterarTurnoButton.Top = 360;
            AlterarTurnoButton.Left = 90;
            AlterarTurnoButton.Width = 60;
            AlterarTurnoButton.Click += (sender, e) => {View.Turno.addTurno();
            
                form.Close();
                form.Dispose();
            };

            Button ExcluirTurnoButton = new Button();
            ExcluirTurnoButton.Text = "Excluir";
            ExcluirTurnoButton.Top = 360;
            ExcluirTurnoButton.Left = 160;
            ExcluirTurnoButton.Width = 60;
            ExcluirTurnoButton.Click += (sender, e) => {View.Turno.addTurno();
            
                form.Close();
                form.Dispose();
            };

            Button SairTurnoButton = new Button();
            SairTurnoButton.Text = "Voltar";
            SairTurnoButton.Top = 360;
            SairTurnoButton = 230;
            SairTurnoButton = 60;
            SairTurnoButton.Click += (sender, e) => {View.Turno.addTurno();};

            form.Controller.Add(CadastrarTurnoButton);
            form.Controller.Add(AlterarTurnoButton);
            form.Controller.Add(ExcluirTurnoButton);
            form.Controller.Add(SairTurnoButton);
            form.Controller.Add(lista);
            form.Controller.Add(lista);
            form.ShowDialog();
        }

        public static void AdicionarTurno(){

            Form form = new Form();
            form.Text = "Turnos";
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

            Label LBLIncluirTurno = new Label();
            LBLIncluirTurno.Text = "Cadastrar turno";
            LBLIncluirTurno.Top = 10;
            LBLIncluirTurno.Left = 200;
            LBLIncluirTurno.Width = 300;

            Label LBLIncluirPeriodo = new Label();
            LBLIncluirPeriodo.Text = "Período: ";
            LBLIncluirPeriodo.Location = new Ponit (100, 30);
            LBLIncluirPeriodo.AutoSize = true;
            LBLIncluirPeriodo.Controller.Add(LBLIncluirPeriodo);

            TextBox TextoPeriodo = new TextBox();
            TextoPeriodo.Top = 55;
            TextoPeriodo.Left = 100;
            TextoPeriodo.Width = 300;

            Label LBLIncluirEscala = new Label();
            LBLIncluirEscala.Text = "Escala: ";
            LBLIncluirEscala.Location = new Point (100,60);
            LBLIncluirEscala.AutoSize = true;
            LBLIncluirEscala.Controller.Add(LBLIncluirEscala);

            TextBox TextoEscala = new TextBox();
            TextoEscala.Top = 85;
            TextoEscala.Left = 130;
            TextoEscala.Width = 330;

            Button CadastrarTurnoButton = new Button();
            CadastrarTurnoButton.Text = "Cadastrar";
            CadastrarTurnoButton.Top = 360;
            CadastrarTurnoButton.Left = 220;
            CadastrarTurnoButton.Width = 70;
            CadastrarTurnoButton.Click += (sender, e) => {Controller.Turno.CadastrarTurnoButton(new Model.Turno(id, TextoNome.Text));
            
                form.Close();
                form.Dispose();
                View.Turno.listarTurno();
            };

            Button SairTurnoButton = new Button();
            SairTurnoButton.Text = "Voltar";
            SairTurnoButton.Top = 360;
            SairTurnoButton.Left = 300;
            SairTurnoButton.Width = 60;
            SairTurnoButton.Click += (sender, e) => {form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLIncluirTurno);
            form.Controller.Add(LBLIncluirPeriodo);
            form.Controller.Add(LBLIncluirEscala);
            form.Controller.Add(TextoPeriodo);
            form.Controller.Add(TextoEscala);
            form.Controller.Add(CadastrarTurnoButton);
            form.Controller.Add(SairTurnoButton);
            form.ShowDialog();
        }

        public static void AlterarTurno(){

            Form form = new Form();
            form.Text = "Turnos";
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

            Label LBLAlterarTurno = new Label();
            LBLAlterarTurno.Text = "Alterar turno";
            LBLAlterarTurno.Top = 10;
            LBLAlterarTurno.Left = 200;
            LBLAlterarTurno.Width = 300;

            Label LBLAlterarId = new Label();
            LBLAlterarId.Text = "Id: ";
            LBLAlterarId.Location = new point(100,30);
            LBLAlterarId.AutoSize = true;
            form.Controller.Add(LBLAlterarId);

            TextBox TextoAlterarId = new TextBox();
            TextoAlterarId.Top = 60;
            TextoAlterarId.Left = 100;
            TextoAlterarId.Width = 300;

            Label LBLAlterarPeriodo = new Label();
            LBLAlterarPeriodo.Text = "Período: ";
            LBLAlterarPeriodo.Location = new Point(100, 90);
            LBLAlterarPeriodo.AutoSize = true;
            form.Controller.Add(LBLAlterarPeriodo);

            TextBox TextoAlterarPeriodo = new TextBox();
            TextoAlterarPeriodo.Top = 120;
            TextoAlterarPeriodo.Left = 100;
            TextoAlterarPeriodo.Width = 300;

            Label LBLAlterarEscala = new Label();
            LBLAlterarEscala.Text = "Escala: ";
            LBLAlterarEscala.Location = new Point (100,60);
            LBLAlterarEscala.AutoSize = true;
            LBLAlterarEscala.Controller.Add(LBLIncluirCPF);

            TextBox TextoAlterarEscala = new TextBox();
            TextoAlterarEscala.Top = 85;
            TextoAlterarEscala.Left = 130;
            TextoAlterarEscala.Width = 330;

            Button AlterarTurnoButton = new Button();
            AlterarTurnoButton.Text = "Alterar";
            AlterarTurnoButton.Top = 360;
            AlterarTurnoButton.Left = 220;
            AlterarTurnoButton.Width = 70;
            AlterarTurnoButton.Click += (sender, e) => {Controller.Turno.AlterarTurno(new Model.Turno(TextoAlterarNome,int.Parse(TextoAlterarCPF), int.Parse(TextoAlterarPIS)));
                
                form.Close();
                form.Dispose();
                View.Turno.listarTurno();
            };

            Button SairTurnoButton = new Button();
            SairTurnoButton.Text = "Voltar";
            SairTurnoButton.Top = 360;
            SairTurnoButton.Left = 300;
            SairTurnoButton.Width = 60;
            SairTurnoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLAlterarTurno);
            form.Controller.Add(LBLAlterarId);
            form.Controller.Add(LBLAlterarPeriodo);
            form.Controller.Add(LBLAlterarEscala);
            form.Controller.Add(TextoAlterarId);
            form.Controller.Add(TextoAlterarPeriodo);
            form.Controller.Addo(TextoAlterarEscala);
            form.Controller.Add(AlterarTurnoButton);
            form.Controller.Add(SairTurnoButton);
            form.ShowDialog();
        }

        public static void ExcluirTurno(){

            Form form = new Form();
            form.Text = "Turnos";
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
            LBLExcuir.Text = "Excluir turno";
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

            Button ExcluirTurnoButton = new Button();
            ExcluirTurnoButton.Text = "Excluir";
            ExcluirTurnoButton.Top = 360;
            ExcluirTurnoButton.Left = 220;
            ExcluirTurnoButton.Width = 60;
            ExcluirTurnoButton.Click += (sender, e) => { 
                Controllers.Turno.excluirTurnos (int.Parse(TextoExcluirId.Text));
                form.Close(); 
                form.Dispose();
                Views.Turno.listarTurno();
                };

            Button SairTurnoButton = new Button();
            SairTurnoButton.Text = "Voltar";
            SairTurnoButton.Top = 360;
            SairTurnoButton.Left = 300;
            SairTurnoButton.Width = 60;
            SairTurnoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLExcuir);
            form.Controller.Add(LBLExcluirId);
            form.Controller.Add(TextoExcluirId);
            form.Controller.Add(ExcluirTurnoButton);
            form.Controller.Add(SairTurnoButton);
            form.ShowDialog();
        }
    }
}