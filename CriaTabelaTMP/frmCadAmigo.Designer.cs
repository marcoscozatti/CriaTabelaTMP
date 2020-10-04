namespace CriaTabelaTMP
{
	partial class frmCadAmigo
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblID = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExlcuir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(30, 34);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 17);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(30, 70);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(45, 17);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome";
			// 
			// lblCelular
			// 
			this.lblCelular.AutoSize = true;
			this.lblCelular.Location = new System.Drawing.Point(30, 109);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(52, 17);
			this.lblCelular.TabIndex = 2;
			this.lblCelular.Text = "Celular";
			// 
			// lblTelefone
			// 
			this.lblTelefone.AutoSize = true;
			this.lblTelefone.Location = new System.Drawing.Point(30, 145);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(64, 17);
			this.lblTelefone.TabIndex = 3;
			this.lblTelefone.Text = "Telefone";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(133, 31);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(66, 22);
			this.txtID.TabIndex = 4;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(133, 65);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(315, 22);
			this.txtNome.TabIndex = 5;
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(133, 106);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(138, 22);
			this.txtCelular.TabIndex = 6;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(133, 142);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(138, 22);
			this.txtTelefone.TabIndex = 7;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(110, 189);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(75, 23);
			this.btnInserir.TabIndex = 8;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(201, 189);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 9;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExlcuir
			// 
			this.btnExlcuir.Location = new System.Drawing.Point(293, 189);
			this.btnExlcuir.Name = "btnExlcuir";
			this.btnExlcuir.Size = new System.Drawing.Size(75, 23);
			this.btnExlcuir.TabIndex = 10;
			this.btnExlcuir.Text = "Excluir";
			this.btnExlcuir.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(33, 227);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(415, 193);
			this.dataGridView1.TabIndex = 11;
			// 
			// frmCadAmigo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnExlcuir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblTelefone);
			this.Controls.Add(this.lblCelular);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblID);
			this.MinimizeBox = false;
			this.Name = "frmCadAmigo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Amigo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.MaskedTextBox txtCelular;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExlcuir;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

