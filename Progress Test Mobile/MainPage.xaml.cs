using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Progress_Test_Mobile
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ImageItem> ImageItems { get; } = new ObservableCollection<ImageItem>
        {
            new ImageItem { ImagePath = "image1.jpg", ImageText = "Peach Tree In Blossom",ImagePrice = "$950,000"},
            new ImageItem { ImagePath = "image2.jpg", ImageText = "Cafe Trrrace at Night",ImagePrice = "$1,920,000" },
            new ImageItem { ImagePath = "image3.jpg", ImageText = "Peach Tree In Blossom" ,ImagePrice = "$950,000"},
            new ImageItem { ImagePath = "image4.jpeg", ImageText = "Peach Tree In Blossom" ,ImagePrice = "$950,000"}
        };
            

       

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            //// Hook up the event handlers for Expander
            //descriptionExpander.Expanded += (sender, e) =>
            //{
            //    // Your code when the expander is expanded
            //};

            //descriptionExpander.Collapsed += (sender, e) =>
            //{
            //    // Your code when the expander is collapsed
            //};
        }
    }
    public class ImageItem
        {
            public string ImagePath { get; set; }
            public string ImageText { get; set; }
            public string ImagePrice { get; set; }
    }
} 