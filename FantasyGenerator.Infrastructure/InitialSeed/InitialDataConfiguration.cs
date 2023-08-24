using FantasyGenerator.Infrastructure.Data.JsonModels;
using FantasyGenerator.Infrastructure.Data.Modles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace FantasyGenerator.Infrastructure.InitialSeed
{
    internal class InitialDataConfiguration<T> : IEntityTypeConfiguration<T>
        where T : class
    {
        private readonly string filePath;

        public InitialDataConfiguration(string filePath)
        {
            this.filePath = filePath;
        }

        public void Configure(EntityTypeBuilder<T> builder)
        {
            string? jsonData = GetFromFile();

            if (jsonData != null)
            {
                NamesData namesData = JsonConvert.DeserializeObject<NamesData>(jsonData);
                List<NpcName> data = new List<NpcName>();
                int counter = 1;

                foreach (var category in namesData.Human)
                {
                    //Console.WriteLine("Category: " + category.Key);
                    foreach (var gender in category.Value)
                    {
                        //Console.WriteLine("Gender: " + gender.Key);
                        foreach (var name in gender.Value)
                        {

                            //Console.WriteLine(name);
                            NpcName npcName = new NpcName()
                            {
                                Id = counter++,
                                Name = name,
                                CategoryName = category.Key,
                                SuitableRace = nameof(namesData.Human),
                                IsPublic = true

                            };

                            if (gender.Key == "Male")
                            {
                                npcName.IsMale = true;
                                npcName.IsFirstName = true;
                            }
                            else if(gender.Key == "Female")
                            {
                                npcName.IsMale = false;
                                npcName.IsFirstName = true;
                            }
                            else if(gender.Key == "LastName")
                            {
                                npcName.IsMale = true;
                                npcName.IsFirstName = false;
                            }

                            data.Add(npcName);
                        }
                    }
                }

                builder.HasData(data);
            }
        }

        //public IEnumerable<T>? SetName(EntityTypeBuilder<T> builder)
        //{
        //    string? jsonData = GetFromFile();

        //    if (jsonData != null)
        //    {
        //        List<T> data = JsonConvert.DeserializeObject<List<T>>(jsonData).Select();

        //        //builder.HasData(data);
        //    }

        //    return null;
        //}

        private string? GetFromFile()
        {
            string? result = null;

            if (File.Exists(filePath))
            {
                result = File.ReadAllText(filePath);
            }

            return result;

            //return File.Exists(filePath) ? File.ReadAllText(filePath) : null;
        }
    }
}
