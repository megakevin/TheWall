using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Extensions
{
    public static class Extensions
    {
        public static object[] ToPieChartSeries(this IEnumerable<Feedback> data)
        {
            var returnObject = new List<object>();

            foreach (var item in data)
            {
                returnObject.Add(new object[] { item.Student.Gender.Name, item.Mood.Description});
            }

            return returnObject.ToArray();
        }
    }
}
