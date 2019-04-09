﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMultimedia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayButton.Content.Equals("Pause"))
            {
                media.Pause();
                PlayButton.Content = "Play";
            }
            else
            {
                media.Play();
                PlayButton.Content = "Pause";
            }
        }



        private void MuteButton_Click(object sender, RoutedEventArgs e)
        {
            media.IsMuted = !media.IsMuted;
            MuteButton.Content = media.IsMuted ? "UnMute" : "Mute";
        }
    }
}
