namespace CITA255_Assignment02
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ExerciseList.ItemsSource = exercises;
            RepsList.ItemsSource = reps;
        }

        List<string> exercises = new List<string>
        {
            "Pushups","Situps","Squats","Chest Press","Bicep Curls","Leg Press","Calf Raises","Shoulder Press","Tricep Press","Rows"
        };
        List<int> reps = new List<int>
        {
            20,35,14,12,15,5,25,12,15,17
        };
        private void OnCalculateClicked(object? sender, EventArgs e)
        {
            int total = 0;
            foreach (int rep in reps)
            {
                total += rep;
                Console.WriteLine(rep);
            }
            TotalLabel.Text = total.ToString() + " reps";
        }
    }
}
