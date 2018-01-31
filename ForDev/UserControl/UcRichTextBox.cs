using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserEditor
{
    public partial class UcRichTextBox : UserControl
    {
        public event EventHandler Connected;
        public event EventHandler ButtonClick;
        public SplitContainer SplitContainer { get; set; }

        public int TopicId { get; set; }

        public UcRichTextBox()
        {
            InitializeComponent();
        }

        public RichTextBox RichTextBox
        {
            get { return txtCtrlRch; }
            set { txtCtrlRch = value; }
        }

        public ToolStrip ToolStrip
        {
            get
            {
                return toolCtrlRtf;
            }
        }

        private void CtrlRtfPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            this.txtCtrlRch.Size = new Size(this.Width, this.Height - 24);
        }
    
        #region FontStyle
        private void Bold_Click(object sender, EventArgs e)
        {
            Font currentFont = txtCtrlRch.SelectionFont;
            FontStyle newFontStyle = currentFont.Style;

            if (toolStripButtonBold.Checked)
                newFontStyle = newFontStyle | FontStyle.Bold;
            else
                newFontStyle = newFontStyle ^ FontStyle.Bold;

            txtCtrlRch.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font currentFont = txtCtrlRch.SelectionFont;
            FontStyle newFontStyle = currentFont.Style;

            if (toolStripButtonItalic.Checked)
                newFontStyle = newFontStyle | FontStyle.Italic;
            else
                newFontStyle = newFontStyle ^ FontStyle.Italic;

            txtCtrlRch.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font currentFont = txtCtrlRch.SelectionFont;
            FontStyle newFontStyle = currentFont.Style;

            if (toolStripButtonUnderline.Checked)
                newFontStyle = newFontStyle | FontStyle.Underline;
            else
                newFontStyle = newFontStyle ^ FontStyle.Underline;

            txtCtrlRch.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
        }

        private void Strikeout_Click(object sender, EventArgs e)
        {
            Font currentFont = txtCtrlRch.SelectionFont;
            FontStyle newFontStyle = currentFont.Style;

            if (toolStripButtonStrikeout.Checked)
                newFontStyle = newFontStyle | FontStyle.Strikeout;
            else
                newFontStyle = newFontStyle ^ FontStyle.Strikeout;

            txtCtrlRch.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
        }

        #endregion

        private void Color_Click(object sender, EventArgs e)
        {
            Color currentColor = txtCtrlRch.SelectionColor;

            if (colorCtrlRtf.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColor.BackColor = colorCtrlRtf.Color;
                currentColor = colorCtrlRtf.Color;
            }

            txtCtrlRch.SelectionColor = currentColor;

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }

    }
}
