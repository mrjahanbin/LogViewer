using System.Data;

namespace WinLogViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowserPath_Click(object sender, EventArgs e)
        {
            var txt = folderBrowserDialog1.ShowDialog();

            if (txt == DialogResult.OK)
            {
                lblLog.Text = folderBrowserDialog1.SelectedPath;
                List<LogInfoViewModel> SS = LoadLog();

                dataGridView1.DataSource = SS;

            }
            else
            {
                lblLog.Text = "لطفا مسیر فایل های لاگ را انتخاب کنید";
            }
        }

        private List<LogInfoViewModel> LoadLog()
        {


            string[]? files = Directory.GetFiles(lblLog.Text, "INFO_*.log");

            if (files.Length == 0)
            {
                lblLog.Text = "در این مسیر فایل لاگی پیدا نشد";
            }

            ReadeLog readeLog = new ReadeLog();
            var SS = readeLog.Read(files);
            return SS;
        }

        private void btnReadLog_Click(object sender, EventArgs e)
        {
            try
            {
                string[]? files = Directory.GetFiles(lblLog.Text, "INFO_*.log");

                if (files.Length == 0)
                {
                    lblLog.Text = "در این مسیر فایل لاگی پیدا نشد";
                }

                ReadeLog readeLog = new ReadeLog();
                var SS = readeLog.Read(files);

                dataGridView1.DataSource = SS;

            }
            catch (Exception)
            {

            }

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DB = LoadLog();
            var Selector = comboBox1.SelectedIndex;
            IEnumerable<LogInfoViewModel>? Filter = new List<LogInfoViewModel>();
            string Text = textBox1.Text.Trim().ToLower();

            switch (Selector)
            {
                case (int)SearchEnum.Datetime:
                    Filter = DB.Where(x => x.Datetime.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.Address:
                    Filter = DB.Where(x => x.Address.Trim().ToLower().Contains(Text));

                    break;
                case (int)SearchEnum.Host:
                    Filter = DB.Where(x => x.Host.Trim().ToLower().Contains(Text));

                    break;
                case (int)SearchEnum.Url:
                    Filter = DB.Where(x => x.Url.Trim().ToLower().Contains(Text));

                    break;
                case (int)SearchEnum.Controller:
                    Filter = DB.Where(x => x.Controller.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.Action:
                    Filter = DB.Where(x => x.Action.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.Method:
                    Filter = DB.Where(x => x.Method.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.StatusCode:
                    Filter = DB.Where(x => x.StatusCode.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.Form:
                    Filter = DB.Where(x => x.Form.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.ContentType:
                    Filter = DB.Where(x => x.ContentType.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.Body:
                    Filter = DB.Where(x => x.Body.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.QueryString:
                    Filter = DB.Where(x => x.QueryString.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.IP:
                    Filter = DB.Where(x => x.IP.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.UserAgent:
                    Filter = DB.Where(x => x.UserAgent.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.UserName:
                    Filter = DB.Where(x => x.UserName.Trim().ToLower().Contains(Text));
                    break;
                case (int)SearchEnum.AdditionalInfo:
                    Filter = DB.Where(x => x.AdditionalInfo.Trim().ToLower().Contains(Text));
                    break;
                default:
                    break;
            }

            dataGridView1.DataSource = Filter.ToList();
            dataGridView1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(SearchEnum)))
            {
                comboBox1.Items.Add(item);
            }
        }
    }


}