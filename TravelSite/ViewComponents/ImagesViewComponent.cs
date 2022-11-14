using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace TravelSite.ViewComponents
{
    public class ImagesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> images = new()
            {
                "http://afisha.nyc/wp-content/uploads/2018/04/1493907885_ozbeoz-com-new-york-1.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/La_Tour_Eiffel_vue_de_la_Tour_Saint-Jacques%2C_Paris_ao%C3%BBt_2014_%282%29.jpg/1200px-La_Tour_Eiffel_vue_de_la_Tour_Saint-Jacques%2C_Paris_ao%C3%BBt_2014_%282%29.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Taj_Mahal_2012.jpg/640px-Taj_Mahal_2012.jpg","https://i.ytimg.com/vi/ldDxqhejy6k/maxresdefault.jpg"
            };

            return View(images);
        }
    }
}
