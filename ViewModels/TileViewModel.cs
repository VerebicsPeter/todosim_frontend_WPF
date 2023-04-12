using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.WPF.ViewModels
{
    public class TileViewModel : ViewModel
    {
        public int Size { get; set; }

        /* Types:
            0 - empty
            1 - road
            2 - powerline
            3 - residential
            4 - commercial
            5 - industrial
            6 - powerplant
            7 - firestation
            8 - policestation
            9 - stadium
        */

        private int _type;
        public int Type
        {   get { return _type; }
            set 
            { 
                if (_type !=  value)
                {
                    _type = value; OnPropertyChanged();
                }
            }
        }

        public bool IsAvailable
        {
            get { return _type == 0; }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Number { get; set; }

        public DelegateCommand? ClickCommand { get; set; }
    }
}
