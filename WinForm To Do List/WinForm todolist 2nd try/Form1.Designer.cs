namespace WinForm_todolist_2nd_try
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarkAsCompleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxTask
            // 
            this.txtBoxTask.Location = new System.Drawing.Point(12, 398);
            this.txtBoxTask.Name = "txtBoxTask";
            this.txtBoxTask.Size = new System.Drawing.Size(212, 20);
            this.txtBoxTask.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(230, 398);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 21);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 12);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(212, 381);
            this.listBoxTasks.TabIndex = 2;
            this.listBoxTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxTasks_DrawItem);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(230, 41);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(230, 12);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 4;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(230, 371);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(75, 21);
            this.cmbPriority.TabIndex = 6;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set Priority";
            // 
            // btnMarkAsCompleted
            // 
            this.btnMarkAsCompleted.Location = new System.Drawing.Point(230, 70);
            this.btnMarkAsCompleted.Name = "btnMarkAsCompleted";
            this.btnMarkAsCompleted.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAsCompleted.TabIndex = 8;
            this.btnMarkAsCompleted.Text = "Checked";
            this.btnMarkAsCompleted.UseVisualStyleBackColor = true;
            this.btnMarkAsCompleted.Click += new System.EventHandler(this.btnMarkAsCompleted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 430);
            this.Controls.Add(this.btnMarkAsCompleted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtBoxTask);
            this.Name = "Form1";
            this.Text = "To Dos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarkAsCompleted;
    }
}

