using System.Diagnostics;

namespace DaluiApp.Views;

public partial class ImageGeneratorView : ContentPage
{
	public ImageGeneratorView()
	{
		InitializeComponent();
	}

    Stopwatch watch = new Stopwatch();

    private void btnFinish_Clicked(object sender, EventArgs e)
    {
        StopGeneration();
    }

    private async Task StopGeneration()
    {
        watch.Stop();

        lottie.IsAnimationEnabled = false;
        lottie.IsVisible = false;
        imageBorder.IsVisible = true;
        imageAnimation.IsVisible = true;

        await Task.Delay(2000);

        await Task.WhenAny(
             imageAnimation.ScaleTo(1.1, 1000),
             imageAnimation.FadeTo(0, 1000),
             borderTime.ScaleTo(1, 1000),
             borderTime.FadeTo(1, 1000)
             );

        await borderTime.FadeTo(0, 300);
        await btnFinish.ScaleTo(1, 1000);

    }

}