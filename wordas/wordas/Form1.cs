namespace wordas
{
    using Word = Microsoft.Office.Interop.Word;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CollorBox.Items.Add("Черный");
            CollorBox.Items.Add("Синий");
            CollorBox.Items.Add("Зеленый");
            CollorBox.Items.Add("Красный");
            CollorBox.Text = "Чёрный";
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(Puthbox.Text);
            doc.Save();
        }



    }
}