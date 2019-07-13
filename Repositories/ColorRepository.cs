using System.Collections.Generic;
using Playeras.Models;
using System.Linq;

namespace Playeras.Repositories
{
    public class ColorRepositories
    {
        static List<Color> colors = new List<Color>();

        public ColorRepositories()
        {
             Color color1 = new Color();
            color1.Id = 1;
            color1.Name = "Blue";
            color1.Value = "#0000FF";
            colors.Add(color1);

            Color color2 = new Color();
            color2.Id = 2;
            color2.Name = "Red";
            color2.Value = "#FF0000";
            colors.Add(color2);
        }

        public List<Color> GetAll()
        {
            return colors;
        }

        public Color Get(int id)
        {
            return colors.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Color color)
        {
            colors.Add(color);
        }
    }
}