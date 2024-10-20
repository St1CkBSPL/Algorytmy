namespace PracaDomowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.listBoxLiczby = new System.Windows.Forms.ListBox();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(611, 115);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(112, 22);
            this.numericUpDown.TabIndex = 1;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(303, 114);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(288, 23);
            this.btnGeneruj.TabIndex = 2;
            this.btnGeneruj.Text = "btnGeneruj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // listBoxLiczby
            // 
            this.listBoxLiczby.FormattingEnabled = true;
            this.listBoxLiczby.ItemHeight = 16;
            this.listBoxLiczby.Location = new System.Drawing.Point(303, 50);
            this.listBoxLiczby.Name = "listBoxLiczby";
            this.listBoxLiczby.Size = new System.Drawing.Size(420, 36);
            this.listBoxLiczby.TabIndex = 4;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(75, 325);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(142, 23);
            this.btnBubbleSort.TabIndex = 5;
            this.btnBubbleSort.Text = "btnBubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertSort
            // 
            this.btnInsertSort.Location = new System.Drawing.Point(248, 325);
            this.btnInsertSort.Name = "btnInsertSort";
            this.btnInsertSort.Size = new System.Drawing.Size(152, 23);
            this.btnInsertSort.TabIndex = 6;
            this.btnInsertSort.Text = "btnInsertSort";
            this.btnInsertSort.UseVisualStyleBackColor = true;
            this.btnInsertSort.Click += new System.EventHandler(this.btnInsertSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(423, 325);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(132, 23);
            this.btnMergeSort.TabIndex = 7;
            this.btnMergeSort.Text = "btnMergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(593, 324);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(130, 24);
            this.btnSelectionSort.TabIndex = 8;
            this.btnSelectionSort.Text = "btnSelectionSort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.listBoxLiczby);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.ListBox listBoxLiczby;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnSelectionSort;
    }
}

