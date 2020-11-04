using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace WeatherIPMA
{
    /// <summary>
    /// Classe que representa a previsão de 5 dias de um certo local
    /// </summary>
    [Serializable]
    public class Forecast
    {
        #region ATRIBUTES
        string owner;
        string country;
        public List<Weather> data;
        int idLocal;
        DateTime dateUpdate;
        string local;
        float tMinAmp;
        float tMaxAmp;
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Forecast()
        {
            data = new List<Weather>();
        }
        #endregion

        #region Properties
        public string Owner
        {
            get { return owner; } set { owner = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public List<Weather> Data
        {
            get { return data; }
            set { data = value; }
        }
        public int IdLocal
        {
            get { return idLocal; }
            set { idLocal = value; }
        }
        public DateTime DateUpdate
        {
            get { return dateUpdate; }
            set { dateUpdate = value; }
        }
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        public float TMinAmp
        {
            get { return tMinAmp; } set { tMinAmp = value; }
        }
        public float TMaxAmp
        {
            get { return tMaxAmp; } set { tMaxAmp = value; }
        }
        #endregion

        #region Class Functions
        //Fills the identifier Dictionary with globalIdLocal and local
        public void FillForecast(string path, Identifiers list)
        {
            //Read File (Possible not found file error)
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();

            //Regular expression to take 
            string foreReg = "\"owner\": \"([A-Z]+)\", \"country\": \"([A-Z]{2,3})\".*\"globalIdLocal\": (\\d{7}), \"dataUpdate\": \"(\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2})\"";
            Regex forecast = new Regex(foreReg);

            Match match = forecast.Match(text);
            this.Owner = match.Groups[1].Value;
            this.Country = match.Groups[2].Value;
            this.IdLocal = Int32.Parse(match.Groups[3].Value);
            this.DateUpdate = DateTime.ParseExact(match.Groups[4].Value, "yyyy-MM-ddTHH:mm:ss", null);
            AssignLocal(list);

            string weaReg = "\"precipitaProb\": \"(\\d+\\.\\d+)\", \"tMin\": \"(\\d+\\.\\d+)\", \"tMax\": \"(\\d+\\.\\d+)\", \"predWindDir\": \"(N[E|W]?|S[E|W]?|E|W)\", \"idWeatherType\": (\\d+), \"classWindSpeed\": (\\d), \"longitude\": \"(-?\\d{1,3}\\.\\d{4})\", \"forecastDate\": \"(\\d{4}-\\d{2}-\\d{2})\"(, \"classPrecInt\": (\\d))?, \"latitude\": \"(-?\\d{1,2}\\.\\d{4})\"";
            Regex weather = new Regex(weaReg);

            MatchCollection matches = weather.Matches(text);
            foreach (Match mtch in matches)
            {
                int? classPrec = null;
                if (mtch.Groups[10].Length != 0) classPrec = Int32.Parse(mtch.Groups[10].Value);

                Temperature temp = new Temperature(mtch.Groups[2].Value, mtch.Groups[3].Value);

                Weather wea = new Weather(
                    Single.Parse(mtch.Groups[1].Value, CultureInfo.InvariantCulture),
                    temp,
                    mtch.Groups[4].Value,
                    Int32.Parse(mtch.Groups[5].Value),
                    Int32.Parse(mtch.Groups[6].Value),
                    mtch.Groups[7].Value,
                    mtch.Groups[8].Value,
                    classPrec,
                    mtch.Groups[11].Value);

                data.Add(wea);
                this.Data = data;
            }

            this.tMinAmp = TAmpMin(data);
            this.tMaxAmp = TAmpMax(data);
        }

        /// <summary>
        /// Função para fazer Print de cada objeto da classe Weather na lista "data"
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Owner: " + Owner + "; Country: " + Country + "; IDLocal: " + IdLocal + "; Date: " + DateUpdate.ToString() + "; Local: " + Local);
            foreach (Weather wea in data)
            {
                wea.Print();
            }
        }

        /// <summary>
        /// Função para calcular a temperatura minima de um determinado local num conjunto de 5 dias
        /// </summary>
        /// <param name="data">Lista do tipo "Weather"</param>
        /// <returns> Retorna a temperatura minima dos 5 dias de previsão para um certo local</returns>
        public float TAmpMin(List<Weather> data)
        {
            //Declaração de Variaveis
            float menor, outro = 0;

            //Converter uma string em float
            menor = float.Parse(data[0].Temperature.TMin, CultureInfo.InvariantCulture.NumberFormat);

            for (int i = 1; i < 5; i++)
            {
                //Converter string em float
                outro = float.Parse(data[i].Temperature.TMin, CultureInfo.InvariantCulture.NumberFormat);

                if(menor > outro)
                {
                    menor = outro;
                }
            }

            return menor;
        }

        /// <summary>
        /// Função para calcular a temperatura máxima de um determinado local num conjunto de 5 dias
        /// </summary>
        /// <param name="data">Lista do tipo "Weather"</param>
        /// <returns>Retorna a temperatura minima dos 5 dias de previsão para um certo local</returns>
        public float TAmpMax(List<Weather> data)
        {
            //Declaração de Variaveis
            float maior, outro = 0;

            //Converter uma string em float
            maior = float.Parse(data[0].Temperature.TMax, CultureInfo.InvariantCulture.NumberFormat);

            for (int i = 1; i < 5; i++)
            {
                //Converter string em float
                outro = float.Parse(data[i].Temperature.TMax, CultureInfo.InvariantCulture.NumberFormat);

                if (maior < outro)
                {
                    maior = outro;
                }
            }

            return maior;
        }

        /// <summary>
        /// Escreve a variavel local da classe
        /// </summary>
        /// <param name="list">Objeto da classe Identifiers</param>
        public void AssignLocal(Identifiers list)
        {
            string loc;
            list.TryGetValue(this.IdLocal, out loc);
            this.Local = loc;
        }
        #endregion

    }
}
