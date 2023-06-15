using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Yıldız Savaşları: Bölüm III - Sith'in İntikamı",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 29 Dakika",
                    price = 50,
                    picturePath = basePath + "\\Pictures\\MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_FMjpg_UX1000_.jpg"
                },
                   new Movie()
                {
                    movieName = "Star Wars: Klon Savaşları",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "\\Pictures\\star-wars-the-clone-wars-01.jpg"
                },
                new Movie()
                {
                    movieName = "Star Wars: Son Jedi",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "\\Pictures\\Star_Wars_Son_Jedi_afiş.jpg"
                },
                new Movie()
                {
                    movieName = "Star Trek",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "\\Pictures\\MV5BOWFhYjE4NzMtOWJmZi00NzEyLTg5NTctYmIxMTU1ZDIxMDAyXkEyXkFqcGdeQXVyNTE1NjY5Mg@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie()
                {
                    movieName = "Yüzüklerin Efendisi: Kralın Dönüşü",
                    category = Category.fantastik,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "\\Pictures\\39187.jpg"
                },

             new Movie()
                {
                    movieName = "Transformers: Yenilenlerin İntikam",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "\\Pictures\\132420.jpg"
                },


            };
        }
    }
}
