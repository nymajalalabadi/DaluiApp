using DaluiApp.Models;
using System.Collections.ObjectModel;

namespace DaluiApp.Views;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();

        LoadData();
        BindingContext = this;
    }

    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>
        {
               new Profile
               {
                    Name = "Héctor",
                    ProfileImage = "profile1.jpg",
                    NoPhotos = 12
               },
               new Profile
               {
                    Name = "Maddy",
                    ProfileImage = "profile2.jpg",
                    NoPhotos = 5
               },
               new Profile
               {
                    Name = "Henry",
                    ProfileImage = "profile3.jpg",
                    NoPhotos = 25
               },
        };

        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
               new GeneratedImage
               {
                    ImagePath = "dashboard1.jpg",
                    MainKeyword = "Castle",
                    Keywords = new List<string>{
                         "Epic, hill, mountain, trees, blue sky"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard2.jpg",
                    MainKeyword = "Mountains",
                    Keywords = new List<string>{
                         "Landscape, photorealistic, dawn, mountains, moon"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard3.jpg",
                    MainKeyword = "Robot",
                    Keywords = new List<string>{
                         "AI, robotic, human, light, metal"
                    }
               },
        };

    }
}