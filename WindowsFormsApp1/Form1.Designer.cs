namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pencil = new System.Windows.Forms.Button();
            this.squre = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.hexagon = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.penplus = new System.Windows.Forms.Button();
            this.penmin = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(3, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pencil
            // 
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.Location = new System.Drawing.Point(22, 13);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(102, 93);
            this.pencil.TabIndex = 1;
            this.pencil.UseVisualStyleBackColor = true;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // squre
            // 
            this.squre.Image = ((System.Drawing.Image)(resources.GetObject("squre.Image")));
            this.squre.Location = new System.Drawing.Point(142, 13);
            this.squre.Name = "squre";
            this.squre.Size = new System.Drawing.Size(105, 93);
            this.squre.TabIndex = 2;
            this.squre.UseVisualStyleBackColor = true;
            this.squre.Click += new System.EventHandler(this.square_Click);
            // 
            // circle
            // 
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(265, 13);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(105, 93);
            this.circle.TabIndex = 3;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // triangle
            // 
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(386, 13);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(105, 93);
            this.triangle.TabIndex = 4;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // hexagon
            // 
            this.hexagon.Image = ((System.Drawing.Image)(resources.GetObject("hexagon.Image")));
            this.hexagon.Location = new System.Drawing.Point(506, 13);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(105, 93);
            this.hexagon.TabIndex = 5;
            this.hexagon.UseVisualStyleBackColor = true;
            this.hexagon.Click += new System.EventHandler(this.hexagon_Click);
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(650, 1);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(75, 31);
            this.fill.TabIndex = 6;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // penplus
            // 
            this.penplus.Location = new System.Drawing.Point(746, 40);
            this.penplus.Name = "penplus";
            this.penplus.Size = new System.Drawing.Size(75, 30);
            this.penplus.TabIndex = 7;
            this.penplus.Text = "Pen +";
            this.penplus.UseVisualStyleBackColor = true;
            this.penplus.Click += new System.EventHandler(this.penplus_Click);
            // 
            // penmin
            // 
            this.penmin.Location = new System.Drawing.Point(746, 4);
            this.penmin.Name = "penmin";
            this.penmin.Size = new System.Drawing.Size(75, 30);
            this.penmin.TabIndex = 8;
            this.penmin.Text = "Pen -";
            this.penmin.UseVisualStyleBackColor = true;
            this.penmin.Click += new System.EventHandler(this.penmin_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(746, 77);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 29);
            this.Undo.TabIndex = 9;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(650, 38);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 27);
            this.color.TabIndex = 10;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(650, 71);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(82, 35);
            this.DeleteAll.TabIndex = 11;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Size:";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(863, 8);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(16, 17);
            this.sizeLbl.TabIndex = 13;
            this.sizeLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 523);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.penmin);
            this.Controls.Add(this.penplus);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.hexagon);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.squre);
            this.Controls.Add(this.pencil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button squre;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button penplus;
        private System.Windows.Forms.Button penmin;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeLbl;
    }
}

