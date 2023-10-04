namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnload = new Button();
            dantoc = new Label();
            ketqua = new Label();
            cblist = new ComboBox();
            btnshow = new Button();
            SuspendLayout();
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnload.Location = new Point(165, 56);
            btnload.Name = "btnload";
            btnload.Size = new Size(376, 46);
            btnload.TabIndex = 0;
            btnload.Text = "Load dữ liệu ComboBox";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // dantoc
            // 
            dantoc.AutoSize = true;
            dantoc.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dantoc.Location = new Point(42, 145);
            dantoc.Name = "dantoc";
            dantoc.Size = new Size(97, 32);
            dantoc.TabIndex = 1;
            dantoc.Text = "Dân tộc";
            // 
            // ketqua
            // 
            ketqua.AutoSize = true;
            ketqua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ketqua.Location = new Point(165, 319);
            ketqua.Name = "ketqua";
            ketqua.Size = new Size(108, 32);
            ketqua.TabIndex = 2;
            ketqua.Text = "Kết quả: ";
            // 
            // cblist
            // 
            cblist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cblist.FormattingEnabled = true;
            cblist.Location = new Point(165, 145);
            cblist.Name = "cblist";
            cblist.Size = new Size(427, 36);
            cblist.TabIndex = 3;
            cblist.SelectedIndexChanged += cblist_SelectedIndexChanged;
            // 
            // btnshow
            // 
            btnshow.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnshow.Location = new Point(165, 226);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(191, 46);
            btnshow.TabIndex = 4;
            btnshow.Text = "Hiển thị";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnshow);
            Controls.Add(cblist);
            Controls.Add(ketqua);
            Controls.Add(dantoc);
            Controls.Add(btnload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnload;
        private Label dantoc;
        private Label ketqua;
        private ComboBox cblist;
        private Button btnshow;
    }
}