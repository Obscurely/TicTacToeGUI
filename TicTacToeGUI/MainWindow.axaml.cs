using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.BaseWindows.Base;
using MessageBox.Avalonia.Enums;
using TicTacToeLib;

namespace TicTacToeGUI
{
    public class MainWindow : Window
    {
        private TicTacToe ticTacToe = new();
        private char currentSign = 'X';
        private int boxesUsed = 0;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void ButtonPos1_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(1, 1, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos1").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos2_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(2, 1, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos2").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos3_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(3, 1, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos3").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos4_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(1, 2, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos4").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos5_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(2, 2, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos5").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos6_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(3, 2, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos6").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos7_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(1, 3, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos7").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos8_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(2, 3, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos8").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void ButtonPos9_OnClick(object? sender, RoutedEventArgs e)
        {
            int response = ticTacToe.PutSign(3, 3, currentSign);
            if (response == 0)
            {
                this.FindControl<Button>("ButtonPos9").Content = currentSign;
                currentSign = currentSign == 'X' ? 'O' : 'X';
                boxesUsed += 1;
                CheckWinUI();
            }
        }

        private void CheckWinUI()
        {
            string win = ticTacToe.CheckWin();
            if (win.Equals("player x won"))
            {
                IMsBoxWindow<ButtonResult> winPrompt = MessageBox.Avalonia.MessageBoxManager.
                    GetMessageBoxStandardWindow("Won", "Player X Won The Game!");
                winPrompt.Show();
                ticTacToe.ResetGame();
                this.FindControl<Button>("ButtonPos1").Content = "";
                this.FindControl<Button>("ButtonPos2").Content = "";
                this.FindControl<Button>("ButtonPos3").Content = "";
                this.FindControl<Button>("ButtonPos4").Content = "";
                this.FindControl<Button>("ButtonPos5").Content = "";
                this.FindControl<Button>("ButtonPos6").Content = "";
                this.FindControl<Button>("ButtonPos7").Content = "";
                this.FindControl<Button>("ButtonPos8").Content = "";
                this.FindControl<Button>("ButtonPos9").Content = "";
                boxesUsed = 0;
            }
            else if (win.Equals("player o won"))
            {
                IMsBoxWindow<ButtonResult> winPrompt = MessageBox.Avalonia.MessageBoxManager.
                    GetMessageBoxStandardWindow("Won", "Player O Won The Game!");
                winPrompt.Show();
                ticTacToe.ResetGame();
                this.FindControl<Button>("ButtonPos1").Content = "";
                this.FindControl<Button>("ButtonPos2").Content = "";
                this.FindControl<Button>("ButtonPos3").Content = "";
                this.FindControl<Button>("ButtonPos4").Content = "";
                this.FindControl<Button>("ButtonPos5").Content = "";
                this.FindControl<Button>("ButtonPos6").Content = "";
                this.FindControl<Button>("ButtonPos7").Content = "";
                this.FindControl<Button>("ButtonPos8").Content = "";
                this.FindControl<Button>("ButtonPos9").Content = "";
                boxesUsed = 0;
            }
            else if (boxesUsed == 9)
            {
                IMsBoxWindow<ButtonResult> winPrompt = MessageBox.Avalonia.MessageBoxManager.
                    GetMessageBoxStandardWindow("Won", "Tie!");
                winPrompt.Show();
                ticTacToe.ResetGame();
                this.FindControl<Button>("ButtonPos1").Content = "";
                this.FindControl<Button>("ButtonPos2").Content = "";
                this.FindControl<Button>("ButtonPos3").Content = "";
                this.FindControl<Button>("ButtonPos4").Content = "";
                this.FindControl<Button>("ButtonPos5").Content = "";
                this.FindControl<Button>("ButtonPos6").Content = "";
                this.FindControl<Button>("ButtonPos7").Content = "";
                this.FindControl<Button>("ButtonPos8").Content = "";
                this.FindControl<Button>("ButtonPos9").Content = "";
                boxesUsed = 0;
            }
        }
    }
}