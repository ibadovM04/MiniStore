using Microsoft.AspNetCore.Mvc;
using MiniStore.Data;
using MiniStore.DTOs;

namespace MiniStore.Component
{
    public class SliderViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        public SliderViewComponent(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = _context.Sliders.Select(s => new SliderDto
            {
                SliderId = s.Id,               
                ImageUrl = _configuration["Folders:Sliders"] + s.ImageUrl,
                Text = s.Slogan,         

            })

                .OrderByDescending(s => s.SliderId).ToList();
            return View(sliders);
        }
    }
}
