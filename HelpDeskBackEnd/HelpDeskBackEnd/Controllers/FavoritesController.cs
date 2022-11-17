﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskBackEnd.Controllers
{
    [Route("favorites")]
    [ApiController]
    public class FavoritesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Favorite> GetAll()
        {
            return DAL.GetAllFavorites();
        }

        [HttpPost]
        public Favorite AddFavorite(Favorite fav)
        {
            return DAL.AddFavorite(fav);
        }

        [HttpDelete("{id}")]
        public void DeleteFav(int id)
        {
            DAL.DeleteFavorite(id);
        }

        [HttpPut]
        public void UpdateFavorite(Favorite fav)
        {
            DAL.UpdateFavorite(fav);
        }
    }
}
