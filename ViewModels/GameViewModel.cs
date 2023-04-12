using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game.WPF.ViewModels
{
    public class GameViewModel : ViewModel
    {
        public const int Size = 50;

        public ObservableCollection<TileViewModel> Tiles { get; set; }

        public DelegateCommand NewCommand { get; private set; }

        public DelegateCommand SaveCommand { get; private set; }

        public DelegateCommand LoadCommand { get; private set; }

        public DelegateCommand PauseCommand { get; private set; }

        public DelegateCommand SpeedCommand { get; private set; }

        public DelegateCommand ExitCommand { get; private set; }

        public DelegateCommand SetActive { get; private set; }

        public bool IsTimerEnabled { get; set; }

        private int _activeTile;
        public int ActiveTile
        {   get { return _activeTile; }
            set
            {
                if (value !=  _activeTile)
                {
                    _activeTile = value; OnPropertyChanged();
                }
            }
        }

        #region Events

        public event EventHandler? NewGame;

        public event EventHandler? SaveGame;

        public event EventHandler? LoadGame;

        public event EventHandler? SpeedChange;

        public event EventHandler? ActiveTileChanged;

        public event EventHandler? ExitGame;

        #endregion

        public GameViewModel(/*GameModel model*/)
        {
            // parancsok kezelése
            NewCommand = new DelegateCommand(param => OnNewGame());
            SaveCommand = new DelegateCommand(param => OnSaveGame());
            LoadCommand = new DelegateCommand(param => OnLoadGame());
            PauseCommand = new DelegateCommand(param => OnSpeedChanged());
            SpeedCommand = new DelegateCommand(param => OnSpeedChanged());
            ExitCommand = new DelegateCommand(param => OnExitGame());
            SetActive = new DelegateCommand(param => SetActiveTile(Convert.ToInt32(param)));

            // játéktábla létrehozása
            Tiles = new ObservableCollection<TileViewModel>();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var tile = new TileViewModel
                    {
                        Type = 0,
                        X = i, Y = j,
                        Number = i * Size + j,
                        ClickCommand = new DelegateCommand(param => OnTileClick(Convert.ToInt32(param)))
                    };

                    Tiles.Add(tile);
                }
            }
            _activeTile = 1;

            IsTimerEnabled = true;
        }

        private void OnTileClick(int i)
        {
            var tile = Tiles[i];
            if (tile.IsAvailable || ActiveTile == 0) tile.Type = ActiveTile;
        }

        private void SetActiveTile(int value)
        {
            ActiveTile = value;
        }

        private void OnSpeedChanged()
        {
            throw new NotImplementedException();
        }
        private void OnNewGame()
        {
            throw new NotImplementedException();
        }
        private void OnSaveGame()
        {
            throw new NotImplementedException();
        }

        private void OnLoadGame()
        {
            throw new NotImplementedException();
        }

        private void OnExitGame()
        {
            throw new NotImplementedException();
        }
    }
}