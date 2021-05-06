using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado13 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }
    private void button1_Click(object sender, EventArgs e) {
      OpenFileDialog open = new OpenFileDialog();
      if (open.ShowDialog() == DialogResult.OK) pictureBox1.Image = new Bitmap(open.FileName);
    }
  }
}
