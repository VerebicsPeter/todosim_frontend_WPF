using System;
using System.Collections.ObjectModel;

namespace Game.WPF.GameViewModels
{
    public class GameViewModel : ViewModel
    {
        public ObservableCollection<TileViewModel> Tiles { get; set; }

        public void LoadContent()
        {
           
        }

        public void Update()
        {

        }

        public void Draw()
        {
            
        }
    }
}