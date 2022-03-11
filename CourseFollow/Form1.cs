using CourseFollow.Context;
using CourseFollow.DesignPatterns.Singleton;
using CourseFollow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseFollow
{
    public partial class Form1 : Form
    {
        MyContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }

        Lesson _lesson; Topic _topic; int _topicTime;

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_ListTopics.SelectedIndex = -1; lst_ListAllData.SelectedIndex = -1;

            //Ekranda toplamda kaç adet konu olduğunu sayı olarak gösterir.
            lbl_TotalTopics.Text = $"Kayıtlı {_db.Topics.Count()} adet konu var";
        }

        private void btn_AddTopic_Click(object sender, EventArgs e)
        {
            AddTopic(); ClearBoxes(); 
            lbl_TotalTopics.Text = $"Kayıtlı {_db.Topics.Count()} adet konu var";
        }

        private void btn_ListTopics_Click(object sender, EventArgs e)
        {
            ListTopics();
        }

        private void btn_ListLessons_Click(object sender, EventArgs e)
        {
            ListLesson();
        }

        private void btn_StartLesson_Click(object sender, EventArgs e)
        {
            AddLesson();
        }

        /// <summary>
        /// Ders çalışmayı durdurur. Bütün değişkenleri sıfırlar ve sayacı sıfırlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StopStudying_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ders kaydı tamamlanacak. Bu ders için tekrardan ek süre EKLEYEMEZSİNİZ. Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                tmr_SessionTimer.Stop();
                _lesson = null; _topic = null;
                _topicTime = _totalMin = _sec = _min = _hrs = 0;

                lbl_SessionTime.Text = lbl_SelectedTopic.Text = lbl_SelectedLesson.Text = String.Empty;
                btn_StartLesson.Enabled = true; btn_AddTopic.Enabled = true;

                ClearBoxes();
                MessageBox.Show("Ders bilgileri veritabanına kaydedildi.");
                btn_StopStudying.Enabled = false;
                return;
            }
            MessageBox.Show("Ders kaydı devam ediyor."); return;
        }

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\

        #region Methods
        /// <summary>
        /// Veritabanına konu ekler.
        /// </summary>
        public void AddTopic()
        {
            // Konu adı boş geçilmesin diye;
            if (txt_TopicName == null || txt_TopicName.Text == "" || txt_TopicName.Text.Length >= 20)
            {
                MessageBox.Show("Hatalı Giriş. Lütfen doğru giriş yapınız!");
                return;
            }

            Topic topic = new Topic
            {
                TopicName = txt_TopicName.Text,
                Description = txt_TopicDesc.Text
            };
            _db.Topics.Add(topic);
            _db.SaveChanges();

            ListTopics(); // Yeni bir konu eklendiğinde listenin güncellenmesini sağlar.
        }

        /// <summary>
        /// Kayıtlı olan konuları ListBox'da gösterir.
        /// </summary>
        public void ListTopics()
        {
            //Ana listeye toplam kayıtlı olan konuları gösterir.
            lst_ListAllData.DataSource = _db.Topics.ToList();

            //Ekrandaki Combobox'a kayıtlı olan konuları ekler.
            cmb_ListTopics.DataSource = _db.Topics.ToList();
        }

        /// <summary>
        /// Kayıtlı olan dersleri listeler
        /// </summary>
        public void ListLesson()
        {
            lst_ListAllData.DataSource = _db.Lessons.ToList();
        }

        /// <summary>
        /// Ders ekleme işlemlerini gerçekleştirir. Sayacı tetikler.
        /// </summary>
        public void AddLesson()
        {
            if (txt_LessonName == null || txt_LessonName.Text == "" || txt_LessonName.Text.Length >= 22)
            {
                MessageBox.Show("Hatalı Giriş. Lütfen doğru giriş yapınız!");
            }
            else
            {
                if (cmb_ListTopics.SelectedIndex > -1)
                {
                    DialogResult dr = MessageBox.Show("Ders bilgileri alındı. Bilgileri kaydedip oturum süresi başlatılacak. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        Lesson lesson = new Lesson
                        {
                            LessonName = txt_LessonName.Text,
                            Description = txt_LessonDesc.Text,
                            TopicID = (cmb_ListTopics.SelectedItem as Topic).ID
                        };
                        _db.Lessons.Add(lesson);
                        _db.SaveChanges();

                        _lesson = lesson; _topic = cmb_ListTopics.SelectedItem as Topic;

                        tmr_SessionTimer.Start();

                        btn_StartLesson.Enabled = false; btn_AddTopic.Enabled = false; btn_StopStudying.Enabled = true;
                        ClearBoxes(); ScreenHelper();
                        return;
                    }
                    else MessageBox.Show("Oturum başlatılmadı.");
                }
                else MessageBox.Show("Lütfen dersin ekleneceği konuyu seçiniz!");
            }
        }

        /// <summary>
        /// Seçili dersi günceller. Oturumda yaratılan ders otomatik olarak seçili sayılır.
        /// </summary>
        /// <param name="lsn">Program başlangıcında yaratılan ders.</param>
        /// <param name="time">Yaratılan derste çalışılan süre. (Dakika cinsinde)</param>
        public void UpdateLesson(Lesson lsn, int time)
        {
            lsn.Status = Enums.DataStatus.Updated;
            lsn.ModifiedDate = DateTime.Now;
            lsn.Minute = time;

            _db.Entry(_lesson).CurrentValues.SetValues(lsn);
            _db.SaveChanges();
        }

        /// <summary>
        /// Seçili konuyu günceller. (Seçili konu: Ders eklenirken seçilmiş olan konudur.)
        /// </summary>
        /// <param name="tpc">Ders yaratılırken seçilen konu.</param>
        /// <param name="time">Seçili konuda mevcut oturum da geçilirlen süre (Saat cinsinde)</param>
        public void UpdateTopic(Topic tpc, int time)
        {
            if (_topicTime == 0) _topicTime = tpc.Hour;

            tpc.Status = Enums.DataStatus.Updated;
            tpc.ModifiedDate = DateTime.Now;
            tpc.Hour = _topicTime + time;

            _db.Entry(_topic).CurrentValues.SetValues(tpc);
            _db.SaveChanges();
        }

        /// <summary>
        /// Seçili dersi ve konuyu ekranda gösterir.
        /// </summary>
        public void ScreenHelper()
        {
            lbl_SelectedLesson.Text = $"İşlenen Ders: {_lesson.LessonName}";
            lbl_SelectedTopic.Text = $"Seçili Konu: {_topic.TopicName}";
        }

        /// <summary>
        /// Form üzerindeki nesnelerin içeriğini temizler. (Değişkenlerde bir değişiklik YAPMAZ!)
        /// </summary>
        public void ClearBoxes()
        {
            txt_TopicName.Text = txt_TopicDesc.Text = txt_LessonName.Text = txt_LessonDesc.Text = string.Empty;

            cmb_ListTopics.SelectedIndex = lst_ListAllData.SelectedIndex = -1;
        }
        #endregion

        #region TimerScope
        int _sec, _min, _hrs;
        int _totalMin;
        private void tmr_SessionTimer_Tick(object sender, EventArgs e)
        {
            SessionTimer();
        }

        /// <summary>
        /// Oturumda geçirilen süreyi hesaplar, veritabanına kaydeder ve ekrana yazdırır.
        /// </summary>
        public void SessionTimer()
        {
            _sec++;

            if (_sec >= 60)
            {
                _min++; _sec = 0;
                _totalMin++;

                UpdateLesson(_lesson, _totalMin);

                if (_min >= 60)
                {
                    _hrs++; _min = 0;

                    UpdateTopic(_topic, _hrs);
                }
            }

            lbl_SessionTime.Text = $"Şuan ki çalışma Süresi;{_min} Dk. {_hrs} Saat.";
        }
        #endregion

        //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\ //--\\
    }
}
