using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WeatherIPMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelTabelaWeather_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Procedimentos executados no momento em que se clica no botão "Confirmar" do forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirmarLocal_Click(object sender, EventArgs e)
        {
            //Coloca informação da cidade através do texto presente no Combo Box no Group Box do Form
            groupBoxWeather.Text = "Portugal -> " + comboBoxLocal.Text;
            
            //STEP 1: Dictionary of locals and Ids
            string path = "..\\..\\distrits-islands.json";
            Identifiers idents = new Identifiers();
            idents.FillIdents(path);

            //Verificar qual o numero da globalIdLocal através de um nome de uma cidade
            var codLocal = idents.FirstOrDefault(x => x.Value == comboBoxLocal.Text).Key;

            //STEP 2: Save data in structures
            List<Forecast> forecasts = new List<Forecast>();

            string pathFiles = "..\\..\\data_forecast";
            string[] paths = Directory.GetFiles(pathFiles);
            foreach (string path0 in paths)
            {
                Forecast forecast = new Forecast(); //Fill forecast as constructor
                forecast.FillForecast(path0, idents);
                forecasts.Add(forecast);
            }

            //STEP 3: Save in files with the respective format
            string outPath = "..\\..\\output";
            Directory.CreateDirectory(outPath);

            // JSON
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.WriteIndented = true;
            options.IgnoreNullValues = true;
            var text = JsonSerializer.Serialize(forecasts[1], options);
            File.WriteAllText(outPath + "\\" + forecasts[1].IdLocal + "-detalhe.json", text);

            // XML (ERROR: first two properties doesnt work)
            XmlSerializer xml = new XmlSerializer(forecasts[0].GetType());
            StringWriter stringWriter = new StringWriter();
            xml.Serialize(stringWriter, forecasts[1]);
            File.WriteAllText(outPath + "\\" + forecasts[1].IdLocal + "-detalhe.xml", stringWriter.ToString());

            #region Informação Form
            //Ciclo para verificar qual foi o local escolhido pelo utilizador
            for (int i = 0; i < forecasts.Count; i++)
            {
                if(forecasts[i].IdLocal == codLocal)
                {
                    List<Weather> previsao5Dias = forecasts[i].Data;

                    //Informações da Amplitude Térmica dos 5 dias
                    labelAmpMin.Text = forecasts[i].TMinAmp.ToString();
                    labelAmpMax.Text = forecasts[i].TMaxAmp.ToString();

                    //Informações do Dia 1
                    labelMes1.Text = previsao5Dias[0].ForecastDate.Month.ToString();
                    labelDia1.Text = previsao5Dias[0].ForecastDate.Day.ToString();
                    labelTmin1.Text = previsao5Dias[0].Temperature.TMin.ToString();
                    labelTmax1.Text = previsao5Dias[0].Temperature.TMax.ToString();
                    windDir1.Text = previsao5Dias[0].PredWindDir.ToString();
                    labelPrec1.Text = previsao5Dias[0].PrecipitaProb.ToString();
                    labelPrec1.Text = String.Concat(labelPrec1.Text, "%");
                    pictureBox1.Image = imageList1.Images[previsao5Dias[0].IdWeatherType - 1];

                    //Informações do Dia 2
                    labelMes2.Text = previsao5Dias[1].ForecastDate.Month.ToString();
                    labelDia2.Text = previsao5Dias[1].ForecastDate.Day.ToString();
                    labelTmin2.Text = previsao5Dias[1].Temperature.TMin.ToString();
                    labelTmax2.Text = previsao5Dias[1].Temperature.TMax.ToString();
                    windDir2.Text = previsao5Dias[1].PredWindDir.ToString();
                    labelPrec2.Text = previsao5Dias[1].PrecipitaProb.ToString();
                    labelPrec2.Text = String.Concat(labelPrec2.Text, "%");
                    pictureBox2.Image = imageList1.Images[previsao5Dias[1].IdWeatherType - 1];

                    //Informações do Dia 3
                    labelMes3.Text = previsao5Dias[2].ForecastDate.Month.ToString();
                    labelDia3.Text = previsao5Dias[2].ForecastDate.Day.ToString();
                    labelTmin3.Text = previsao5Dias[2].Temperature.TMin.ToString();
                    labelTmax3.Text = previsao5Dias[2].Temperature.TMax.ToString();
                    windDir3.Text = previsao5Dias[2].PredWindDir.ToString();
                    labelPrec3.Text = previsao5Dias[2].PrecipitaProb.ToString();
                    labelPrec3.Text = String.Concat(labelPrec3.Text, "%");
                    pictureBox3.Image = imageList1.Images[previsao5Dias[2].IdWeatherType - 1];

                    //Informações do Dia 4
                    labelMes4.Text = previsao5Dias[3].ForecastDate.Month.ToString();
                    labelDia4.Text = previsao5Dias[3].ForecastDate.Day.ToString();
                    labelTmin4.Text = previsao5Dias[3].Temperature.TMin.ToString();
                    labelTmax4.Text = previsao5Dias[3].Temperature.TMax.ToString();
                    windDir4.Text = previsao5Dias[3].PredWindDir.ToString();
                    labelPrec4.Text = previsao5Dias[3].PrecipitaProb.ToString();
                    labelPrec4.Text = String.Concat(labelPrec4.Text, "%");
                    pictureBox4.Image = imageList1.Images[previsao5Dias[3].IdWeatherType - 1];

                    //Informações do Dia 5
                    labelMes5.Text = previsao5Dias[4].ForecastDate.Month.ToString();
                    labelDia5.Text = previsao5Dias[4].ForecastDate.Day.ToString();
                    labelTmin5.Text = previsao5Dias[4].Temperature.TMin.ToString();
                    labelTmax5.Text = previsao5Dias[4].Temperature.TMax.ToString();
                    windDir5.Text = previsao5Dias[4].PredWindDir.ToString();
                    labelPrec5.Text = previsao5Dias[4].PrecipitaProb.ToString();
                    labelPrec5.Text = String.Concat(labelPrec5.Text, "%");
                    pictureBox5.Image = imageList1.Images[previsao5Dias[4].IdWeatherType - 1];
                }
            }
            #endregion
        }

        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
