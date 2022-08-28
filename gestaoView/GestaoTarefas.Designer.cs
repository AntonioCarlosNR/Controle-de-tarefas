
namespace Controle_de_tarefas.gestaoView
{
    partial class GestaoTarefas
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
            this.idtarefa = new System.Windows.Forms.Label();
            this.textBoxIdTarefa = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.tempoestimado = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.editar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idtarefa
            // 
            this.idtarefa.AutoSize = true;
            this.idtarefa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idtarefa.Location = new System.Drawing.Point(33, 29);
            this.idtarefa.Name = "idtarefa";
            this.idtarefa.Size = new System.Drawing.Size(85, 28);
            this.idtarefa.TabIndex = 0;
            this.idtarefa.Text = "Id Tarefa";
            // 
            // textBoxIdTarefa
            // 
            this.textBoxIdTarefa.Location = new System.Drawing.Point(124, 29);
            this.textBoxIdTarefa.Name = "textBoxIdTarefa";
            this.textBoxIdTarefa.Size = new System.Drawing.Size(125, 27);
            this.textBoxIdTarefa.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(256, 27);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(94, 29);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descricao.Location = new System.Drawing.Point(33, 85);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(100, 28);
            this.descricao.TabIndex = 3;
            this.descricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(33, 116);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(383, 27);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // tempoestimado
            // 
            this.tempoestimado.AutoSize = true;
            this.tempoestimado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempoestimado.Location = new System.Drawing.Point(33, 157);
            this.tempoestimado.Name = "tempoestimado";
            this.tempoestimado.Size = new System.Drawing.Size(161, 28);
            this.tempoestimado.TabIndex = 5;
            this.tempoestimado.Text = "Tempo Estimado:";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoria.Location = new System.Drawing.Point(33, 219);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(101, 28);
            this.categoria.TabIndex = 6;
            this.categoria.Text = "Categoria:";
            // 
            // situacao
            // 
            this.situacao.AutoSize = true;
            this.situacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.situacao.Location = new System.Drawing.Point(235, 219);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(91, 28);
            this.situacao.TabIndex = 7;
            this.situacao.Text = "Situação:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Manutenção",
            "Desenvolvimento",
            "Suporte"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(33, 251);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(180, 36);
            this.comboBoxCategoria.TabIndex = 8;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Aberta",
            "Em Andamento",
            "Fechada"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(235, 251);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(181, 36);
            this.comboBoxSituacao.TabIndex = 9;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(174, 315);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(109, 42);
            this.editar.TabIndex = 11;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(310, 315);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(106, 42);
            this.excluir.TabIndex = 12;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(174, 386);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(109, 34);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // criar
            // 
            this.criar.Location = new System.Drawing.Point(33, 315);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(112, 42);
            this.criar.TabIndex = 14;
            this.criar.Text = "Criar Tarefa";
            this.criar.UseVisualStyleBackColor = true;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // GestaoTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 443);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.tempoestimado);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.textBoxIdTarefa);
            this.Controls.Add(this.idtarefa);
            this.Name = "GestaoTarefas";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idtarefa;
        private System.Windows.Forms.TextBox textBoxIdTarefa;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label tempoestimado;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label situacao;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button criar;
    }
}