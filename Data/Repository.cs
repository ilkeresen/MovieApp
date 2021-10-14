using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>() { 
                new Movie() { 
                    Id=1, 
                    Name="Film Adı 1", 
                    Description="Film Açıklama 1", 
                    LongDescription="<p>There are many variations of passages of " +
                    "Lorem Ipsum available, but the majority have suffered alteration in " +
                    "some form, by injected humour, or randomised words which don't look even " +
                    "slightly believable. If you are going to use a passage of Lorem Ipsum, you " +
                    "need to be sure there isn't anything embarrassing hidden in the middle of " +
                    "text. All the Lorem Ipsum generators on the Internet tend to repeat predefined " +
                    "chunks as necessary, making this the first true generator on the Internet. " +
                    "It uses a dictionary of over 200 Latin words, combined with a handful of model s" +
                    "entence structures, to generate Lorem Ipsum which looks reasonable. The generated " +
                    "Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic" +
                    " words etc.</p>",
                    CategoryId=1,
                    ImageUrl="1.jpg"
                },
                new Movie() { 
                    Id=2, 
                    Name="Film Adı 2", 
                    Description="Film Açıklama 2",
                    LongDescription="<p>There are many variations of passages of " +
                    "Lorem Ipsum available, but the majority have suffered alteration in " +
                    "some form, by injected humour, or randomised words which don't look even " +
                    "slightly believable. If you are going to use a passage of Lorem Ipsum, you " +
                    "need to be sure there isn't anything embarrassing hidden in the middle of " +
                    "text. All the Lorem Ipsum generators on the Internet tend to repeat predefined " +
                    "chunks as necessary, making this the first true generator on the Internet. " +
                    "It uses a dictionary of over 200 Latin words, combined with a handful of model s" +
                    "entence structures, to generate Lorem Ipsum which looks reasonable. The generated " +
                    "Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic" +
                    " words etc.</p>",
                    CategoryId=2,
                    ImageUrl="2.jpg"
                },
                new Movie() { 
                    Id=3, 
                    Name="Film Adı 3", 
                    Description="Film Açıklama 3",
                    LongDescription="<p>There are many variations of passages of " +
                    "Lorem Ipsum available, but the majority have suffered alteration in " +
                    "some form, by injected humour, or randomised words which don't look even " +
                    "slightly believable. If you are going to use a passage of Lorem Ipsum, you " +
                    "need to be sure there isn't anything embarrassing hidden in the middle of " +
                    "text. All the Lorem Ipsum generators on the Internet tend to repeat predefined " +
                    "chunks as necessary, making this the first true generator on the Internet. " +
                    "It uses a dictionary of over 200 Latin words, combined with a handful of model s" +
                    "entence structures, to generate Lorem Ipsum which looks reasonable. The generated " +
                    "Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic" +
                    " words etc.</p>",
                    CategoryId=2,
                    ImageUrl="3.jpg"
                },
                new Movie() { 
                    Id=4, 
                    Name="Film Adı 4", 
                    Description="Film Açıklama 4",
                    LongDescription="<p>There are many variations of passages of " +
                    "Lorem Ipsum available, but the majority have suffered alteration in " +
                    "some form, by injected humour, or randomised words which don't look even " +
                    "slightly believable. If you are going to use a passage of Lorem Ipsum, you " +
                    "need to be sure there isn't anything embarrassing hidden in the middle of " +
                    "text. All the Lorem Ipsum generators on the Internet tend to repeat predefined " +
                    "chunks as necessary, making this the first true generator on the Internet. " +
                    "It uses a dictionary of over 200 Latin words, combined with a handful of model s" +
                    "entence structures, to generate Lorem Ipsum which looks reasonable. The generated " +
                    "Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic" +
                    " words etc.</p>",
                    CategoryId=3,
                    ImageUrl="4.jpg"
                },
                new Movie() { 
                    Id=4, 
                    Name="Film Adı 5", 
                    Description="Film Açıklama 5", 
                    LongDescription="<p>There are many variations of passages of " +
                    "Lorem Ipsum available, but the majority have suffered alteration in " +
                    "some form, by injected humour, or randomised words which don't look even " +
                    "slightly believable. If you are going to use a passage of Lorem Ipsum, you " +
                    "need to be sure there isn't anything embarrassing hidden in the middle of " +
                    "text. All the Lorem Ipsum generators on the Internet tend to repeat predefined " +
                    "chunks as necessary, making this the first true generator on the Internet. " +
                    "It uses a dictionary of over 200 Latin words, combined with a handful of model s" +
                    "entence structures, to generate Lorem Ipsum which looks reasonable. The generated " +
                    "Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic" +
                    " words etc.</p>",
                    CategoryId=2,
                    ImageUrl="5.jpg"
                },
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
