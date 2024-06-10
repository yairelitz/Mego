namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        char[] c = new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ם', 'ן', 'ץ', 'ף', 'ך' };
        int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400 };
        string[] s = new string[] { "אלף", "בית", "גימל", "דלד", "הי", "וו", "זין", "חת", "טט", "יוד", "כף", "למד", "מם", "נון", "סמך", "עין", "פיי", "צדיק", "קוף", "ריש", "שין", "תף", "מן", "צה", "פך" };
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "$";
        }

    }
}
