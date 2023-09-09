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
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync("https://api.musixmatch.com/ws/1.1/artist.get?format=json&artist_id=118&apikey=1f5b83e28960df71fbb4c85562ea2fbd");

            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responsData = responseContent.ReadAsStringAsync();
            string data = responsData.Result;

            Root deserialized = JsonConvert.DeserializeObject<Root>(data);

            //txtOutput2.Text = data;
            //lbldriver1.Text = deserialized.MRData.DriverTable.Drivers[0].familyName;
             txtOutput2.Text = deserialized.message.header.status_code.ToString();

            httpClient.Dispose();



        }
    }
}