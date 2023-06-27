using Controller;

namespace View
{
   /* public class Movimentacao
    {
        public static void listarMovimentacao()
        {
            Form form = new Form();
            form.Text = "Lista de movimentações";
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
            lista.Columns.Add("Data de entrada");
            lista.Columns.Add("Dara de saída");

            foreach(Model.Movimentacao movimentacao in Model.Movimentacao.movimentacoes){
                lista.Items.Add(new ListViewItem(new string[] {movimentacao.id.ToString(), movimentacao.nome.ToString()}));
            }

            Button CadastrarMovimentacaoButton = new Button();
            CadastrarMovimentacaoButton.Text = "Incluir";
            CadastrarMovimentacaoButton.Top = 360;
            CadastrarMovimentacaoButton.Left = 10;
            CadastrarMovimentacaoButton.Width = 70;
            CadastrarMovimentacaoButton.Click += (sender, e) => {View.Movimentacao.addMovimentacao();
            
                form.Close();
                form.Dispose();            
            };

            Button AlterarMovimentacaoButton = new Button();
            AlterarMovimentacaoButton.Text = "Alterar";
            AlterarMovimentacaoButton.Top = 360;
            AlterarMovimentacaoButton.Left = 90;
            AlterarMovimentacaoButton.Width = 60;
            AlterarMovimentacaoButton.Click += (sender, e) => {View.Movimentacao.addMovimentacao();
            
                form.Close();
                form.Dispose();
            };

            Button ExcluirMovimentacaoButton = new Button();
            ExcluirMovimentacaoButton.Text = "Excluir";
            ExcluirMovimentacaoButton.Top = 360;
            ExcluirMovimentacaoButton.Left = 160;
            ExcluirMovimentacaoButton.Width = 60;
            ExcluirMovimentacaoButton.Click += (sender, e) => {View.Movimentacao.addMovimentacao();
            
                form.Close();
                form.Dispose();
            };

            Button SairMovimentacaoButton = new Button();
            SairMovimentacaoButton.Text = "Voltar";
            SairMovimentacaoButton.Top = 360;
            SairMovimentacaoButton = 230;
            SairMovimentacaoButton = 60;
            SairMovimentacaoButton.Click += (sender, e) => {View.Movimentacao.addMovimentacao();};

            form.Controller.Add(CadastrarMovimentacaoButton);
            form.Controller.Add(AlterarMovimentacaoButton);
            form.Controller.Add(ExcluirMovimentacaoButton);
            form.Controller.Add(SairMovimentacaoButton);
            form.Controller.Add(lista);
            form.Controller.Add(lista);
            form.ShowDialog();
        }

        public static void AdicionarMovimentacao(){

            Form form = new Form();
            form.Text = "Movimentações";
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

            Label LBLIncluirMovimentacao = new Label();
            LBLIncluirMovimentacao.Text = "Cadastrar movimentações";
            LBLIncluirMovimentacao.Top = 10;
            LBLIncluirMovimentacao.Left = 200;
            LBLIncluirMovimentacao.Width = 300;

            Label LBLIncluirDataEntrada = new Label();
            LBLIncluirDataEntrada.Text = "Data de entrada: ";
            LBLIncluirDataEntrada.Location = new Ponit (100, 30);
            LBLIncluirDataEntrada.AutoSize = true;
            LBLIncluirDataEntrada.Controller.Add(LBLIncluirDataEntrada);

            TextBox TextoDataEntrada = new TextBox();
            TextoDataEntrada.Top = 55;
            TextoDataEntrada.Left = 100;
            TextoDataEntrada.Width = 300;

            Label LBLIncluirDataSaida = new Label();
            LBLIncluirDataSaida.Text = "Data de saída: ";
            LBLIncluirDataSaida.Location = new Point (100,60);
            LBLIncluirDataSaida.AutoSize = true;
            LBLIncluirDataSaida.Controller.Add(LBLIncluirDataSaida);

            TextBox TextoDataSaida = new TextBox();
            TextoDataSaida.Top = 85;
            TextoDataSaida.Left = 130;
            TextoDataSaida.Width = 330;

            Button CadastrarMovimentacaoButton = new Button();
            CadastrarMovimentacaoButton.Text = "Cadastrar";
            CadastrarMovimentacaoButton.Top = 360;
            CadastrarMovimentacaoButton.Left = 220;
            CadastrarMovimentacaoButton.Width = 70;
            CadastrarMovimentacaoButton.Click += (sender, e) => {Controller.Movimentacao.CadastrarMovimentacaoButton(new Model.Movimentacao(id, TextoNome.Text));
            
                form.Close();
                form.Dispose();
                View.Movimentacao.listarMovimentacao();
            };

            Button SairMovimentacaoButton = new Button();
            SairMovimentacaoButton.Text = "Voltar";
            SairMovimentacaoButton.Top = 360;
            SairMovimentacaoButton.Left = 300;
            SairMovimentacaoButton.Width = 60;
            SairMovimentacaoButton.Click += (sender, e) => {form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLIncluirMovimentacao);
            form.Controller.Add(LBLIncluirDataEntrada);
            form.Controller.Add(LBLIncluirDataSaida);
            form.Controller.Add(TextoDataEntrada);
            form.Controller.Add(TextoDataSaida);
            form.Controller.Add(CadastrarMovimentacaoButton);
            form.Controller.Add(SairMovimentacaoButton);
            form.ShowDialog();
        }

        public static void AlterarMovimentacao(){

            Form form = new Form();
            form.Text = "Movimentações";
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

            Label LBLAlterarMovimentacao = new Label();
            LBLAlterarMovimentacao.Text = "Alterar movimentações";
            LBLAlterarMovimentacao.Top = 10;
            LBLAlterarMovimentacao.Left = 200;
            LBLAlterarMovimentacao.Width = 300;

            Label LBLAlterarId = new Label();
            LBLAlterarId.Text = "Id: ";
            LBLAlterarId.Location = new point(100,30);
            LBLAlterarId.AutoSize = true;
            form.Controller.Add(LBLAlterarId);

            TextBox TextoAlterarId = new TextBox();
            TextoAlterarId.Top = 60;
            TextoAlterarId.Left = 100;
            TextoAlterarId.Width = 300;

            Label LBLAlterarDataEntrada = new Label();
            LBLAlterarDataEntrada.Text = "Data de entrada: ";
            LBLAlterarDataEntrada.Location = new Point(100, 90);
            LBLAlterarDataEntrada.AutoSize = true;
            form.Controller.Add(LBLAlterarDataEntrada);

            TextBox TextoAlterarDataEntrada = new TextBox();
            TextoAlterarDataEntrada.Top = 120;
            TextoAlterarDataEntrada.Left = 100;
            TextoAlterarDataEntrada.Width = 300;

            Label LBLAlterarDataSaida = new Label();
            LBLAlterarDataSaida.Text = "Data de saída:";
            LBLAlterarDataSaida.Location = new Point (100,60);
            LBLAlterarDataSaida.AutoSize = true;
            LBLAlterarDataSaida.Controller.Add(LBLAlterarDataSaida);

            TextBox TextoAlterarDataSaida = new TextBox();
            TextoAlterarDataSaida.Top = 85;
            TextoAlterarDataSaida.Left = 130;
            TextoAlterarDataSaida.Width = 330;

            Button AlterarMovimentacaoButton = new Button();
            AlterarMovimentacaoButton.Text = "Alterar";
            AlterarMovimentacaoButton.Top = 360;
            AlterarMovimentacaoButton.Left = 220;
            AlterarMovimentacaoButton.Width = 70;
            AlterarMovimentacaoButton.Click += (sender, e) => {Controller.Movimentacao.AlterarMovimentacao(new Model.Movimentacao(TextoAlterarNome,int.Parse(TextoAlterarCPF), int.Parse(TextoAlterarPIS)));
                
                form.Close();
                form.Dispose();
                View.Movimentacao.listarMovimentacao();
            };

            Button SairMovimentacaoButton = new Button();
            SairMovimentacaoButton.Text = "Voltar";
            SairMovimentacaoButton.Top = 360;
            SairMovimentacaoButton.Left = 300;
            SairMovimentacaoButton.Width = 60;
            SairMovimentacaoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLAlterarMovimentacao);
            form.Controller.Add(LBLAlterarId);
            form.Controller.Add(LBLAlterarDataEntrada);
            form.Controller.Add(LBLAlterarDataSaida);
            form.Controller.Add(TextoAlterarId);
            form.Controller.Add(TextoAlterarDataEntrada);
            form.Controller.Addo(TextoAlterarDataSaida);
            form.Controller.Add(AlterarMovimentacaoButton);
            form.Controller.Add(SairMovimentacaoButton);
            form.ShowDialog();
        }

        public static void ExcluirMovimentacao(){

            Form form = new Form();
            form.Text = "Movimentações";
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
            LBLExcuir.Text = "Excluir movimentação";
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

            Button ExcluirMovimentacaoButton = new Button();
            ExcluirMovimentacaoButton.Text = "Excluir";
            ExcluirMovimentacaoButton.Top = 360;
            ExcluirMovimentacaoButton.Left = 220;
            ExcluirMovimentacaoButton.Width = 60;
            ExcluirMovimentacaoButton.Click += (sender, e) => { 
                Controllers.Movimentacao.excluirMovimentacaos (int.Parse(TextoExcluirId.Text));
                form.Close(); 
                form.Dispose();
                Views.Movimentacao.listarMovimentacao();
                };

            Button SairMovimentacaoButton = new Button();
            SairMovimentacaoButton.Text = "Voltar";
            SairMovimentacaoButton.Top = 360;
            SairMovimentacaoButton.Left = 300;
            SairMovimentacaoButton.Width = 60;
            SairMovimentacaoButton.Click += (sender, e) => { form.Close();
            
                form.Dispose();
            };

            form.Controller.Add(LBLExcuir);
            form.Controller.Add(LBLExcluirId);
            form.Controller.Add(TextoExcluirId);
            form.Controller.Add(ExcluirMovimentacaoButton);
            form.Controller.Add(SairMovimentacaoButton);
            form.ShowDialog();
        }
    }*/
}

