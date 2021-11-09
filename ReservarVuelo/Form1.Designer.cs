
namespace ReservarVuelo
{
    partial class VentanaGeneral
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
            this.cbAeropuertoNombreOrigen = new System.Windows.Forms.ComboBox();
            this.lbAeropuertoNombreOrigen = new System.Windows.Forms.Label();
            this.cbAeropuertoNombreDestino = new System.Windows.Forms.ComboBox();
            this.lbAeropuertoNombreDestino = new System.Windows.Forms.Label();
            this.lbAeropuertoNombreOrigenElegido = new System.Windows.Forms.Label();
            this.lbAeropuertoNombreDestinoElegido = new System.Windows.Forms.Label();
            this.lbAerolineasDisponibles = new System.Windows.Forms.Label();
            this.cbAerolineasDisponibles = new System.Windows.Forms.ComboBox();
            this.lbAerolineaDisponibleElegida = new System.Windows.Forms.Label();
            this.lbFechasDisponibles = new System.Windows.Forms.Label();
            this.cbFechasDisponibles = new System.Windows.Forms.ComboBox();
            this.lbFechaDisponibleElegida = new System.Windows.Forms.Label();
            this.lbAdultos = new System.Windows.Forms.Label();
            this.nUdAdultos = new System.Windows.Forms.NumericUpDown();
            this.lbAdultosElegidos = new System.Windows.Forms.Label();
            this.lbNiños = new System.Windows.Forms.Label();
            this.nUdNinios = new System.Windows.Forms.NumericUpDown();
            this.lbNiniosElegidos = new System.Windows.Forms.Label();
            this.btReservar = new System.Windows.Forms.Button();
            this.lbReservaElegida = new System.Windows.Forms.Label();
            this.cbEquipaje = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUdAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdNinios)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAeropuertoNombreOrigen
            // 
            this.cbAeropuertoNombreOrigen.FormattingEnabled = true;
            this.cbAeropuertoNombreOrigen.Location = new System.Drawing.Point(113, 91);
            this.cbAeropuertoNombreOrigen.Name = "cbAeropuertoNombreOrigen";
            this.cbAeropuertoNombreOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbAeropuertoNombreOrigen.TabIndex = 0;
            this.cbAeropuertoNombreOrigen.SelectedValueChanged += new System.EventHandler(this.cbAeropuertoNombreOrigen_SelectedValueChanged);
            // 
            // lbAeropuertoNombreOrigen
            // 
            this.lbAeropuertoNombreOrigen.AutoSize = true;
            this.lbAeropuertoNombreOrigen.Location = new System.Drawing.Point(113, 72);
            this.lbAeropuertoNombreOrigen.Name = "lbAeropuertoNombreOrigen";
            this.lbAeropuertoNombreOrigen.Size = new System.Drawing.Size(44, 13);
            this.lbAeropuertoNombreOrigen.TabIndex = 1;
            this.lbAeropuertoNombreOrigen.Text = "Desde: ";
            // 
            // cbAeropuertoNombreDestino
            // 
            this.cbAeropuertoNombreDestino.FormattingEnabled = true;
            this.cbAeropuertoNombreDestino.Location = new System.Drawing.Point(110, 151);
            this.cbAeropuertoNombreDestino.Name = "cbAeropuertoNombreDestino";
            this.cbAeropuertoNombreDestino.Size = new System.Drawing.Size(121, 21);
            this.cbAeropuertoNombreDestino.TabIndex = 2;
            this.cbAeropuertoNombreDestino.SelectedValueChanged += new System.EventHandler(this.cbAeropuertoNombreDestino_SelectedValueChanged);
            // 
            // lbAeropuertoNombreDestino
            // 
            this.lbAeropuertoNombreDestino.AutoSize = true;
            this.lbAeropuertoNombreDestino.Location = new System.Drawing.Point(110, 132);
            this.lbAeropuertoNombreDestino.Name = "lbAeropuertoNombreDestino";
            this.lbAeropuertoNombreDestino.Size = new System.Drawing.Size(38, 13);
            this.lbAeropuertoNombreDestino.TabIndex = 3;
            this.lbAeropuertoNombreDestino.Text = "Hasta:";
            // 
            // lbAeropuertoNombreOrigenElegido
            // 
            this.lbAeropuertoNombreOrigenElegido.AutoSize = true;
            this.lbAeropuertoNombreOrigenElegido.Location = new System.Drawing.Point(277, 98);
            this.lbAeropuertoNombreOrigenElegido.Name = "lbAeropuertoNombreOrigenElegido";
            this.lbAeropuertoNombreOrigenElegido.Size = new System.Drawing.Size(44, 13);
            this.lbAeropuertoNombreOrigenElegido.TabIndex = 4;
            this.lbAeropuertoNombreOrigenElegido.Text = "Origen: ";
            // 
            // lbAeropuertoNombreDestinoElegido
            // 
            this.lbAeropuertoNombreDestinoElegido.AutoSize = true;
            this.lbAeropuertoNombreDestinoElegido.Location = new System.Drawing.Point(277, 158);
            this.lbAeropuertoNombreDestinoElegido.Name = "lbAeropuertoNombreDestinoElegido";
            this.lbAeropuertoNombreDestinoElegido.Size = new System.Drawing.Size(46, 13);
            this.lbAeropuertoNombreDestinoElegido.TabIndex = 5;
            this.lbAeropuertoNombreDestinoElegido.Text = "Destino:";
            // 
            // lbAerolineasDisponibles
            // 
            this.lbAerolineasDisponibles.AutoSize = true;
            this.lbAerolineasDisponibles.Location = new System.Drawing.Point(110, 198);
            this.lbAerolineasDisponibles.Name = "lbAerolineasDisponibles";
            this.lbAerolineasDisponibles.Size = new System.Drawing.Size(56, 13);
            this.lbAerolineasDisponibles.TabIndex = 6;
            this.lbAerolineasDisponibles.Text = "Aerolineas";
            // 
            // cbAerolineasDisponibles
            // 
            this.cbAerolineasDisponibles.FormattingEnabled = true;
            this.cbAerolineasDisponibles.Location = new System.Drawing.Point(110, 224);
            this.cbAerolineasDisponibles.Name = "cbAerolineasDisponibles";
            this.cbAerolineasDisponibles.Size = new System.Drawing.Size(121, 21);
            this.cbAerolineasDisponibles.TabIndex = 7;
            this.cbAerolineasDisponibles.SelectedValueChanged += new System.EventHandler(this.cbAerolineasDisponibles_SelectedValueChanged);
            // 
            // lbAerolineaDisponibleElegida
            // 
            this.lbAerolineaDisponibleElegida.AutoSize = true;
            this.lbAerolineaDisponibleElegida.Location = new System.Drawing.Point(277, 231);
            this.lbAerolineaDisponibleElegida.Name = "lbAerolineaDisponibleElegida";
            this.lbAerolineaDisponibleElegida.Size = new System.Drawing.Size(54, 13);
            this.lbAerolineaDisponibleElegida.TabIndex = 8;
            this.lbAerolineaDisponibleElegida.Text = "Aerolinea:";
            // 
            // lbFechasDisponibles
            // 
            this.lbFechasDisponibles.AutoSize = true;
            this.lbFechasDisponibles.Location = new System.Drawing.Point(113, 271);
            this.lbFechasDisponibles.Name = "lbFechasDisponibles";
            this.lbFechasDisponibles.Size = new System.Drawing.Size(40, 13);
            this.lbFechasDisponibles.TabIndex = 9;
            this.lbFechasDisponibles.Text = "Fecha:";
            // 
            // cbFechasDisponibles
            // 
            this.cbFechasDisponibles.FormattingEnabled = true;
            this.cbFechasDisponibles.Location = new System.Drawing.Point(113, 299);
            this.cbFechasDisponibles.Name = "cbFechasDisponibles";
            this.cbFechasDisponibles.Size = new System.Drawing.Size(121, 21);
            this.cbFechasDisponibles.TabIndex = 10;
            // 
            // lbFechaDisponibleElegida
            // 
            this.lbFechaDisponibleElegida.AutoSize = true;
            this.lbFechaDisponibleElegida.Location = new System.Drawing.Point(277, 302);
            this.lbFechaDisponibleElegida.Name = "lbFechaDisponibleElegida";
            this.lbFechaDisponibleElegida.Size = new System.Drawing.Size(40, 13);
            this.lbFechaDisponibleElegida.TabIndex = 11;
            this.lbFechaDisponibleElegida.Text = "Fecha:";
            // 
            // lbAdultos
            // 
            this.lbAdultos.AutoSize = true;
            this.lbAdultos.Location = new System.Drawing.Point(116, 337);
            this.lbAdultos.Name = "lbAdultos";
            this.lbAdultos.Size = new System.Drawing.Size(48, 13);
            this.lbAdultos.TabIndex = 12;
            this.lbAdultos.Text = "Adultos: ";
            // 
            // nUdAdultos
            // 
            this.nUdAdultos.Location = new System.Drawing.Point(116, 362);
            this.nUdAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdAdultos.Name = "nUdAdultos";
            this.nUdAdultos.Size = new System.Drawing.Size(120, 20);
            this.nUdAdultos.TabIndex = 13;
            this.nUdAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbAdultosElegidos
            // 
            this.lbAdultosElegidos.AutoSize = true;
            this.lbAdultosElegidos.Location = new System.Drawing.Point(283, 368);
            this.lbAdultosElegidos.Name = "lbAdultosElegidos";
            this.lbAdultosElegidos.Size = new System.Drawing.Size(48, 13);
            this.lbAdultosElegidos.TabIndex = 14;
            this.lbAdultosElegidos.Text = "Adultos: ";
            // 
            // lbNiños
            // 
            this.lbNiños.AutoSize = true;
            this.lbNiños.Location = new System.Drawing.Point(115, 409);
            this.lbNiños.Name = "lbNiños";
            this.lbNiños.Size = new System.Drawing.Size(42, 13);
            this.lbNiños.TabIndex = 15;
            this.lbNiños.Text = "Niñ@s:";
            // 
            // nUdNinios
            // 
            this.nUdNinios.Location = new System.Drawing.Point(115, 436);
            this.nUdNinios.Name = "nUdNinios";
            this.nUdNinios.Size = new System.Drawing.Size(120, 20);
            this.nUdNinios.TabIndex = 16;
            // 
            // lbNiniosElegidos
            // 
            this.lbNiniosElegidos.AutoSize = true;
            this.lbNiniosElegidos.Location = new System.Drawing.Point(282, 442);
            this.lbNiniosElegidos.Name = "lbNiniosElegidos";
            this.lbNiniosElegidos.Size = new System.Drawing.Size(39, 13);
            this.lbNiniosElegidos.TabIndex = 17;
            this.lbNiniosElegidos.Text = "Nin@s";
            // 
            // btReservar
            // 
            this.btReservar.Location = new System.Drawing.Point(116, 526);
            this.btReservar.Name = "btReservar";
            this.btReservar.Size = new System.Drawing.Size(75, 23);
            this.btReservar.TabIndex = 18;
            this.btReservar.Text = "RESERVAR";
            this.btReservar.UseVisualStyleBackColor = true;
            this.btReservar.Click += new System.EventHandler(this.btReservar_Click);
            // 
            // lbReservaElegida
            // 
            this.lbReservaElegida.AutoSize = true;
            this.lbReservaElegida.Location = new System.Drawing.Point(584, 151);
            this.lbReservaElegida.Name = "lbReservaElegida";
            this.lbReservaElegida.Size = new System.Drawing.Size(61, 13);
            this.lbReservaElegida.TabIndex = 19;
            this.lbReservaElegida.Text = "RESERVA:";
            // 
            // cbEquipaje
            // 
            this.cbEquipaje.AutoSize = true;
            this.cbEquipaje.Location = new System.Drawing.Point(113, 482);
            this.cbEquipaje.Name = "cbEquipaje";
            this.cbEquipaje.Size = new System.Drawing.Size(73, 17);
            this.cbEquipaje.TabIndex = 20;
            this.cbEquipaje.Text = "Equipaje?";
            this.cbEquipaje.UseVisualStyleBackColor = true;
            // 
            // VentanaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::ReservarVuelo.Properties.Resources.cielo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 615);
            this.Controls.Add(this.cbEquipaje);
            this.Controls.Add(this.lbReservaElegida);
            this.Controls.Add(this.btReservar);
            this.Controls.Add(this.lbNiniosElegidos);
            this.Controls.Add(this.nUdNinios);
            this.Controls.Add(this.lbNiños);
            this.Controls.Add(this.lbAdultosElegidos);
            this.Controls.Add(this.nUdAdultos);
            this.Controls.Add(this.lbAdultos);
            this.Controls.Add(this.lbFechaDisponibleElegida);
            this.Controls.Add(this.cbFechasDisponibles);
            this.Controls.Add(this.lbFechasDisponibles);
            this.Controls.Add(this.lbAerolineaDisponibleElegida);
            this.Controls.Add(this.cbAerolineasDisponibles);
            this.Controls.Add(this.lbAerolineasDisponibles);
            this.Controls.Add(this.lbAeropuertoNombreDestinoElegido);
            this.Controls.Add(this.lbAeropuertoNombreOrigenElegido);
            this.Controls.Add(this.lbAeropuertoNombreDestino);
            this.Controls.Add(this.cbAeropuertoNombreDestino);
            this.Controls.Add(this.lbAeropuertoNombreOrigen);
            this.Controls.Add(this.cbAeropuertoNombreOrigen);
            this.Name = "VentanaGeneral";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUdAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdNinios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAeropuertoNombreOrigen;
        private System.Windows.Forms.Label lbAeropuertoNombreOrigen;
        private System.Windows.Forms.ComboBox cbAeropuertoNombreDestino;
        private System.Windows.Forms.Label lbAeropuertoNombreDestino;
        private System.Windows.Forms.Label lbAeropuertoNombreOrigenElegido;
        private System.Windows.Forms.Label lbAeropuertoNombreDestinoElegido;
        private System.Windows.Forms.Label lbAerolineasDisponibles;
        private System.Windows.Forms.ComboBox cbAerolineasDisponibles;
        private System.Windows.Forms.Label lbAerolineaDisponibleElegida;
        private System.Windows.Forms.Label lbFechasDisponibles;
        private System.Windows.Forms.ComboBox cbFechasDisponibles;
        private System.Windows.Forms.Label lbFechaDisponibleElegida;
        private System.Windows.Forms.Label lbAdultos;
        private System.Windows.Forms.NumericUpDown nUdAdultos;
        private System.Windows.Forms.Label lbAdultosElegidos;
        private System.Windows.Forms.Label lbNiños;
        private System.Windows.Forms.NumericUpDown nUdNinios;
        private System.Windows.Forms.Label lbNiniosElegidos;
        private System.Windows.Forms.Button btReservar;
        private System.Windows.Forms.Label lbReservaElegida;
        private System.Windows.Forms.CheckBox cbEquipaje;
    }
}

