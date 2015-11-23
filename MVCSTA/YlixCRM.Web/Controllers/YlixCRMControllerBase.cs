using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YlixCRM.Web.ActionResults;

namespace YlixCRM.Web.Controllers
{
    public class YlixCRMControllerBase : Controller
    {
        public BetterJsonResult<T> BetterJson<T>(T model)
        {
            return new BetterJsonResult<T>() { Data = model };
        }
    }
}