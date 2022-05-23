using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using weather.Model;
using weather.Views;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using weather.Command;
using weather.Helper;
namespace weather.ModelView
{
    class Loggin: ViewModelBase
    {

        private string _item_sel;
        public string item_sel
        {
            get
            {
                return _item_sel;
            }
            set
            {
                SetValue(ref _item_sel, value);
            }

        }

        private string _current_city;
        public string current_city
        {
            get
            {
                return _current_city;
            }
            set
            {
                SetValue(ref _current_city, value);
            }


        }

        private string _color;
        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                SetValue(ref _color, value);
            }
        }

        private bool _isenabled;
        public bool isenabled
        {
            get
            {
                return _isenabled;
            }
            set
            {
                SetValue(ref _isenabled, value);
            }
        }

        private string _btn_text;
        public string btn_text
        {
            get
            {
                return _btn_text;
            }
            set
            {
                SetValue(ref _btn_text, value);
            }


        }
        private string _back_color;
        public string back_color
        {
            get
            {
                return _back_color;
            }
            set
            {
                SetValue(ref _back_color, value);
            }

        }

        private Window _wnd;
        public Window wnd
        {
            get
            {
                return _wnd;
            }
            set
            {
                SetValue(ref _wnd, value);
            }

        }
 
        public MyDelegateCommand cmdLogin { get; set; }
        public MyDelegateCommand close_application { get; set; }
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
       // Window wnd;

        public DelegateCommand open_combo_cmd { get; set; }

        public MyDelegateCommand InitializeCommand { get; set; }

        public DelegateCommand btn_color { get; set; }


        public ObservableCollection<string> items_xpo { get; set; }

        public Loggin()
        {
            isenabled = false;

            btn_color = new DelegateCommand(()=> btn_color_cmd());
            open_combo_cmd = new DelegateCommand(() => open_combo());

            items_xpo = new ObservableCollection<string>();
            m_notifyIcon = new System.Windows.Forms.NotifyIcon();

            cmdLogin = new MyDelegateCommand(rahman => LoginCommand(rahman));
            m_notifyIcon.Icon = new System.Drawing.Icon(@"C:\Data\source\WPF\weather\bin\Debug\TheAppIcon.ico");

            close_application = new MyDelegateCommand(pep => close_application_cmd(pep));
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));

            items_xpo.Add("Russian");
            items_xpo.Add("English");
            items_xpo.Add("Turkmen");


            back_color = "White";
            color = "LightBlue";
            btn_text = " ";
        }


        private void LoginCommand(object o)
        {
            object[] objs = o as object[];
            wnd = (Window)objs[0];
            wnd.StateChanged += new EventHandler(OnStateChanged);
            m_notifyIcon.Click += new EventHandler(m_notifyIcon_Click);
            wnd.IsVisibleChanged += Wnd_IsVisibleChanged;
            wnd.WindowState = WindowState.Minimized;
        }

        private void Wnd_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CheckTrayIcon();
        }

        private WindowState m_storedWindowState = WindowState.Normal;

        private void CheckTrayIcon()
        {
            ShowTrayIcon(!wnd.IsVisible);
        }

        private void ShowTrayIcon(bool show)
        {
            if (m_notifyIcon != null)
                m_notifyIcon.Visible = show;
        }

        private void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
          //  wnd.Close();
            //   throw new NotImplementedException();
        }
        private void m_notifyIcon_Click(object sender, EventArgs e)
        {
            wnd.Show();
            wnd.WindowState = WindowState.Normal;
        }

        private void OnStateChanged(object sender, EventArgs e)
        {
            if (wnd.WindowState == WindowState.Minimized)
            {
                wnd.Hide();
            }
        }

        private void close_application_cmd(object pep)
        {
            object[] objs = pep as object[];
            wnd = (Window)objs[0];
            wnd.Close();
        }


        private void open_combo()
        {
            if (current_city == null)
            {
                MessageBox.Show("Fill your textbox");
            }
            else
            {
                isenabled = true;
                back_color = "LightGreen";
                btn_text = "✓";
            }
        }

        private void btn_color_cmd()
        {
            LogginParametrs.cityName = $"{current_city}";
            LogginParametrs.language = $"{item_sel}";


            Views.Views views = new Views.Views();
            wnd.Close();

            views.ShowDialog();
            color = "LightGreen";
        }
    }
}
