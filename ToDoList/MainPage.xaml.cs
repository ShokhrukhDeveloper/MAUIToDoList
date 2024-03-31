using ToDoList.ViewModel;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel mv)
        {
            InitializeComponent();
            BindingContext = mv;
        }

    }

}
