using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.WebHost;
using System.Web.Routing;

namespace FileUpload
{
    public class CustomBufferPolicySelector : WebHostBufferPolicySelector
    {
        public override bool UseBufferedInputStream(object hostContext)
        {
            var context = hostContext as HttpContextBase;

            if (context != null)
            {
                var stream = context.Request.Path.Contains("file");

                if(stream)
                {                   
                    return false;
                }
            }

            return true; // buffer
        }
    }
}