
namespace AutomatedWorkplace.Components
{
    partial class Tasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.teacher = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.title.Location = new System.Drawing.Point(32, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(77, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.description.Location = new System.Drawing.Point(35, 208);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(559, 234);
            this.description.TabIndex = 1;
            this.description.Text = "description";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.link.Location = new System.Drawing.Point(35, 80);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(37, 22);
            this.link.TabIndex = 2;
            this.link.TabStop = true;
            this.link.Text = "link";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.teacher.Location = new System.Drawing.Point(34, 125);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(84, 27);
            this.teacher.TabIndex = 3;
            this.teacher.Text = "Teacher";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.subject.Location = new System.Drawing.Point(34, 167);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(80, 27);
            this.subject.TabIndex = 4;
            this.subject.Text = "Subject";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.subject);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.link);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Name = "Tasks";
            this.Size = new System.Drawing.Size(629, 514);
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label subject;
    }
}
