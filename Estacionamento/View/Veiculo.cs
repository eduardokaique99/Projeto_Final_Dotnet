using Controller;

namespace View
{
  /*  public class Veiculo
    {
        public static void listarVeiculo()
        {
            Form form = new Form();
            form.Text = "Lista de Veículos";
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
            lista.Columns.Add("Placa");

            foreach(Model.Veiculo veiculo in Model.Veiculo.veiculos){
                lista.Items.Add(new ListViewItem(new string[] {veiculo.id.ToString(), veiculo.nome.ToString()}));
            }

            Button CadastrarVeiculoButton = new Button();
            CadastrarVeiculoButton.Text = "Incluir";
            CadastrarVeiculoButton.Top = 360;
            CadastrarVeiculoButton.Left = 10;
            CadastrarVeiculoButton.Width = 70;
            CadastrarVeiculoButton.Click += (sender, e) => {View.Veiculo.addVeiculo();
            
                form.Close();
                form.Dispose();            
            };

            Button AlterarVeiculoButton = new Button();
            AlterarVeiculoButton.Text = "Alterar";
            AlterarVeiculoButton.Top = 360;
            AlterarVeiculoButton.Left = 90;
            AlterarVeiculoButton.Width = 60;
            AlterarVeiculoButton.Click += (sender, e) => {View.Veiculo.addVeiculo();
            
                form.Close();
                form.Dispose();
            };

            Button ExcluirVeiculoButton = new Button();
            ExcluirVeiculoButton.Text = "Excluir";
            ExcluirVeiculoButton.Top = 360;
            ExcluirVeiculoButton.Left = 160;
            ExcluirVeiculoButton.Width = 60;
            ExcluirVeiculoButton.Click += (sender, e) => {View.Veiculo.addVeiculo();
            
                form.Close();
                form.Dispose();
            };

            Button SairVeiculoButton = new Button();
            SairVeiculoButton.Text = "Voltar";
            SairVeiculoButton.Top = 360;
            SairVeiculoButton = 230;
            SairVeiculoButton = 60;
            SairVeiculoButton.Click += (sender, e) => {View.Veiculo.addVeiculo();};

            form.Controller.Add(CadastrarVeiculoButton);
            form.Controller.Add(AlterarVeiculoButton);
            form.Controller.Add(ExcluirVeiculoButton);
            form.Controller.Add(SairVeiculoButton);
            form.Controller.Add(lista);
            form.Controller.Add(lista);
            form.ShowDialog();
        }

        public static void AdicionarVeiculo(){

            Form form = new Form();
            form.Text = "Veículos";
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

            Label LBLIncluirVeiculo = new Label();
            LBLIncluirVeiculo.Text = "Cadastrar veículo";
            LBLIncluirVeiculo.Top = 10;
            LBLIncluirVeiculo.Left = 200;
            LBLIncluirVeiculo.Width = 300;

            Label LBLIncluirPlaca = new Label();
            LBLIncluirPlaca.Text = "Placa: ";
            LBLIncluirPlaca.Location = new Ponit (100, 30);
            LBLIncluirPlaca.AutoSize = true;
            LBLIncluirPlaca.Controller.Add(LBLIncluirPlaca);

            TextBox TextoPlaca = new TextBox();
            TextoPlaca.Top = 55;
            TextoPlaca.Left = 100;
            TextoPlaca.Width = 300;

            Button CadastrarVeiculoButton = new Button();
            CadastrarVeiculoButton.Text = "Cadastrar";
            CadastrarVeiculoButton.Top = 360;
            CadastrarVeiculoButton.Left = 220;
            CadastrarVeiculoButton.Width = 70;
            CadastrarVeiculoButton.Click += (sender, e) => {Controller.Veiculo.CadastrarVeiculoButton(new Model.Veiculo(id, TextoNome.Text));
            
                form.Close();
                form.Dispose();
                View.Veiculo.listarVeiculo();
            };

            Button SairVeiculoButton = new Button();
            SairVeiculoButton.Text = "Voltar";
            SairVeiculoButton.Top = 360;
            SairVeiculoButton.Left = 300;
            SairVeiculoButton.Width = 60;
            SairVeiculoButton.Click += (sender, e) => {form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLIncluirVeiculo);
            form.Controller.Add(LBLIncluirPlaca);
            form.Controller.Add(TextoPlaca);
            form.Controller.Add(CadastrarVeiculoButton);
            form.Controller.Add(SairVeiculoButton);
            form.ShowDialog();
        }

        public static void AlterarVeiculo(){

            Form form = new Form();
            form.Text = "Veículo";
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

            Label LBLAlterarVeiculo = new Label();
            LBLAlterarVeiculo.Text = "Alterar Veículo";
            LBLAlterarVeiculo.Top = 10;
            LBLAlterarVeiculo.Left = 200;
            LBLAlterarVeiculo.Width = 300;

            Label LBLAlterarId = new Label();
            LBLAlterarId.Text = "Id: ";
            LBLAlterarId.Location = new point(100,30);
            LBLAlterarId.AutoSize = true;
            form.Controller.Add(LBLAlterarId);

            TextBox TextoAlterarId = new TextBox();
            TextoAlterarId.Top = 60;
            TextoAlterarId.Left = 100;
            TextoAlterarId.Width = 300;

            Label LBLAlterarPlaca = new Label();
            LBLAlterarPlaca.Text = "Placa: ";
            LBLAlterarPlaca.Location = new Point(100, 90);
            LBLAlterarPlaca.AutoSize = true;
            form.Controller.Add(LBLAlterarPlaca);

            TextBox TextoAlterarPlaca = new TextBox();
            TextoAlterarPlaca.Top = 120;
            TextoAlterarPlaca.Left = 100;
            TextoAlterarPlaca.Width = 300;

            Button AlterarVeiculoButton = new Button();
            AlterarVeiculoButton.Text = "Alterar";
            AlterarVeiculoButton.Top = 360;
            AlterarVeiculoButton.Left = 220;
            AlterarVeiculoButton.Width = 70;
            AlterarVeiculoButton.Click += (sender, e) => {Controller.Veiculo.AlterarVeiculo(new Model.Veiculo(TextoAlterarNome,int.Parse(TextoAlterarCPF), int.Parse(TextoAlterarPIS)));
                
                form.Close();
                form.Dispose();
                View.Veiculo.listarVeiculo();
            };

            Button SairVeiculoButton = new Button();
            SairVeiculoButton.Text = "Voltar";
            SairVeiculoButton.Top = 360;
            SairVeiculoButton.Left = 300;
            SairVeiculoButton.Width = 60;
            SairVeiculoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLAlterarVeiculo);
            form.Controller.Add(LBLAlterarId);
            form.Controller.Add(LBLAlterarPlaca);
            form.Controller.Add(TextoAlterarId);
            form.Controller.Add(TextoAlterarPlaca);
            form.Controller.Add(AlterarVeiculoButton);
            form.Controller.Add(SairVeiculoButton);
            form.ShowDialog();
        }

        public static void ExcluirVeiculo(){

            Form form = new Form();
            form.Text = "Veículo";
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
            LBLExcuir.Text = "Excluir Veículo";
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

            Button ExcluirVeiculoButton = new Button();
            ExcluirVeiculoButton.Text = "Excluir";
            ExcluirVeiculoButton.Top = 360;
            ExcluirVeiculoButton.Left = 220;
            ExcluirVeiculoButton.Width = 60;
            ExcluirVeiculoButton.Click += (sender, e) => { 
                Controllers.Veiculo.excluirVeiculos (int.Parse(TextoExcluirId.Text));
                form.Close(); 
                form.Dispose();
                Views.Veiculo.listarVeiculo();
                };

            Button SairVeiculoButton = new Button();
            SairVeiculoButton.Text = "Voltar";
            SairVeiculoButton.Top = 360;
            SairVeiculoButton.Left = 300;
            SairVeiculoButton.Width = 60;
            SairVeiculoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLExcuir);
            form.Controller.Add(LBLExcluirId);
            form.Controller.Add(TextoExcluirId);
            form.Controller.Add(ExcluirVeiculoButton);
            form.Controller.Add(SairVeiculoButton);
            form.ShowDialog();
        }
    }*/
}