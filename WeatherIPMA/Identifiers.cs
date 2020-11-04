using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WeatherIPMA
{
    /// <summary>
    /// Classe do tipo Dictionary, guarda todos os locais e respetivos ids
    /// </summary>
    public class Identifiers : Dictionary<int,string>
    {
        //Fills the identifier Dictionary with globalIdLocal and local
        public void FillIdents(string path)
        {
            //Read File (Possible not found file error)
            StreamReader sr = new StreamReader(path);
            JsonReader jsonReader = new JsonTextReader(sr);
            JsonSerializer jsonSerializer = new JsonSerializer();
            var obj = jsonSerializer.Deserialize(jsonReader) as JObject;
            jsonReader.Close();
            sr.Close();

            //string text = sr.ReadToEnd();
            string text = obj.ToString(Formatting.None);

            //Regular expression to take 
            string identReg = "\"idRegiao\":(\\d),\"idAreaAviso\":\"([A-Z]{3})\",\"idConcelho\":(\\d{1,2}),\"globalIdLocal\":(\\d{7}),\"latitude\":\"(-?\\d{1,3}\\.\\d{4})\",\"idDistrito\":(\\d{1,2}),\"local\":\"([\\w \\\\]+)\",\"longitude\":\"(-?\\d{1,3}\\.\\d{4})\"";
            Regex idents = new Regex(identReg);

            MatchCollection matches = idents.Matches(text);

            foreach (Match match in matches)
            {
                Group code = match.Groups[4];
                Group place = match.Groups[7];
                //string pla = FixChars(place.Value);
                this.Add(Int32.Parse(code.Value), place.Value);
            }

        }
    }
}
