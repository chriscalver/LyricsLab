using System.Net.Http.Headers;
using Newtonsoft.Json;



namespace LyricsLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            // requestHeaders.Add("Accept", "applicationjson");

            Task<HttpResponseMessage> httpResponse2 = httpClient.GetAsync("https://api.musixmatch.com/ws/1.1/artist.get?format=json&artist_id=118&apikey=1f5b83e28960df71fbb4c85562ea2fbd");
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync("https://api.genius.com/artists/41863?access_token=BvT3cQLst6J7AfKYaxoTHcPBKiBtdwB2v3m7ozdLUhrynl27j-grMqpZ5d_Ui76Y");

            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            HttpResponseMessage httpResponseMessage2 = httpResponse2.Result;

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responsData = responseContent.ReadAsStringAsync();
            string data = responsData.Result;

            HttpContent responseContent2 = httpResponseMessage2.Content;
            Task<string> responsData2 = responseContent2.ReadAsStringAsync();
            string data2 = responsData2.Result;

            Root3 deserialized = JsonConvert.DeserializeObject<Root3>(data);
            //Root3 deserialized2 = JsonConvert.DeserializeObject<Root3>(data2);

            //txtOutput2.Text = data;
            //txtOutput2.Text = deserialized.MRData.DriverTable.Drivers[0].familyName;
            //label2.Text = deserialized.response.artist.instagram_name;

            httpClient.Dispose();


        }
    }
}