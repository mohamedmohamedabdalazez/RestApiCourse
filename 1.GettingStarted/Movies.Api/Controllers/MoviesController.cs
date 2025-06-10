using Microsoft.AspNetCore.Mvc;
using Movies.Application.Repositories;

namespace Movies.Api.Controllers;
[ApiController]
public class MoviesController : ControllerBase
{
   private readonly IMovieRepository _moveRepository;

   public MoviesController(IMovieRepository moveRepository)
   {
      _moveRepository = moveRepository;
   }
}