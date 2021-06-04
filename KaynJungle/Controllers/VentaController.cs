    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using KaynJungle.BL.Contracts;
    using KaynJungle.Core.DTO;
    using KaynJungle.DAL.Models;

    namespace KaynJungle.API.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class VentaController : ControllerBase
        {
            public IVentaBL _ventaBL { get; set; }


            public VentaController(IVentaBL venta)
            {
                _ventaBL = venta;
            }

            [HttpGet]
            public IEnumerable<VentasDTO> Get()
            {
                return _ventaBL.Get();
            }


        }
    }