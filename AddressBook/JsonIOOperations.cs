using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Address_Book
{
    class JsonIOOperations
    {
        public static void JsonIO(Dictionary<string, List<AddressBookSystem>> addressbooknames)
        {
            string jsonfilePath = @"C:\Users\charan kanduri\source\repos\AddressBook_BridgeLabz\AddressBook\JsonIO.json";
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter stream = new StreamWriter(jsonfilePath))
            using (JsonWriter jsonWriter = new JsonTextWriter(stream))
            {
                //Converting from List to Json Object
                jsonSerializer.Serialize(jsonWriter, addressbooknames);
            }

            //Reading from Json File-> Converting from Json Object to List
            Dictionary<string, List<AddressBookSystem>> jsonList = JsonConvert.DeserializeObject<Dictionary<string, List<AddressBookSystem>>>(File.ReadAllText(jsonfilePath));
            foreach (KeyValuePair<string, List<AddressBookSystem>> i in jsonList)
            {
                Console.WriteLine("\nAddressBook Name: {0}", i.Key);
                foreach (var j in i.Value)
                {
                    Console.WriteLine(j.ToString());
                }


            }
        }
    }
}

    
