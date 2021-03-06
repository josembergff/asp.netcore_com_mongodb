﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoApi.Data;
using MongoApi.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ProdutosController : CrudController<Produto> {
        private IRepository Repository { get; }

        public ProdutosController (IRepository repository) : base (repository) {
            Repository = repository;
        }

    }
}