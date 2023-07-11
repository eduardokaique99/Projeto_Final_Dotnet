using System;
using System.Windows.Forms;

namespace Views {
    
    public class Turno {
        
        public static void ListarTurno() {
            Form turs = new Form();
            turs.Text = "Turnos";
            turs.Size = new System.Drawing.Size(700, 500);
            turs.StartPosition = FormStartPosition.CenterScreen;
            turs.FormBorderStyle = FormBorderStyle.FixedSingle;
            turs.MaximizeBox = false;
            turs.MinimizeBox = false;
            turs.BackColor = Color.BlueViolet;

            ListView listaTurs = new ListView();
            listaTurs.Size = new System.Drawing.Size(665, 400);
            listaTurs.Location = new System.Drawing.Point(10, 10);
            listaTurs.View = View.Details;
            listaTurs.Columns.Add("Id", 100);
            listaTurs.Columns.Add("Período", 200);
            listaTurs.Columns.Add("Escala", 200);
            listaTurs.Columns.Add("Id Estacionamento", 161);
            listaTurs.FullRowSelect = true;
            listaTurs.GridLines = true;

            List<Models.Turno> turnoList = Models.Turno.BuscarTodos();
            foreach (Models.Turno turno in turnoList) {
                ListViewItem item = new ListViewItem(turno.Id.ToString());
                item.SubItems.Add(turno.Periodo);
                item.SubItems.Add(turno.Escala.ToString());
                item.SubItems.Add(turno.IdEstacionamento.ToString());
                listaTurs.Items.Add(item);
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
                turs.Close();
                turs.Dispose();
                CriarTurno();
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
                string id = listaTurs.SelectedItems[0].Text;
                turs.Close();
                turs.Dispose();
                AlterarTurno(Int32.Parse(id));
                turs.Close();
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
                string id = listaTurs.SelectedItems[0].Text;
                ExcluirTurno(Int32.Parse(id));
                turs.Dispose();
                turs.Close();
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
                turs.Hide();
                turs.Close();
                turs.Dispose();
            };

            turs.Controls.Add(listaTurs);
            turs.Controls.Add(btnAdicionar);
            turs.Controls.Add(btnEdit);
            turs.Controls.Add(BtnRemove);
            turs.Controls.Add(BtnVoltar);
            turs.ShowDialog();
        } 

          public static void CriarTurno() {
            Form adicionarTurno = new Form();
            adicionarTurno.Text = "Adicionar Turno";
            adicionarTurno.Size = new System.Drawing.Size(600, 450);
            adicionarTurno.StartPosition = FormStartPosition.CenterScreen;
            adicionarTurno.FormBorderStyle = FormBorderStyle.FixedSingle;
            adicionarTurno.MaximizeBox = false;
            adicionarTurno.MinimizeBox = false;
            adicionarTurno.BackColor = Color.BlueViolet;

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

            Label lblPeriodo = new Label();
            lblPeriodo.Text = "Periodo:";
            lblPeriodo.Top = 70;
            lblPeriodo.Left = 10;
            lblPeriodo.ForeColor = Color.White;
            lblPeriodo.Font = new Font(lblPeriodo.Font.FontFamily, 18);
            lblPeriodo.Size = new System.Drawing.Size(250, 35);

            TextBox txtPerido = new TextBox();
            txtPerido.Top = 77;
            txtPerido.Left = 270;
            txtPerido.BackColor = Color.LightGray;
            txtPerido.Size = new System.Drawing.Size(300, 35);

            Label lblEscala = new Label();
            lblEscala.Text = "Escala:";
            lblEscala.Top = 115;
            lblEscala.Left = 10;
            lblEscala.ForeColor = Color.White;
            lblEscala.Font = new Font(lblEscala.Font.FontFamily, 18);
            lblEscala.Size = new System.Drawing.Size(250, 35);

            TextBox txtEscala = new TextBox();
            txtEscala.Top = 122;
            txtEscala.Left = 270;
            txtEscala.BackColor = Color.LightGray;
            txtEscala.Size = new System.Drawing.Size(300, 35);

            Label lblIdEstacionamento = new Label();
            lblIdEstacionamento.Text = "Id Estacionamento:";
            lblIdEstacionamento.Top = 160;
            lblIdEstacionamento.Left = 10;
            lblIdEstacionamento.ForeColor = Color.White;
            lblIdEstacionamento.Font = new Font(lblIdEstacionamento.Font.FontFamily, 18);
            lblIdEstacionamento.Size = new System.Drawing.Size(250, 35);

            TextBox txtIdEstacionamento = new TextBox();
            txtIdEstacionamento.Top = 167;
            txtIdEstacionamento.Left = 270;
            txtIdEstacionamento.BackColor = Color.LightGray;
            txtIdEstacionamento.Size = new System.Drawing.Size(300, 35);

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
                    Controllers.Turno.CriarTurno(int.Parse(txtId.Text), txtPerido.Text, int.Parse(txtEscala.Text), int.Parse(txtIdEstacionamento.Text));
                    adicionarTurno.Hide();
                    adicionarTurno.Close();
                    adicionarTurno.Dispose();
                    ListarTurno();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Erro ao adicionar produto: {err.Message}");
                }
                finally 
                {
                    adicionarTurno.Hide();
                    adicionarTurno.Close();
                    adicionarTurno.Dispose();
                    ListarTurno();                    
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
                adicionarTurno.Close();
            };

            adicionarTurno.Controls.Add(lblId);
            adicionarTurno.Controls.Add(txtId);
            adicionarTurno.Controls.Add(lblPeriodo);
            adicionarTurno.Controls.Add(txtPerido);
            adicionarTurno.Controls.Add(lblEscala);
            adicionarTurno.Controls.Add(txtEscala);
            adicionarTurno.Controls.Add(lblIdEstacionamento);
            adicionarTurno.Controls.Add(txtIdEstacionamento);
            adicionarTurno.Controls.Add(btnSalvar);
            adicionarTurno.Controls.Add(btnCancelar);
            adicionarTurno.ShowDialog();
        }


        public static void AlterarTurno(int id) {
            Models.Turno turno = Controllers.Turno.BuscarTurno(id);
            Form editar = new Form();
            editar.Text = "Editar Tipo de veículo";
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
            txtId.Text = turno.Id.ToString();
            txtId.ReadOnly = true;
            txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Label lblPeriodo = new Label();
            lblPeriodo.Text = "Periodo:";
            lblPeriodo.Top = 70;
            lblPeriodo.Left = 10;
            lblPeriodo.ForeColor = Color.White;
            lblPeriodo.Font = new Font(lblPeriodo.Font.FontFamily, 18);
            lblPeriodo.Size = new System.Drawing.Size(250, 35);

            TextBox txtPerido = new TextBox();
            txtPerido.Top = 77;
            txtPerido.Left = 270;
            txtPerido.BackColor = Color.LightGray;
            txtPerido.Size = new System.Drawing.Size(300, 35);

            Label lblEscala = new Label();
            lblEscala.Text = "Escala:";
            lblEscala.Top = 115;
            lblEscala.Left = 10;
            lblEscala.ForeColor = Color.White;
            lblEscala.Font = new Font(lblEscala.Font.FontFamily, 18);
            lblEscala.Size = new System.Drawing.Size(250, 35);

            TextBox txtEscala = new TextBox();
            txtEscala.Top = 122;
            txtEscala.Left = 270;
            txtEscala.BackColor = Color.LightGray;
            txtEscala.Size = new System.Drawing.Size(300, 35);

            Label lblIdEstacionamento = new Label();
            lblIdEstacionamento.Text = "Id Estacionamento:";
            lblIdEstacionamento.Top = 160;
            lblIdEstacionamento.Left = 10;
            lblIdEstacionamento.ForeColor = Color.White;
            lblIdEstacionamento.Font = new Font(lblIdEstacionamento.Font.FontFamily, 18);
            lblIdEstacionamento.Size = new System.Drawing.Size(250, 35);

            TextBox txtIdEstacionamento = new TextBox();
            txtIdEstacionamento.Top = 167;
            txtIdEstacionamento.Left = 270;
            txtIdEstacionamento.BackColor = Color.LightGray;
            txtIdEstacionamento.Size = new System.Drawing.Size(300, 35);

            Button btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 330;
            btnSalvar.Left = 70;
            btnSalvar.BackColor = Color.White;
            btnSalvar.ForeColor = Color.BlueViolet;
            btnSalvar.Font = new Font(btnSalvar.Font.FontFamily, 18);
            btnSalvar.Size = new System.Drawing.Size(150, 35);
            btnSalvar.Click += (sender, e) => {
                Controllers.Turno.AlterarTurno(int.Parse(txtId.Text), txtPerido.Text, int.Parse(txtEscala.Text), int.Parse(txtIdEstacionamento.Text));
                editar.Hide();
                editar.Close();
                editar.Dispose();
                ListarTurno();
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
            editar.Controls.Add(lblPeriodo);
            editar.Controls.Add(txtPerido);
            editar.Controls.Add(lblEscala);
            editar.Controls.Add(txtEscala);
            editar.Controls.Add(lblIdEstacionamento);
            editar.Controls.Add(txtIdEstacionamento);
            editar.Controls.Add(btnSalvar);
            editar.Controls.Add(btnCancelar);
            editar.ShowDialog();
    }


    public static void ExcluirTurno(int id) {

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
            Controllers.Turno.ExcluirTurno(id);
            remove.Close();
            remove.Dispose();
            ListarTurno();          
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
            ListarTurno();
        };

        remove.Controls.Add(sim);
        remove.Controls.Add(nao);   
        remove.ShowDialog();
        }
    }
}