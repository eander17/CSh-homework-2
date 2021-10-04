using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonE_Assignment2
{
    public class ListManager
    {

        /// <summary>
        /// method that builds a list of cereal objects. 
        /// </summary>
        /// <returns></returns>
        public static List<Cereal> LoadCereal()
        {
            var output = new List<Cereal>();
            try
            {
                StreamReader reader = new StreamReader("cereal.csv"); //reader reads the text file. 

                reader.ReadLine(); //getting rid of first line in file. 

                //continues until reader reaches the end of the text file. 
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    //populating Cereal class array with a bunch of cereal objects and assigns all their values appropriately. 
                    output.Add(new Cereal()
                    {
                        CerealName = data[0],
                        CerealMfr = data[1],
                        CerealType = data[2],
                        CerealCals = data[3],
                        CerealProtein = data[4],
                        CerealFat = data[5],
                        CerealSodium = data[6],
                        CerealFiber = data[7],
                        CerealCarbs = data[8],
                        CerealSugars = data[9],
                        CerealPotass = data[10],
                        CerealVitamins = data[11],
                        CerealShelf = data[12],
                        CerealWeight = data[13],
                        CerealCups = data[14],
                        CerealRating = data[15]
                    });                     
                }

                return output;
            }
            catch(Exception e) //in case something goes wrong. 
            {
                Console.Write(e.Message);
                throw; 
            } 
        }


    }
}
