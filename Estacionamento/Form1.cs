namespace Estacionamento;

public partial class Form1 : Form
{
    public  Form1() {
            
            Form menu = new Form();
            menu.Text = "Login";
            menu.Size = new System.Drawing.Size(1100, 500);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.BackColor = Color.White;
            
            Panel panel = new Panel();
            panel.BackColor = Color.BlueViolet;
            panel.Size = new Size(500, 500);

            Label lbl1= new Label();
            lbl1.Text = "BEM VINDO AO NATRIKE";
            lbl1.Top = 125;
            lbl1.Left = 20;
            lbl1.Size = new System.Drawing.Size(480, 60);
            lbl1.Font = new Font(lbl1.Font.FontFamily, 30);
            lbl1.ForeColor = Color.White;
            lbl1.BackColor = Color.BlueViolet;

            Label lbl2= new Label();
            lbl2.Text = "Sistema de automatização de estacionamento";
            lbl2.Top = 185;
            lbl2.Left = 110;
            lbl2.Size = new System.Drawing.Size(300, 90);
            lbl2.Font = new Font(lbl2.Font.FontFamily, 15);
            lbl2.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            lbl2.ForeColor = Color.White;
            lbl2.BackColor = Color.BlueViolet;
            
            Label lblUser= new Label();
            lblUser.Text = "Usuário";
            lblUser.Top = 125;
            lblUser.Left = 750;
            lblUser.Size = new System.Drawing.Size(200, 35);
            lblUser.Font = new Font(lblUser.Font.FontFamily, 20);

            TextBox txtUser = new TextBox();
            txtUser.Top = 175;
            txtUser.Left = 677;
            txtUser.Size = new System.Drawing.Size(250, 25);
            txtUser.BackColor = Color.LightGray;

            Label lblMens1 = new Label();
            lblMens1.Text = "Digite o nome.";
            lblMens1.Top = 200;
            lblMens1.Left = 677;
            lblMens1.Size = new System.Drawing.Size(150, 20);
            lblMens1.ForeColor = Color.Red;
            lblMens1.Visible = false;

            Label lblMens2 = new Label();
            lblMens2.Text = "Usuário ou senha incorreto.";
            lblMens2.Top = 305;
            lblMens2.Left = 677;
            lblMens2.Size = new System.Drawing.Size(250, 20);
            lblMens2.ForeColor = Color.Red;
            lblMens2.Visible = false;

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Top = 210;
            lblSenha.Left = 760;
            lblSenha.Size = new System.Drawing.Size(200, 35);
            lblSenha.Font = new Font(lblSenha.Font.FontFamily, 20);

            TextBox txtSenha = new TextBox();
            txtSenha.Top = 260;
            txtSenha.Left = 677;
            txtSenha.Size = new System.Drawing.Size(250, 25);
            txtSenha.BackColor = Color.LightGray;
            //txtSenha.PasswordChar = '*'; // Define o caractere a ser exibido no lugar da senha
            txtSenha.UseSystemPasswordChar = true;

            Label lblMens = new Label();
            lblMens.Text = "Digite a senha.";
            lblMens.Top = 285;
            lblMens.Left = 677;
            lblMens.Size = new System.Drawing.Size(150, 20);
            lblMens.ForeColor = Color.Red;
            lblMens.Visible = false;

            CheckBox showPasswordCheckBox = new CheckBox();
            showPasswordCheckBox.Text = "Mostrar senha";
            showPasswordCheckBox.Top = 320;
            showPasswordCheckBox.Left = 677;
            showPasswordCheckBox.CheckedChanged += (sender, e) =>
            {
                txtSenha.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            };

            Button btnLogin = new Button();
            btnLogin.Text = "Entrar";
            btnLogin.Top = 350;
            btnLogin.Left = 760;
            btnLogin.Size = new System.Drawing.Size(90, 25);
            btnLogin.BackColor = Color.BlueViolet;
            btnLogin.ForeColor = Color.White;
            btnLogin.Click += (sender, e) => {
                if (txtUser.Text.Length <= 0)
                {
                    lblMens1.Visible = true;
                    return;
                }
                if (txtSenha.Text.Length <= 0)
                {
                    lblMens1.Visible = false;
                    lblMens.Visible = true;
                    lblMens2.Visible = false;
                    return;
                }
                lblMens1.Visible = false;
                lblMens.Visible = false;
                lblMens2.Visible = false;
                if (Models.Usuario.Login(txtUser.Text, txtSenha.Text))
                {
                    menu.Close();
                    //menu.Dispose();
                    Views.LoginADM.ADM();
                }
                else
                {
                    lblMens2.Visible = true;
                    lblMens1.Visible = false;
                    lblMens.Visible = false;
                }
                
            };
            
            menu.Controls.Add(lbl1);
            menu.Controls.Add(lbl2);
            menu.Controls.Add(panel);
            menu.Controls.Add(lblUser);
            menu.Controls.Add(txtUser);
            menu.Controls.Add(lblMens1);
            menu.Controls.Add(lblMens2);
            menu.Controls.Add(lblSenha);
            menu.Controls.Add(txtSenha);
            menu.Controls.Add(lblMens);
            menu.Controls.Add(showPasswordCheckBox);
            menu.Controls.Add(btnLogin);
            menu.ShowDialog();
        }
}