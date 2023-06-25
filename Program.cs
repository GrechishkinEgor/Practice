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

        public static void OpenSimulation()
        {
            switch(ChosenSimulation)
            {
                case "Ёлементарна€ симул€ци€":
                    ElementarySimulationForm simForm = new ElementarySimulationForm();
                    simForm.Show();
                    break;
                
                case "":
                case null:
                default:
                    Application.Exit();
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