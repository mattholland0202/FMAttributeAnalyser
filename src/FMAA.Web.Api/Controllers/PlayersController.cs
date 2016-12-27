using FMAA.BLL.Interfaces;
using FMAA.Web.Api.Models.Return;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FMAA.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly IBLL bll;

        public PlayersController(IBLL bll)
        {
            this.bll = bll;
        }

        /// <summary>
        /// Get a collection of all Players
        /// </summary>
        /// <response code="200">A collection of Players is returned</response>
        /// <response code="500">An error occurred</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<PlayerModel>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            try
            {
                var players = bll.Players.GetAll();
                return Ok(players);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
