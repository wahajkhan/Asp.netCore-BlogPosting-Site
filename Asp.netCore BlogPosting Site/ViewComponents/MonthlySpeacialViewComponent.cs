using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore_BlogPosting_Site.Models;

namespace Asp.netCore_BlogPosting_Site.ViewComponents
{
    [ViewComponent]
    public class MonthlySpeacialViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var MonthlySpeacial = new[]
            {
                new MonthlySpeacial()
                {
                    ID=1,
                    Name="Day Spa Package",
                    Price=250,
                    ImgSrc="/images/calm_bug.gif",
                    ImgAlt="California Calm"
                }, new MonthlySpeacial()
                {
                    ID=2,
                    Name="2 Day Salton Sea",
                    Price=350,
                    ImgSrc="/images/desert_bug.gif",
                    ImgAlt="From desert to sea"
                }, new MonthlySpeacial()
                {
                    ID=3,
                    Name="Big Sur Retreat",
                    Price=620,
                    ImgSrc="/images/backpack_bug.gif",
                    ImgAlt="Backpack Cali"
                }, new MonthlySpeacial()
                {
                    ID=4,
                    Name="Tapas &amp; Groves",
                    Price=150,
                    ImgSrc="/images/taste_bug.gif",
                    ImgAlt="Taste of California"
                }
            };


            return View(MonthlySpeacial);
        }
    }
}
