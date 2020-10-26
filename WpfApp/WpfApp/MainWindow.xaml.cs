using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SongLyricsViewer_OnClick(object sender, RoutedEventArgs e)
        {
            SongLyricsViewer.Visibility = Visibility.Visible;
            Grid.SetRow(SongStarter, 6);
            SongLyrics.Text = StartTheSong();
            SongStarter.Content = "Hit to restart the song!";

            string StartTheSong()
            {
                var lyrics = "Start of the song!" + Environment.NewLine + Environment.NewLine;

                // Lyrics of the song
                for (var i = 99; i > 0; i--)
                {
                    lyrics += Environment.NewLine + i + $" bottle{(i == 1 ? "" : "s")} of beer on the wall,";
                    lyrics += Environment.NewLine + i + $" bottle{(i == 1 ? "" : "s")} of beer!";
                    lyrics += Environment.NewLine + "Take one down,";
                    lyrics += Environment.NewLine + "Pass it around,";
                    lyrics += Environment.NewLine +
                              $"{(i - 1 == 0 ? "No more bottles" : i - 1 + $" bottle{(i - 1 == 1 ? "" : "s")}")} of beer on the wall!" +
                              Environment.NewLine;
                }

                lyrics += Environment.NewLine + Environment.NewLine + "End of the song!";

                return lyrics;
            }
        }
    }
}