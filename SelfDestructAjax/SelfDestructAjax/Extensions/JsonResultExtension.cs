using System;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SelfDestructAjax.Extensions
{
    public static class JsonResultExtension
    {
        public static JsonResult SerializeObject(this JsonResult result, object rawObject)
        {

    result.Data = new JavaScriptSerializer().Serialize(rawObject);
    result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
    return result;
}
}
}