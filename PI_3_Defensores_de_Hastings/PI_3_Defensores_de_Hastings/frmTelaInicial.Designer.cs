﻿namespace PI_3_Defensores_de_Hastings
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirLobby = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblControleVersao = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirLobby
            // 
            this.btnAbrirLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbrirLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirLobby.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrirLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirLobby.Font = new System.Drawing.Font("Sitka Display", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAbrirLobby.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirLobby.Location = new System.Drawing.Point(352, 421);
            this.btnAbrirLobby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrirLobby.Name = "btnAbrirLobby";
            this.btnAbrirLobby.Size = new System.Drawing.Size(227, 72);
            this.btnAbrirLobby.TabIndex = 0;
            this.btnAbrirLobby.TabStop = false;
            this.btnAbrirLobby.Text = "Lobby";
            this.btnAbrirLobby.UseVisualStyleBackColor = false;
            this.btnAbrirLobby.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(267, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(390, 113);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "King Me!";
            // 
            // lblControleVersao
            // 
            this.lblControleVersao.AutoSize = true;
            this.lblControleVersao.Font = new System.Drawing.Font("Arial", 16F);
            this.lblControleVersao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblControleVersao.Location = new System.Drawing.Point(876, 610);
            this.lblControleVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControleVersao.Name = "lblControleVersao";
            this.lblControleVersao.Size = new System.Drawing.Size(81, 25);
            this.lblControleVersao.TabIndex = 2;
            this.lblControleVersao.Text = "Versao";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Sitka Display", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.Black;
            this.btnCriarPartida.Location = new System.Drawing.Point(352, 251);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(227, 76);
            this.btnCriarPartida.TabIndex = 3;
            this.btnCriarPartida.TabStop = false;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(934, 658);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblControleVersao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAbrirLobby);
            this.Font = new System.Drawing.Font("Sitka Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Tela2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirLobby;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblControleVersao;
        private System.Windows.Forms.Button btnCriarPartida;
    }
}