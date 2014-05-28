using System.Collections.ObjectModel;
using System.Linq;

namespace BasCal_SilverlightClient.Model
{
    public class Week
    {
        public ObservableCollection<Day> Days { get; set; }  

        public Week(ObservableCollection<Day> days)
        {
            this.Days = new ObservableCollection<Day>(days.OrderBy(x => x.Date));     
        }
    }
}
