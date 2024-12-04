namespace EFLing_0
{
    partial class Form1
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
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.BtnWhere = new System.Windows.Forms.Button();
            this.BtnOrderBy = new System.Windows.Forms.Button();
            this.BtnTake = new System.Windows.Forms.Button();
            this.BtnSkip = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnSingle = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnContains = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnVia = new System.Windows.Forms.Button();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.BtnAny = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(48, 33);
            this.DgvResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowHeadersWidth = 51;
            this.DgvResult.RowTemplate.Height = 24;
            this.DgvResult.Size = new System.Drawing.Size(1250, 466);
            this.DgvResult.TabIndex = 0;
            // 
            // BtnWhere
            // 
            this.BtnWhere.Location = new System.Drawing.Point(48, 537);
            this.BtnWhere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnWhere.Name = "BtnWhere";
            this.BtnWhere.Size = new System.Drawing.Size(94, 32);
            this.BtnWhere.TabIndex = 1;
            this.BtnWhere.Text = "Where";
            this.BtnWhere.UseVisualStyleBackColor = true;
            this.BtnWhere.Click += new System.EventHandler(this.BtnWhere_Click);
            // 
            // BtnOrderBy
            // 
            this.BtnOrderBy.Location = new System.Drawing.Point(171, 537);
            this.BtnOrderBy.Name = "BtnOrderBy";
            this.BtnOrderBy.Size = new System.Drawing.Size(130, 32);
            this.BtnOrderBy.TabIndex = 2;
            this.BtnOrderBy.Text = "Order by";
            this.BtnOrderBy.UseVisualStyleBackColor = true;
            this.BtnOrderBy.Click += new System.EventHandler(this.BtnOrderBy_Click);
            // 
            // BtnTake
            // 
            this.BtnTake.Location = new System.Drawing.Point(336, 542);
            this.BtnTake.Name = "BtnTake";
            this.BtnTake.Size = new System.Drawing.Size(108, 27);
            this.BtnTake.TabIndex = 3;
            this.BtnTake.Text = "Take";
            this.BtnTake.UseVisualStyleBackColor = true;
            this.BtnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // BtnSkip
            // 
            this.BtnSkip.Location = new System.Drawing.Point(488, 544);
            this.BtnSkip.Name = "BtnSkip";
            this.BtnSkip.Size = new System.Drawing.Size(115, 32);
            this.BtnSkip.TabIndex = 4;
            this.BtnSkip.Text = "Skip";
            this.BtnSkip.UseVisualStyleBackColor = true;
            this.BtnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(651, 542);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(99, 34);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1325, 64);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 28);
            this.TxtId.TabIndex = 6;
            // 
            // BtnSingle
            // 
            this.BtnSingle.Location = new System.Drawing.Point(801, 548);
            this.BtnSingle.Name = "BtnSingle";
            this.BtnSingle.Size = new System.Drawing.Size(106, 28);
            this.BtnSingle.TabIndex = 7;
            this.BtnSingle.Text = "Single";
            this.BtnSingle.UseVisualStyleBackColor = true;
            this.BtnSingle.Click += new System.EventHandler(this.BtnSingle_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(951, 544);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(153, 37);
            this.BtnList.TabIndex = 8;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnContains
            // 
            this.BtnContains.Location = new System.Drawing.Point(48, 606);
            this.BtnContains.Name = "BtnContains";
            this.BtnContains.Size = new System.Drawing.Size(169, 42);
            this.BtnContains.TabIndex = 9;
            this.BtnContains.Text = "Contains";
            this.BtnContains.UseVisualStyleBackColor = true;
            this.BtnContains.Click += new System.EventHandler(this.BtnContains_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(1234, 660);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(155, 28);
            this.TxtSearch.TabIndex = 10;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnVia
            // 
            this.BtnVia.Location = new System.Drawing.Point(259, 606);
            this.BtnVia.Name = "BtnVia";
            this.BtnVia.Size = new System.Drawing.Size(148, 42);
            this.BtnVia.TabIndex = 11;
            this.BtnVia.Text = "Via";
            this.BtnVia.UseVisualStyleBackColor = true;
            this.BtnVia.Click += new System.EventHandler(this.BtnVia_Click);
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(259, 665);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(148, 28);
            this.TxtKategori.TabIndex = 12;
            // 
            // BtnAny
            // 
            this.BtnAny.Location = new System.Drawing.Point(442, 611);
            this.BtnAny.Name = "BtnAny";
            this.BtnAny.Size = new System.Drawing.Size(131, 37);
            this.BtnAny.TabIndex = 13;
            this.BtnAny.Text = "Any";
            this.BtnAny.UseVisualStyleBackColor = true;
            this.BtnAny.Click += new System.EventHandler(this.BtnAny_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(442, 655);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 28);
            this.TxtIsim.TabIndex = 14;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(442, 689);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(100, 28);
            this.TxtSoyIsim.TabIndex = 14;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(637, 616);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(113, 32);
            this.BtnSelect.TabIndex = 15;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 848);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.BtnAny);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.BtnVia);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnContains);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSingle);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnSkip);
            this.Controls.Add(this.BtnTake);
            this.Controls.Add(this.BtnOrderBy);
            this.Controls.Add(this.BtnWhere);
            this.Controls.Add(this.DgvResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.Button BtnWhere;
        private System.Windows.Forms.Button BtnOrderBy;
        private System.Windows.Forms.Button BtnTake;
        private System.Windows.Forms.Button BtnSkip;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnSingle;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnContains;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnVia;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Button BtnAny;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.Button BtnSelect;
    }
}

