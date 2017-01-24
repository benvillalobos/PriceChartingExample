using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PriceChartingAPI;
using GiantBomb.Api.Model;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;

namespace PriceChartingTestbed
{
    public partial class Form1 : Form
    {
        PriceChartingApi pcClient = new PriceChartingApi("Insert PriceCharting API Key Here");
        GiantBomb.Api.GiantBombRestClient gbClient = new GiantBomb.Api.GiantBombRestClient("Insert Giantbomb API Key Here");

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LoadingLabel.Visible = true;
            List<Product> p = await pcClient.SearchProductsByQuery(SearchBar.Text);

            IEnumerable<Game> games = await gbClient.SearchForGamesAsync(p[0].Name);
            List<Game> listOfGames = games.ToList();

            ListOfGames.Items.Clear();
            int index = 0;
            DescriptionBox.DocumentText = listOfGames[0].Description;
            foreach (Product item in p)
            {
                index++;
                ListOfGames.Items.Add(string.Format("Name: {0}", item.Name));
                ListOfGames.Items.Add(string.Format("ID: {0}", item.ID));
                ListOfGames.Items.Add(string.Format("Genre: {0}", item.Genre));
                ListOfGames.Items.Add(string.Format("Release Date: {0}", item.ReleaseDate));
                if(item.NewPrice != null)
                {
                    ListOfGames.Items.Add(string.Format("New Price: {0}", "$" + (float.Parse(item.NewPrice) / 100f).ToString()));
                }
                if(item.LoosePrice != null)
                {
                    ListOfGames.Items.Add(string.Format("Loose Price: {0}", "$" + (float.Parse(item.LoosePrice) / 100f).ToString()));
                }
                if(item.CompleteInBoxPrice != null)
                {
                    ListOfGames.Items.Add(string.Format("CIB Price: {0}", "$" + (float.Parse(item.CompleteInBoxPrice) / 100f).ToString()));
                }
                ListOfGames.Items.Add(string.Format("Console: {0}", item.ConsoleName));
                
                ListOfGames.Items.Add("------------");
            }

            if(p.Count > 0)
            {

                HttpClient http = new HttpClient();
                HttpRequestHeaders headers = http.DefaultRequestHeaders;
                headers.UserAgent.Add(new ProductInfoHeaderValue("some_test_app", "0.0.1"));

                byte[] bytes = http.GetByteArrayAsync(listOfGames[0].Image.MediumUrl).Result;
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                
                BoxArt.BackgroundImage = img;
            }
            LoadingLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
