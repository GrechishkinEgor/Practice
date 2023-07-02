namespace Practice
{
    internal static class Program
    {
        private static HelloForm helloForm = new HelloForm();
        public static string ChosenSimulation { get; set; } = "";

        public static void CloseApplication()
        {
            helloForm.Close();
        }

        public static void OpenHelloForm()
        {
            helloForm.Show();
        }

        public static void OpenSimulation()
        {
            switch (ChosenSimulation)
            {
                case "������������ ���������":
                    ElementarySimulationForm simForm = new ElementarySimulationForm();
                    break;
                case "��������� ��������":
                    PredatorSimulationForm simForm1 = new PredatorSimulationForm();
                    break;
                case "��������� �����������":
                    CompetitionSimulationForm simForm2 = new CompetitionSimulationForm();
                    break;
                case "":
                case null:
                default:
                    helloForm.Show();
                    break;
            }
        }
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(helloForm);
        }
    }
}