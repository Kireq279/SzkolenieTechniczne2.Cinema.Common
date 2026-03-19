using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne2.Cinema.Common.Entities;
using SzkolenieTechniczne2.Cinema.Domain.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain.Repositories
{
    internal interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(long id);
        Task<IEnumerable<Movie>> GetAllAsync();

        Task<IEnumerable<MovieCategory>> GetAllCategoriesAsync();

        Task<bool> IsMovieExistAsync(string name,int year);

        Task<bool> IsSeanceExistAsync(DateTime seanceDate);

        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task<Movie> GetSeanceDetailsAsync(long id);

        Task<List<Seance>> GetSeancesByMovieIdAsync(long movieId);

        Task ReamoveAsync(Movie movie);


    }
}
