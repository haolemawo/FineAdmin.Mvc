﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FineAdmin.Web.Controllers;
using FineAdmin.IService;
using FineAdmin.Model;

namespace FineAdmin.Web.Areas.Permissions.Controllers
{
    public class ItemsController : BaseController
    {
        // GET: Permissions/Items
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }


    }
}