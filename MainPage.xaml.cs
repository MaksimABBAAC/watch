using System;
using System.Timers;
using Microsoft.Maui.Controls;

namespace watch
{
    public partial class MainPage : ContentPage
    {
        private System.Timers.Timer _timer;
        private Grid _grid;

        public MainPage()
        {
            InitializeComponent();
            CreateGrid();
            StartTimer();
        }

        private void CreateGrid()
        {
            _grid = new Grid();
            _grid.HorizontalOptions = LayoutOptions.Center;
            _grid.VerticalOptions = LayoutOptions.Center; 
            Content = _grid;
            DrawDigits();
        }

        private void StartTimer()
        {
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() => UpdateTime());
        }

        private void UpdateTime()
        {
            DrawDigits();
        }

        private void DrawDigits()
        {
            _grid.Clear();

            var time = DateTime.Now.ToString("HH:mm:ss");

            for (int i = 0; i < time.Length; i++)
            {
                char digit = time[i];
                View digitView = null;

                switch (digit)
                {
                    case '0':
                        digitView = DrawDigit0();
                        break;
                    case '1':
                        digitView = DrawDigit1();
                        break;
                    case '2':
                        digitView = DrawDigit2();
                        break;
                    case '3':
                        digitView = DrawDigit3();
                        break;
                    case '4':
                        digitView = DrawDigit4();
                        break;
                    case '5':
                        digitView = DrawDigit5();
                        break;
                    case '6':
                        digitView = DrawDigit6();
                        break;
                    case '7':
                        digitView = DrawDigit7();
                        break;
                    case '8':
                        digitView = DrawDigit8();
                        break;
                    case '9':
                        digitView = DrawDigit9();
                        break;
                    case ':':
                        digitView = DrawDigitPoint();
                        break;
                }

                if (digitView != null)
                {
                    _grid.AddWithSpan(digitView, 0, i);
                }
            }
        }

        private View DrawDigit0()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 150,
            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Левый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, 70, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit1()
        {

            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });

            return grid;
        }
        private View DrawDigit2()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 40, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Левый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit3()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit4()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });

            return grid;
        }
        private View DrawDigit5()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit6()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Левый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, 70, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit7()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            

            return grid;
        }
        private View DrawDigit8()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Левый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, 70, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigit9()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, -140, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(-30, -70, 0, 0) });
            // Правый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, -70, 0, 0) });
            // Средний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 0, 0, 0) });
            // Правый нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 60, Margin = new Thickness(30, 70, 0, 0) });
            // Нижний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 30, HeightRequest = 10, Margin = new Thickness(0, 140, 0, 0) });

            return grid;
        }
        private View DrawDigitPoint()
        {
            var grid = new Grid
            {
                WidthRequest = 60,
                HeightRequest = 170,

            };

            // Верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 10, Margin = new Thickness(0, -70, 0, 0) });
            // Левый верхний сегмент
            grid.Children.Add(new BoxView { Color = Colors.DarkGreen, WidthRequest = 10, HeightRequest = 10, Margin = new Thickness(0, 70, 0, 0) });

            return grid;
        }
    }
}

