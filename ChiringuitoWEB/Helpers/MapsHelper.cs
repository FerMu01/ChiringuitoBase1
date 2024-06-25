using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiringuitoWEB.Helpers
{
    public static class MapsHelper
    {
        public static IHtmlString GetBingHtml(string key, string latitude, string longitude, string width, string height)
        {
            string bingMapHtml = $@"
                <iframe width='{width}' height='{height}' frameborder='0' style='border:0'
                src='https://www.bing.com/maps/embed?h={height}&w={width}&cp={latitude}~{longitude}&lvl=11&typ=d&sty=r&src=SHELL&FORM=MBEDV8'
                allowfullscreen></iframe>";
            return new HtmlString(bingMapHtml);
        }
    }
}