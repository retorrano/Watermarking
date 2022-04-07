namespace WM    
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Text;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SSFButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog(this);
            SFTextBox.Text = folder.SelectedPath;
        }

        private void STFButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog(this);
            TFTextBox.Text = folder.SelectedPath;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            String[] files = Directory.GetFiles(SFTextBox.Text);
            String fname;
            foreach (String file in files)
            {
                fname = Path.GetFileName(file);
                //Debug.WriteLine(fname);
                System.Drawing.Image bitmap = (System.Drawing.Image) Bitmap.FromFile(file);
                System.Drawing.Image icon = (System.Drawing.Image) Bitmap.FromFile(IconTextBox.Text);
                Font font = new Font(FontTextBox.Text, bitmap.Width/80, FontStyle.Bold, GraphicsUnit.Pixel);
                Color color = Color.FromArgb(Int32.Parse(ATextBox.Text), Int32.Parse(RTextBox.Text), Int32.Parse(GTextBox.Text), Int32.Parse(BTextBox.Text));
                //Point atpoint = new Point(bitmap.Width/2, bitmap.Height/2);
                Point atpoint = new Point(bitmap.Width- bitmap.Width/20,bitmap.Height - bitmap.Height/80);
                Point iconpoint = new Point(bitmap.Width - bitmap.Width / 20, bitmap.Height - bitmap.Height/9);
                SolidBrush brush = new SolidBrush(color);
                Graphics g = Graphics.FromImage(bitmap);
                int width= bitmap.Width / 10;
                int height= width / 2;

                g.DrawImage(icon, iconpoint.X - width, iconpoint.Y, width ,height);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Far;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(WITextBox.Text, font, brush, atpoint, sf);
                g.Dispose();
                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.ToArray();
                String saveto = TFTextBox.Text + "\\" + fname; 
                //Debug.WriteLine(saveto);
                System.IO.File.WriteAllBytes(saveto, bytes);
            }
        }


        private void SIButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            IconTextBox.Text = ofd.FileName;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Source available at https://github.com/retorrano", "I.T. Office");
        }
    }
}