using Controller;

namespace View
{
    public class TipoVeiculo: Veiculo
    {
        public static void listarTipoVeiculo()
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
            lista.Columns.Add("Descrição");

            foreach(Model.TipoVeiculo TipoVeiculo in Model.TipoVeiculo.TipoVeiculos){
                lista.Items.Add(new ListViewItem(new string[] {TipoVeiculo.id.ToString(), TipoVeiculo.nome.ToString()}));
            }

            Button CadastrarTipoVeiculoButton = new Button();
            CadastrarTipoVeiculoButton.Text = "Incluir";
            CadastrarTipoVeiculoButton.Top = 360;
            CadastrarTipoVeiculoButton.Left = 10;
            CadastrarTipoVeiculoButton.Width = 70;
            CadastrarTipoVeiculoButton.Click += (sender, e) => {View.TipoVeiculo.addTipoVeiculo();
            
                form.Close();
                form.Dispose();            
            };

            Button AlterarTipoVeiculoButton = new Button();
            AlterarTipoVeiculoButton.Text = "Alterar";
            AlterarTipoVeiculoButton.Top = 360;
            AlterarTipoVeiculoButton.Left = 90;
            AlterarTipoVeiculoButton.Width = 60;
            AlterarTipoVeiculoButton.Click += (sender, e) => {View.TipoVeiculo.addTipoVeiculo();
            
                form.Close();
                form.Dispose();
            };

            Button ExcluirTipoVeiculoButton = new Button();
            ExcluirTipoVeiculoButton.Text = "Excluir";
            ExcluirTipoVeiculoButton.Top = 360;
            ExcluirTipoVeiculoButton.Left = 160;
            ExcluirTipoVeiculoButton.Width = 60;
            ExcluirTipoVeiculoButton.Click += (sender, e) => {View.TipoVeiculo.addTipoVeiculo();
            
                form.Close();
                form.Dispose();
            };

            Button SairTipoVeiculoButton = new Button();
            SairTipoVeiculoButton.Text = "Voltar";
            SairTipoVeiculoButton.Top = 360;
            SairTipoVeiculoButton = 230;
            SairTipoVeiculoButton = 60;
            SairTipoVeiculoButton.Click += (sender, e) => {View.TipoVeiculo.addTipoVeiculo();};

            form.Controller.Add(CadastrarTipoVeiculoButton);
            form.Controller.Add(AlterarTipoVeiculoButton);
            form.Controller.Add(ExcluirTipoVeiculoButton);
            form.Controller.Add(SairTipoVeiculoButton);
            form.Controller.Add(lista);
            form.Controller.Add(lista);
            form.ShowDialog();
        }

        public static void AdicionarTipoVeiculo(){

            Form form = new Form();
            form.Text = "Tipo de Veículo";
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

            Label LBLIncluirTipoVeiculo = new Label();
            LBLIncluirTipoVeiculo.Text = "Cadastrar um Tipo";
            LBLIncluirTipoVeiculo.Top = 10;
            LBLIncluirTipoVeiculo.Left = 200;
            LBLIncluirTipoVeiculo.Width = 300;

            Label LBLIncluirDescricao = new Label();
            LBLIncluirDescricao.Text = "Descrição: ";
            LBLIncluirDescricao.Location = new Ponit (100, 30);
            LBLIncluirDescricao.AutoSize = true;
            LBLIncluirDescricao.Controller.Add(LBLIncluirDescricao);

            TextBox TextoDescricao = new TextBox();
            TextoDescricao.Top = 55;
            TextoDescricao.Left = 100;
            TextoDescricao.Width = 300;

            Button CadastrarTipoVeiculoButton = new Button();
            CadastrarTipoVeiculoButton.Text = "Cadastrar";
            CadastrarTipoVeiculoButton.Top = 360;
            CadastrarTipoVeiculoButton.Left = 220;
            CadastrarTipoVeiculoButton.Width = 70;
            CadastrarTipoVeiculoButton.Click += (sender, e) => {Controller.TipoVeiculo.CadastrarTipoVeiculoButton(new Model.TipoVeiculo(id, TextoNome.Text));
            
                form.Close();
                form.Dispose();
                View.TipoVeiculo.listarTipoVeiculo();
            };

            Button SairTipoVeiculoButton = new Button();
            SairTipoVeiculoButton.Text = "Voltar";
            SairTipoVeiculoButton.Top = 360;
            SairTipoVeiculoButton.Left = 300;
            SairTipoVeiculoButton.Width = 60;
            SairTipoVeiculoButton.Click += (sender, e) => {form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLIncluirTipoVeiculo);
            form.Controller.Add(LBLIncluirDescricao);
            form.Controller.Add(TextoDescricao);
            form.Controller.Add(CadastrarTipoVeiculoButton);
            form.Controller.Add(SairTipoVeiculoButton);
            form.ShowDialog();
        }

        public static void AlterarTipoVeiculo(){

            Form form = new Form();
            form.Text = "Tipode de Veículo";
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

            Label LBLAlterarTipoVeiculo = new Label();
            LBLAlterarTipoVeiculo.Text = "Alterar um Tipo";
            LBLAlterarTipoVeiculo.Top = 10;
            LBLAlterarTipoVeiculo.Left = 200;
            LBLAlterarTipoVeiculo.Width = 300;

            Label LBLAlterarId = new Label();
            LBLAlterarId.Text = "Id: ";
            LBLAlterarId.Location = new point(100,30);
            LBLAlterarId.AutoSize = true;
            form.Controller.Add(LBLAlterarId);

            TextBox TextoAlterarId = new TextBox();
            TextoAlterarId.Top = 60;
            TextoAlterarId.Left = 100;
            TextoAlterarId.Width = 300;

            Label LBLAlterarDescricao = new Label();
            LBLAlterarDescricao.Text = "Descrição: ";
            LBLAlterarDescricao.Location = new Point(100, 90);
            LBLAlterarDescricao.AutoSize = true;
            form.Controller.Add(LBLAlterarDescricao);

            TextBox TextoAlterarDescricao = new TextBox();
            TextoAlterarDescricao.Top = 120;
            TextoAlterarDescricao.Left = 100;
            TextoAlterarDescricao.Width = 300;

            Button AlterarTipoVeiculoButton = new Button();
            AlterarTipoVeiculoButton.Text = "Alterar";
            AlterarTipoVeiculoButton.Top = 360;
            AlterarTipoVeiculoButton.Left = 220;
            AlterarTipoVeiculoButton.Width = 70;
            AlterarTipoVeiculoButton.Click += (sender, e) => {Controller.TipoVeiculo.AlterarTipoVeiculo(new Model.TipoVeiculo(TextoAlterarNome,int.Parse(TextoAlterarCPF), int.Parse(TextoAlterarPIS)));
                
                form.Close();
                form.Dispose();
                View.TipoVeiculo.listarTipoVeiculo();
            };

            Button SairTipoVeiculoButton = new Button();
            SairTipoVeiculoButton.Text = "Voltar";
            SairTipoVeiculoButton.Top = 360;
            SairTipoVeiculoButton.Left = 300;
            SairTipoVeiculoButton.Width = 60;
            SairTipoVeiculoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLAlterarTipoVeiculo);
            form.Controller.Add(LBLAlterarId);
            form.Controller.Add(LBLAlterarDescricao);
            form.Controller.Add(TextoAlterarId);
            form.Controller.Add(TextoAlterarDescricao);
            form.Controller.Add(AlterarTipoVeiculoButton);
            form.Controller.Add(SairTipoVeiculoButton);
            form.ShowDialog();
        }

        public static void ExcluirTipoVeiculo(){

            Form form = new Form();
            form.Text = "Tipo de Veículo";
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
            LBLExcuir.Text = "Excluir um Tipo";
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

            Button ExcluirTipoVeiculoButton = new Button();
            ExcluirTipoVeiculoButton.Text = "Excluir";
            ExcluirTipoVeiculoButton.Top = 360;
            ExcluirTipoVeiculoButton.Left = 220;
            ExcluirTipoVeiculoButton.Width = 60;
            ExcluirTipoVeiculoButton.Click += (sender, e) => { 
                Controllers.TipoVeiculo.excluirTipoVeiculos (int.Parse(TextoExcluirId.Text));
                form.Close(); 
                form.Dispose();
                Views.TipoVeiculo.listarTipoVeiculo();
                };

            Button SairTipoVeiculoButton = new Button();
            SairTipoVeiculoButton.Text = "Voltar";
            SairTipoVeiculoButton.Top = 360;
            SairTipoVeiculoButton.Left = 300;
            SairTipoVeiculoButton.Width = 60;
            SairTipoVeiculoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLExcuir);
            form.Controller.Add(LBLExcluirId);
            form.Controller.Add(TextoExcluirId);
            form.Controller.Add(ExcluirTipoVeiculoButton);
            form.Controller.Add(SairTipoVeiculoButton);
            form.ShowDialog();
        }
    }
}