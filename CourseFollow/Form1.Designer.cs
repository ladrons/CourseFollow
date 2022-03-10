namespace CourseFollow
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
            this.components = new System.ComponentModel.Container();
            this.txt_LessonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ListTopics = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddTopic = new System.Windows.Forms.Button();
            this.lbl_TotalTopics = new System.Windows.Forms.Label();
            this.btn_StartLesson = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lst_AllTopics = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TopicName = new System.Windows.Forms.TextBox();
            this.txt_LessonDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TopicDesc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_SessionTime = new System.Windows.Forms.Label();
            this.tmr_SessionTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_SelectedLesson = new System.Windows.Forms.Label();
            this.lbl_SelectedTopic = new System.Windows.Forms.Label();
            this.btn_QueryForm = new System.Windows.Forms.Button();
            this.btn_StopStudying = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_LessonName
            // 
            this.txt_LessonName.Location = new System.Drawing.Point(16, 66);
            this.txt_LessonName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_LessonName.Name = "txt_LessonName";
            this.txt_LessonName.Size = new System.Drawing.Size(189, 21);
            this.txt_LessonName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konu Ekleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders Giriniz";
            // 
            // cmb_ListTopics
            // 
            this.cmb_ListTopics.FormattingEnabled = true;
            this.cmb_ListTopics.Location = new System.Drawing.Point(16, 152);
            this.cmb_ListTopics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_ListTopics.Name = "cmb_ListTopics";
            this.cmb_ListTopics.Size = new System.Drawing.Size(166, 23);
            this.cmb_ListTopics.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konu Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ders Takip Sistemi";
            // 
            // btn_AddTopic
            // 
            this.btn_AddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_AddTopic.Location = new System.Drawing.Point(258, 142);
            this.btn_AddTopic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_AddTopic.Name = "btn_AddTopic";
            this.btn_AddTopic.Size = new System.Drawing.Size(88, 27);
            this.btn_AddTopic.TabIndex = 1;
            this.btn_AddTopic.Text = "Konu Ekle";
            this.btn_AddTopic.UseVisualStyleBackColor = true;
            this.btn_AddTopic.Click += new System.EventHandler(this.btn_AddTopic_Click);
            // 
            // lbl_TotalTopics
            // 
            this.lbl_TotalTopics.AutoSize = true;
            this.lbl_TotalTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_TotalTopics.Location = new System.Drawing.Point(353, 150);
            this.lbl_TotalTopics.Name = "lbl_TotalTopics";
            this.lbl_TotalTopics.Size = new System.Drawing.Size(62, 13);
            this.lbl_TotalTopics.TabIndex = 5;
            this.lbl_TotalTopics.Text = "Konu Sayısı";
            // 
            // btn_StartLesson
            // 
            this.btn_StartLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_StartLesson.Location = new System.Drawing.Point(16, 181);
            this.btn_StartLesson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_StartLesson.Name = "btn_StartLesson";
            this.btn_StartLesson.Size = new System.Drawing.Size(112, 26);
            this.btn_StartLesson.TabIndex = 1;
            this.btn_StartLesson.Text = "Çalışmaya Başla";
            this.btn_StartLesson.UseVisualStyleBackColor = true;
            this.btn_StartLesson.Click += new System.EventHandler(this.btn_StartLesson_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(-1, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(602, 10);
            this.label9.TabIndex = 7;
            // 
            // lst_AllTopics
            // 
            this.lst_AllTopics.FormattingEnabled = true;
            this.lst_AllTopics.ItemHeight = 15;
            this.lst_AllTopics.Location = new System.Drawing.Point(258, 175);
            this.lst_AllTopics.Name = "lst_AllTopics";
            this.lst_AllTopics.Size = new System.Drawing.Size(328, 124);
            this.lst_AllTopics.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(228, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 272);
            this.label10.TabIndex = 7;
            // 
            // txt_TopicName
            // 
            this.txt_TopicName.Location = new System.Drawing.Point(258, 66);
            this.txt_TopicName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TopicName.Name = "txt_TopicName";
            this.txt_TopicName.Size = new System.Drawing.Size(189, 21);
            this.txt_TopicName.TabIndex = 0;
            // 
            // txt_LessonDesc
            // 
            this.txt_LessonDesc.Location = new System.Drawing.Point(16, 109);
            this.txt_LessonDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_LessonDesc.Name = "txt_LessonDesc";
            this.txt_LessonDesc.Size = new System.Drawing.Size(189, 21);
            this.txt_LessonDesc.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Açıklama";
            // 
            // txt_TopicDesc
            // 
            this.txt_TopicDesc.Location = new System.Drawing.Point(258, 109);
            this.txt_TopicDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TopicDesc.Name = "txt_TopicDesc";
            this.txt_TopicDesc.Size = new System.Drawing.Size(189, 21);
            this.txt_TopicDesc.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Açıklama";
            // 
            // lbl_SessionTime
            // 
            this.lbl_SessionTime.AutoSize = true;
            this.lbl_SessionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_SessionTime.Location = new System.Drawing.Point(255, 9);
            this.lbl_SessionTime.Name = "lbl_SessionTime";
            this.lbl_SessionTime.Size = new System.Drawing.Size(75, 13);
            this.lbl_SessionTime.TabIndex = 9;
            this.lbl_SessionTime.Text = "Çalışma Süresi";
            // 
            // tmr_SessionTimer
            // 
            this.tmr_SessionTimer.Interval = 1000;
            this.tmr_SessionTimer.Tick += new System.EventHandler(this.tmr_SessionTimer_Tick);
            // 
            // lbl_SelectedLesson
            // 
            this.lbl_SelectedLesson.AutoSize = true;
            this.lbl_SelectedLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_SelectedLesson.Location = new System.Drawing.Point(13, 227);
            this.lbl_SelectedLesson.Name = "lbl_SelectedLesson";
            this.lbl_SelectedLesson.Size = new System.Drawing.Size(69, 13);
            this.lbl_SelectedLesson.TabIndex = 11;
            this.lbl_SelectedLesson.Text = "İşlenen Ders:";
            // 
            // lbl_SelectedTopic
            // 
            this.lbl_SelectedTopic.AutoSize = true;
            this.lbl_SelectedTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_SelectedTopic.Location = new System.Drawing.Point(13, 211);
            this.lbl_SelectedTopic.Name = "lbl_SelectedTopic";
            this.lbl_SelectedTopic.Size = new System.Drawing.Size(63, 13);
            this.lbl_SelectedTopic.TabIndex = 11;
            this.lbl_SelectedTopic.Text = "Seçili Konu:";
            // 
            // btn_QueryForm
            // 
            this.btn_QueryForm.Location = new System.Drawing.Point(124, 272);
            this.btn_QueryForm.Name = "btn_QueryForm";
            this.btn_QueryForm.Size = new System.Drawing.Size(98, 27);
            this.btn_QueryForm.TabIndex = 12;
            this.btn_QueryForm.Text = "Detaylı Sorgu";
            this.btn_QueryForm.UseVisualStyleBackColor = true;
            this.btn_QueryForm.Click += new System.EventHandler(this.btn_QueryForm_Click);
            // 
            // btn_StopStudying
            // 
            this.btn_StopStudying.Enabled = false;
            this.btn_StopStudying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_StopStudying.Location = new System.Drawing.Point(511, 3);
            this.btn_StopStudying.Name = "btn_StopStudying";
            this.btn_StopStudying.Size = new System.Drawing.Size(79, 23);
            this.btn_StopStudying.TabIndex = 13;
            this.btn_StopStudying.Text = "Çalışmayı Bitir";
            this.btn_StopStudying.UseVisualStyleBackColor = true;
            this.btn_StopStudying.Click += new System.EventHandler(this.btn_StopStudying_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(598, 311);
            this.Controls.Add(this.btn_StopStudying);
            this.Controls.Add(this.btn_QueryForm);
            this.Controls.Add(this.lbl_SelectedTopic);
            this.Controls.Add(this.lbl_SelectedLesson);
            this.Controls.Add(this.lbl_SessionTime);
            this.Controls.Add(this.lst_AllTopics);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TotalTopics);
            this.Controls.Add(this.cmb_ListTopics);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddTopic);
            this.Controls.Add(this.btn_StartLesson);
            this.Controls.Add(this.txt_TopicDesc);
            this.Controls.Add(this.txt_TopicName);
            this.Controls.Add(this.txt_LessonDesc);
            this.Controls.Add(this.txt_LessonName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Ders Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LessonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ListTopics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddTopic;
        private System.Windows.Forms.Label lbl_TotalTopics;
        private System.Windows.Forms.Button btn_StartLesson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lst_AllTopics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TopicName;
        private System.Windows.Forms.TextBox txt_LessonDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TopicDesc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_SessionTime;
        private System.Windows.Forms.Timer tmr_SessionTimer;
        private System.Windows.Forms.Label lbl_SelectedLesson;
        private System.Windows.Forms.Label lbl_SelectedTopic;
        private System.Windows.Forms.Button btn_QueryForm;
        private System.Windows.Forms.Button btn_StopStudying;
    }
}

