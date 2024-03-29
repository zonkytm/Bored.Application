using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bored.Application.Api
{
    public class ActivityModel
    {
        public string Activity {  get; set; }
		public double Accessibility {  get; set; }
		public string Type {  get; set; }
		public int Participants { get; set; }
		public double Price {  get; set; }
		public string Link {  get; set; }
		public string Key { get; set; }
    }
}
