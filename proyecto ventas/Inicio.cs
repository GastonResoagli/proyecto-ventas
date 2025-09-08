namespace proyecto_ventas
{
    public partial class Inicio : Form
    {
        private Button currenbutton;
        private Random random;
        private int tempindex;

        //constructor
        public Inicio()
        {
            InitializeComponent();
        }

        //Metodos
        private Color selectThemeColor()
        {
            int idex = random.Next(Themecolor.ColorList.Count);
            while (tempindex == index) {
                random.Next(Themecolor.ColorList.Count);
            }
            tempindex = Index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

    }
}
