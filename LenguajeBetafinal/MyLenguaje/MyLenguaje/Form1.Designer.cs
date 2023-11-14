namespace MyLenguaje
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.rchLexico = new System.Windows.Forms.RichTextBox();
            this.rchSintactico = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rchPosPrefijo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rchSemantico = new System.Windows.Forms.RichTextBox();
            this.dtgCuadruplo = new System.Windows.Forms.DataGridView();
            this.DtgColIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgColDatoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgColDatoFuente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgColDatoFuente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgColOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLexicar = new System.Windows.Forms.Button();
            this.btnSintactizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObjeto = new System.Windows.Forms.Button();
            this.btnOptimo = new System.Windows.Forms.Button();
            this.btnCuadruploTriplo = new System.Windows.Forms.Button();
            this.btnInPrePosFija = new System.Windows.Forms.Button();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.rchCodigoObjeto = new System.Windows.Forms.RichTextBox();
            this.dtgViewOptimizada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rchConsola3 = new System.Windows.Forms.RichTextBox();
            this.rchConsola2 = new System.Windows.Forms.RichTextBox();
            this.rchConsola1 = new System.Windows.Forms.RichTextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rchAnalisisSemantica = new System.Windows.Forms.RichTextBox();
            this.rchAnalisisSintactico = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rhcAnalisisLexico = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCaja = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuadruplo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewOptimizada)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.AcceptsTab = true;
            this.rchTexto.BackColor = System.Drawing.Color.Thistle;
            this.rchTexto.Location = new System.Drawing.Point(6, 37);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(306, 211);
            this.rchTexto.TabIndex = 1;
            this.rchTexto.Text = "";
            this.rchTexto.WordWrap = false;
            this.rchTexto.TextChanged += new System.EventHandler(this.rchTexto_TextChanged);
            // 
            // rchLexico
            // 
            this.rchLexico.BackColor = System.Drawing.Color.LightGreen;
            this.rchLexico.Location = new System.Drawing.Point(330, 37);
            this.rchLexico.Name = "rchLexico";
            this.rchLexico.ReadOnly = true;
            this.rchLexico.Size = new System.Drawing.Size(265, 211);
            this.rchLexico.TabIndex = 2;
            this.rchLexico.Text = "";
            this.rchLexico.WordWrap = false;
            // 
            // rchSintactico
            // 
            this.rchSintactico.BackColor = System.Drawing.Color.LightGreen;
            this.rchSintactico.Location = new System.Drawing.Point(601, 37);
            this.rchSintactico.Name = "rchSintactico";
            this.rchSintactico.ReadOnly = true;
            this.rchSintactico.Size = new System.Drawing.Size(265, 211);
            this.rchSintactico.TabIndex = 3;
            this.rchSintactico.Text = "";
            this.rchSintactico.WordWrap = false;
            this.rchSintactico.TextChanged += new System.EventHandler(this.rchSintactico_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(337, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lexico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(610, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sintactico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rchPosPrefijo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rchSemantico);
            this.groupBox1.Controls.Add(this.rchTexto);
            this.groupBox1.Controls.Add(this.rchSintactico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rchLexico);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1419, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(1149, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Postfijo";
            // 
            // rchPosPrefijo
            // 
            this.rchPosPrefijo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rchPosPrefijo.Location = new System.Drawing.Point(1143, 36);
            this.rchPosPrefijo.Name = "rchPosPrefijo";
            this.rchPosPrefijo.ReadOnly = true;
            this.rchPosPrefijo.Size = new System.Drawing.Size(265, 211);
            this.rchPosPrefijo.TabIndex = 9;
            this.rchPosPrefijo.Text = "";
            this.rchPosPrefijo.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(880, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Semantico";
            // 
            // rchSemantico
            // 
            this.rchSemantico.BackColor = System.Drawing.Color.LightGreen;
            this.rchSemantico.Location = new System.Drawing.Point(872, 36);
            this.rchSemantico.Name = "rchSemantico";
            this.rchSemantico.ReadOnly = true;
            this.rchSemantico.Size = new System.Drawing.Size(265, 211);
            this.rchSemantico.TabIndex = 7;
            this.rchSemantico.Text = "";
            this.rchSemantico.WordWrap = false;
            // 
            // dtgCuadruplo
            // 
            this.dtgCuadruplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuadruplo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtgColIndice,
            this.dtgColDatoObjeto,
            this.dtgColDatoFuente1,
            this.dtgColDatoFuente2,
            this.dtgColOperador});
            this.dtgCuadruplo.Location = new System.Drawing.Point(857, 292);
            this.dtgCuadruplo.Name = "dtgCuadruplo";
            this.dtgCuadruplo.Size = new System.Drawing.Size(544, 178);
            this.dtgCuadruplo.TabIndex = 10;
            // 
            // DtgColIndice
            // 
            this.DtgColIndice.HeaderText = "Indice";
            this.DtgColIndice.Name = "DtgColIndice";
            this.DtgColIndice.ReadOnly = true;
            // 
            // dtgColDatoObjeto
            // 
            this.dtgColDatoObjeto.HeaderText = "Dato Objeto";
            this.dtgColDatoObjeto.Name = "dtgColDatoObjeto";
            this.dtgColDatoObjeto.ReadOnly = true;
            // 
            // dtgColDatoFuente1
            // 
            this.dtgColDatoFuente1.HeaderText = "Dato Fuente 1";
            this.dtgColDatoFuente1.Name = "dtgColDatoFuente1";
            this.dtgColDatoFuente1.ReadOnly = true;
            // 
            // dtgColDatoFuente2
            // 
            this.dtgColDatoFuente2.HeaderText = "Dato Fuente 2";
            this.dtgColDatoFuente2.Name = "dtgColDatoFuente2";
            this.dtgColDatoFuente2.ReadOnly = true;
            // 
            // dtgColOperador
            // 
            this.dtgColOperador.HeaderText = "Operador";
            this.dtgColOperador.Name = "dtgColOperador";
            this.dtgColOperador.ReadOnly = true;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(6, 16);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(142, 51);
            this.btnAnalizar.TabIndex = 8;
            this.btnAnalizar.Text = "Analizador lexico";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnLexicar
            // 
            this.btnLexicar.BackColor = System.Drawing.Color.LightGreen;
            this.btnLexicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexicar.Location = new System.Drawing.Point(154, 16);
            this.btnLexicar.Name = "btnLexicar";
            this.btnLexicar.Size = new System.Drawing.Size(116, 51);
            this.btnLexicar.TabIndex = 9;
            this.btnLexicar.Text = "Analizador sintactico";
            this.btnLexicar.UseVisualStyleBackColor = false;
            this.btnLexicar.Click += new System.EventHandler(this.btnLexicar_Click);
            // 
            // btnSintactizar
            // 
            this.btnSintactizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSintactizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSintactizar.Location = new System.Drawing.Point(276, 16);
            this.btnSintactizar.Name = "btnSintactizar";
            this.btnSintactizar.Size = new System.Drawing.Size(136, 51);
            this.btnSintactizar.TabIndex = 10;
            this.btnSintactizar.Text = "Analizador semantico";
            this.btnSintactizar.UseVisualStyleBackColor = false;
            this.btnSintactizar.Click += new System.EventHandler(this.btnSintactizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObjeto);
            this.groupBox2.Controls.Add(this.btnOptimo);
            this.groupBox2.Controls.Add(this.btnCuadruploTriplo);
            this.groupBox2.Controls.Add(this.btnInPrePosFija);
            this.groupBox2.Controls.Add(this.btnAnalizar);
            this.groupBox2.Controls.Add(this.btnSintactizar);
            this.groupBox2.Controls.Add(this.btnLexicar);
            this.groupBox2.Location = new System.Drawing.Point(15, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1189, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnObjeto
            // 
            this.btnObjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnObjeto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjeto.Location = new System.Drawing.Point(418, 16);
            this.btnObjeto.Name = "btnObjeto";
            this.btnObjeto.Size = new System.Drawing.Size(295, 93);
            this.btnObjeto.TabIndex = 21;
            this.btnObjeto.Text = "Ensamblador";
            this.btnObjeto.UseVisualStyleBackColor = false;
            this.btnObjeto.Click += new System.EventHandler(this.btnObjeto_Click);
            // 
            // btnOptimo
            // 
            this.btnOptimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimo.Location = new System.Drawing.Point(276, 73);
            this.btnOptimo.Name = "btnOptimo";
            this.btnOptimo.Size = new System.Drawing.Size(136, 36);
            this.btnOptimo.TabIndex = 20;
            this.btnOptimo.Text = "Cuadruplos V2";
            this.btnOptimo.UseVisualStyleBackColor = true;
            this.btnOptimo.Click += new System.EventHandler(this.btnOptimo_Click);
            // 
            // btnCuadruploTriplo
            // 
            this.btnCuadruploTriplo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadruploTriplo.Location = new System.Drawing.Point(154, 73);
            this.btnCuadruploTriplo.Name = "btnCuadruploTriplo";
            this.btnCuadruploTriplo.Size = new System.Drawing.Size(116, 36);
            this.btnCuadruploTriplo.TabIndex = 19;
            this.btnCuadruploTriplo.Text = "Cuadruplos";
            this.btnCuadruploTriplo.UseVisualStyleBackColor = true;
            this.btnCuadruploTriplo.Click += new System.EventHandler(this.btnCuadruploTriplo_Click);
            // 
            // btnInPrePosFija
            // 
            this.btnInPrePosFija.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPrePosFija.Location = new System.Drawing.Point(6, 73);
            this.btnInPrePosFija.Name = "btnInPrePosFija";
            this.btnInPrePosFija.Size = new System.Drawing.Size(142, 36);
            this.btnInPrePosFija.TabIndex = 18;
            this.btnInPrePosFija.Text = "Notación Postfija";
            this.btnInPrePosFija.UseVisualStyleBackColor = true;
            this.btnInPrePosFija.Click += new System.EventHandler(this.btnInPrePosFija_Click);
            // 
            // panelCodigo
            // 
            this.panelCodigo.AutoScroll = true;
            this.panelCodigo.Controls.Add(this.dtgCuadruplo);
            this.panelCodigo.Controls.Add(this.label16);
            this.panelCodigo.Controls.Add(this.rchCodigoObjeto);
            this.panelCodigo.Controls.Add(this.groupBox1);
            this.panelCodigo.Controls.Add(this.dtgViewOptimizada);
            this.panelCodigo.Controls.Add(this.groupBox3);
            this.panelCodigo.Location = new System.Drawing.Point(12, 2);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(1220, 481);
            this.panelCodigo.TabIndex = 6;
            this.panelCodigo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCodigo_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1430, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 21);
            this.label16.TabIndex = 16;
            this.label16.Text = "Ensamblador";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // rchCodigoObjeto
            // 
            this.rchCodigoObjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rchCodigoObjeto.Location = new System.Drawing.Point(1430, 41);
            this.rchCodigoObjeto.Name = "rchCodigoObjeto";
            this.rchCodigoObjeto.ReadOnly = true;
            this.rchCodigoObjeto.Size = new System.Drawing.Size(474, 446);
            this.rchCodigoObjeto.TabIndex = 15;
            this.rchCodigoObjeto.Text = "";
            this.rchCodigoObjeto.WordWrap = false;
            // 
            // dtgViewOptimizada
            // 
            this.dtgViewOptimizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewOptimizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgViewOptimizada.Location = new System.Drawing.Point(1646, 393);
            this.dtgViewOptimizada.Name = "dtgViewOptimizada";
            this.dtgViewOptimizada.Size = new System.Drawing.Size(10, 10);
            this.dtgViewOptimizada.TabIndex = 13;
            this.dtgViewOptimizada.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Indice";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dato Objeto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dato Fuente 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dato Fuente 2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Operador";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rchConsola3);
            this.groupBox3.Controls.Add(this.rchConsola2);
            this.groupBox3.Controls.Add(this.rchConsola1);
            this.groupBox3.Location = new System.Drawing.Point(11, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 196);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(928, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Transformacion Codigo Intermedio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Analisis Semantico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Analisis Sintactico";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Analisis Lexico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rchConsola3
            // 
            this.rchConsola3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchConsola3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rchConsola3.Location = new System.Drawing.Point(389, 32);
            this.rchConsola3.Name = "rchConsola3";
            this.rchConsola3.ReadOnly = true;
            this.rchConsola3.Size = new System.Drawing.Size(185, 64);
            this.rchConsola3.TabIndex = 2;
            this.rchConsola3.Text = "";
            // 
            // rchConsola2
            // 
            this.rchConsola2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchConsola2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rchConsola2.Location = new System.Drawing.Point(198, 32);
            this.rchConsola2.Name = "rchConsola2";
            this.rchConsola2.ReadOnly = true;
            this.rchConsola2.Size = new System.Drawing.Size(185, 64);
            this.rchConsola2.TabIndex = 1;
            this.rchConsola2.Text = "";
            // 
            // rchConsola1
            // 
            this.rchConsola1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchConsola1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rchConsola1.Location = new System.Drawing.Point(7, 32);
            this.rchConsola1.Name = "rchConsola1";
            this.rchConsola1.ReadOnly = true;
            this.rchConsola1.Size = new System.Drawing.Size(185, 64);
            this.rchConsola1.TabIndex = 0;
            this.rchConsola1.Text = "";
            // 
            // panelBotones
            // 
            this.panelBotones.AutoScroll = true;
            this.panelBotones.Controls.Add(this.groupBox2);
            this.panelBotones.Location = new System.Drawing.Point(12, 489);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(760, 129);
            this.panelBotones.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.rchAnalisisSemantica);
            this.groupBox4.Controls.Add(this.rchAnalisisSintactico);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rhcAnalisisLexico);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(3, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 625);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Analisis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Sintactico";
            // 
            // rchAnalisisSemantica
            // 
            this.rchAnalisisSemantica.BackColor = System.Drawing.Color.Orange;
            this.rchAnalisisSemantica.Location = new System.Drawing.Point(10, 434);
            this.rchAnalisisSemantica.Name = "rchAnalisisSemantica";
            this.rchAnalisisSemantica.ReadOnly = true;
            this.rchAnalisisSemantica.Size = new System.Drawing.Size(184, 185);
            this.rchAnalisisSemantica.TabIndex = 4;
            this.rchAnalisisSemantica.Text = "";
            this.rchAnalisisSemantica.WordWrap = false;
            // 
            // rchAnalisisSintactico
            // 
            this.rchAnalisisSintactico.BackColor = System.Drawing.Color.Orange;
            this.rchAnalisisSintactico.Location = new System.Drawing.Point(10, 243);
            this.rchAnalisisSintactico.Name = "rchAnalisisSintactico";
            this.rchAnalisisSintactico.ReadOnly = true;
            this.rchAnalisisSintactico.Size = new System.Drawing.Size(184, 185);
            this.rchAnalisisSintactico.TabIndex = 3;
            this.rchAnalisisSintactico.Text = "";
            this.rchAnalisisSintactico.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sintactico";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rhcAnalisisLexico
            // 
            this.rhcAnalisisLexico.BackColor = System.Drawing.Color.Orange;
            this.rhcAnalisisLexico.Location = new System.Drawing.Point(10, 52);
            this.rhcAnalisisLexico.Name = "rhcAnalisisLexico";
            this.rhcAnalisisLexico.Size = new System.Drawing.Size(184, 185);
            this.rhcAnalisisLexico.TabIndex = 1;
            this.rhcAnalisisLexico.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lexico";
            // 
            // panelCaja
            // 
            this.panelCaja.AutoScroll = true;
            this.panelCaja.Controls.Add(this.groupBox4);
            this.panelCaja.Location = new System.Drawing.Point(786, 2);
            this.panelCaja.Name = "panelCaja";
            this.panelCaja.Size = new System.Drawing.Size(421, 638);
            this.panelCaja.TabIndex = 15;
            this.panelCaja.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1229, 648);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelCaja);
            this.Controls.Add(this.panelCodigo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis de lenguaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuadruplo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewOptimizada)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelCaja.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox rchTexto;
		private System.Windows.Forms.RichTextBox rchLexico;
		private System.Windows.Forms.RichTextBox rchSintactico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAnalizar;
		private System.Windows.Forms.Button btnLexicar;
		private System.Windows.Forms.Button btnSintactizar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panelCodigo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox rchSemantico;
		private System.Windows.Forms.Panel panelBotones;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dtgCuadruplo;
		private System.Windows.Forms.RichTextBox rchPosPrefijo;
		private System.Windows.Forms.Button btnInPrePosFija;
		private System.Windows.Forms.Button btnCuadruploTriplo;
		private System.Windows.Forms.DataGridViewTextBoxColumn DtgColIndice;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgColDatoObjeto;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgColDatoFuente1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgColDatoFuente2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtgColOperador;
		private System.Windows.Forms.Button btnObjeto;
		private System.Windows.Forms.Button btnOptimo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RichTextBox rchCodigoObjeto;
		private System.Windows.Forms.DataGridView dtgViewOptimizada;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchConsola3;
        private System.Windows.Forms.RichTextBox rchConsola2;
        private System.Windows.Forms.RichTextBox rchConsola1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchAnalisisSemantica;
        private System.Windows.Forms.RichTextBox rchAnalisisSintactico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rhcAnalisisLexico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelCaja;
    }
}

