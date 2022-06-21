using System.Text;

namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    private async void TestBtn_Clicked(object sender, EventArgs e)
    {
        HttpClient httpClient = new HttpClient();
        string anyUriWillbeOk = "https://github.com/";
        HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, anyUriWillbeOk);

        requestMessage.Content = new StringContent("{}", Encoding.UTF8, "application/json");
        
        HttpResponseMessage responseMessage = await httpClient.SendAsync(requestMessage);
    }
}

