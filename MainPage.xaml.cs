using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MyClass> myList;

        public MyViewModel()
        {
            MyList = [];
            for (int i = 0; i < 100; i++)
            {
                MyList.Add(new MyClass() { Name = $"Name_{i}", Surname = $"Surname_{i}" });
            }
        }
    }

    public class MyClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
