using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TurtleGraphics;

namespace TurtleLair
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Turtle t;
        private int distance = 20;
        private int angle = 45;
        private Dictionary<(int x, int y), Border> borders = new Dictionary<(int x, int y), Border>();

        public MainWindow()
        {
            InitializeComponent();

            // We could do this in the XAML, but since we need one for
            // evey cell in the coordinates grid, it's easier to program it
            addBorders();
        }

        // Your code goes in the solve1, 2, etc methods below
        // Try to use as few lines as possible for each challenge
        // Hint - Loops are your friend

        private void solve1_Click(object sender, RoutedEventArgs e)
        {
            // Clear the canvas or it will get messy
            ClearCanvas();
            //It's not perfectly on the grid, but I feel like id have to get into decimals to make it, and I don't want to.
            // Go to 360,420, but don't draw while moving (MoveTo, vs. GoTo)
            t.MoveTo(319, 457);
            for (int i = 0; i <= 4; i++)
            {
                t.Forward(160);
                t.Left(90);
            }
        }

        private void solve2_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            //Someone said that just simply Touching the colored grid was enough so that is what I did.
            int length = 160;
            t.MoveTo(0, 10);
            t.GoTo(0, 760);
            for (int i = 0; i <= 7; i++)
            {
                
                    t.MoveTo(length, 760);
                    t.Left(90);
                    length = length + 160;
               
                    t.Forward(750);
                    t.Left(180);
                    t.Forward(750);
                    t.Left(90);

                    
                
                
            }


            


        }
      
        

        private void solve3_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            for (int i = 0; i < 3; i++)
            {
                t.Forward(80);
                t.Left(90);
                t.Forward(80);
                t.Left(270);
            }
            t.Left(90);
            t.Forward(65);
            t.Left(90);
            t.Forward(80);
            t.Left(270);
            t.Forward(70);
            t.Left(90);
            t.Forward(160);
            t.Left(90);
            t.Forward(70);
            t.Left(270);
            for (int i = 0; i < 2; i++)
            {
                t.Forward(80);
                t.Left(90);
            }
            t.Left(180);
            t.Forward(80);
            t.Left(90);
            t.Forward(150);
            t.Left(90);
            t.Forward(80);
            t.Left(270);
            t.Forward(75);
            t.Left(90);
            t.Forward(80);
            t.MoveTo(400, 230);
            for (int i = 0; i < 4; i++)
            {
                t.Forward(80);
                t.Left(90);
            }
        }

        private void solve4_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            t.MoveTo(0, 75);
            for (int i = 0; i < 9; i++)
            {
                t.Forward(80);
                t.Left(270);
                t.Forward(80);
                t.Left(90);
            }
                
        }

        private void solve5_Click(object sender, RoutedEventArgs e)
        {
            // I am not proud of this spaghetti code.
            ClearCanvas();
            int Move = 0;
            int Square = 0;
            
            t.MoveTo(0, 0);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 0);
                    Square = 0;
                }
            }
                t.MoveTo(80, 75);
            Move = 80;
            Square = 0;
            for (int u = 0; u < 25; u++)
                {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 75);
                    Square = 0;
                }
            }
            Move = 0;
            Square = 0;

            t.MoveTo(0, 150);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 150);
                    Square = 0;
                }
            }
            Move = 75;
            Square = 0;

            t.MoveTo(75, 230);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 230);
                    Square = 0;
                }
            }
            Move = 0;
            Square = 0;

            t.MoveTo(0, 300);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 300);
                    Square = 0;
                }
            }
            Move = 75;
            Square = 0;

            t.MoveTo(75, 380);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 380);
                    Square = 0;
                }
            }
            Move = 0;
            Square = 0;

            t.MoveTo(0, 455);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 455);
                    Square = 0;
                }
            }
            Move = 75;
            Square = 0;

            t.MoveTo(75, 530);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 530);
                    Square = 0;
                }
            }
            Move = 0;
            Square = 0;

            t.MoveTo(0, 610);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 610);
                    Square = 0;
                }
            }
            Move = 75;
            Square = 0;

            t.MoveTo(75, 690);
            for (int i = 0; i < 25; i++)
            {
                if (Square != 4)
                {
                    t.Forward(80);
                    t.Left(270);
                    Square++;
                }
                else
                {
                    Move = Move + 160;
                    t.MoveTo(Move, 690);
                    Square = 0;
                }
            }

        }

        // Ultra special maneuver (whatever amazing thing you want to create
        private void Special_Click(object sender, RoutedEventArgs e)
        {
            // This is probably the worst way to do an infinite loop, especially as this could be a memory leak, but this is what ran.
            int X = 32;
            int Y = 32;
            int Star = 0;
            int Loop = 5; 
            ClearCanvas(true);
            for (int i = 0; i < Loop; i++)
            {
                if (Star != 8)
                {
                    t.Left(90);
                    t.Forward(80);
                    t.Left(120);
                    Star++;
                    Loop = i + Loop;
                }
                else
                {
                    Random rnd = new Random();
                    X = rnd.Next(0, 780);
                    Y = rnd.Next(0, 755);
                    t.MoveTo(X, Y);
                    Star = 0;
                    
                }
            }
        }

        #region Show Challenges Buttons
        private void show1_Click(object sender, RoutedEventArgs e)
        {
            ClearChallenges();
            borders[(4, 4)].Background = Brushes.Green;
            borders[(5, 4)].Background = Brushes.Green;
            borders[(4, 5)].Background = Brushes.Green;
            borders[(5, 5)].Background = Brushes.Green;
        }

        private void show2_Click(object sender, RoutedEventArgs e)
        {
            ClearChallenges();
            List<int> cols = new List<int> { 0, 2, 4, 6, 8 };
            foreach (int c in cols)
                for (int y = 0; y < 10; y++) { borders[(c, y)].Background = Brushes.YellowGreen; };
        }

        private void show3_Click(object sender, RoutedEventArgs e)
        {
            ClearChallenges();
            borders[(5, 4)].Background = Brushes.Yellow;
            borders[(5, 3)].Background = Brushes.Yellow;
            borders[(6, 3)].Background = Brushes.Yellow;
            borders[(6, 2)].Background = Brushes.Yellow;
            borders[(7, 2)].Background = Brushes.Yellow;
            borders[(7, 1)].Background = Brushes.Yellow;
            borders[(6, 1)].Background = Brushes.Yellow;
            borders[(6, 0)].Background = Brushes.Yellow;
            borders[(5, 0)].Background = Brushes.Yellow;
            borders[(5, 1)].Background = Brushes.Yellow;
            borders[(4, 1)].Background = Brushes.Yellow;
            borders[(4, 2)].Background = Brushes.Yellow;
            borders[(3, 2)].Background = Brushes.Yellow;
            borders[(3, 3)].Background = Brushes.Yellow;
            borders[(4, 3)].Background = Brushes.Yellow;
            borders[(4, 4)].Background = Brushes.Yellow;

        }

        private void show4_Click(object sender, RoutedEventArgs e)
        {
            ClearChallenges();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x >= y)
                        borders[(x,y)].Background = Brushes.Orange;
                }
            }
        }

        private void show5_Click(object sender, RoutedEventArgs e)
        {
            ClearChallenges();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if ((x + y) % 2 == 0)
                        borders[(x, y)].Background = Brushes.Red;
                }
            }
        }
        #endregion

        #region Control Buttons + some utility methods
        /// <summary>
        /// Put border around all cells in the coordinates grid
        /// </summary>
        private void addBorders()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    var border = new Border
                    {
                        BorderBrush = Brushes.Gray,
                        BorderThickness = new Thickness(1)
                    };
                    Grid.SetRow(border, y);
                    Grid.SetColumn(border, x);
                    gridCoordinates.Children.Add(border);
                    borders.Add((x, y), border);
                }
            }
        }

        /// <summary>
        /// Remove background from all coordinate cells
        /// </summary>
        private void ClearChallenges()
        {
            foreach (Border b in borders.Values)
            {
                b.Background = Brushes.Transparent;
            }
        }

        /// <summary>
        /// Clear the turtle canvas and reset to home.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas(true);
        }

        private void ClearCanvas(bool clearChallenges = false)
        {
            for (int i = canvas.Children.Count - 1; i >= 0; i--)
            {
                UIElement c = canvas.Children[i];
                if (c is Line)
                    canvas.Children.Remove(c);
            }

            if (clearChallenges) ClearChallenges();
            t.Home();
        }

        /// <summary>
        /// Reset turtle to home position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            t.Home();
        }

        /// <summary>
        /// Move forward default distance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            t.SetBrush(255,
                (byte)RedSlider.Value,
                (byte)GreenSlider.Value,
                (byte)BlueSlider.Value);
            t.Forward(distance);

        }

        /// <summary>
        /// Things to do once the main window has completed loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            t = new Turtle(canvas);
        }

        /// <summary>
        /// Turn left the default number of degrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Left_Click(object sender, RoutedEventArgs e)
        {
            t.Left(angle);
        }

        /// <summary>
        /// Update color information when the color sliders change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorPanel.Background =
                new SolidColorBrush(
                    System.Windows.Media.Color.FromArgb(
                    255,
                    (byte)RedSlider.Value,
                    (byte)GreenSlider.Value,
                    (byte)BlueSlider.Value)
                );

            lblRed.Content = RedSlider.Value.ToString();
            lblGreen.Content = GreenSlider.Value.ToString();
            lblBlue.Content = BlueSlider.Value.ToString();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoords.Content = $"({e.GetPosition(canvas).X}, {e.GetPosition(canvas).Y})";
        }
        #endregion

        #region Demo Stuff


        private void Demo1_Click(object sender, RoutedEventArgs e)
        {
            Turtle t = new Turtle(canvas);
            t.TimerDelay = 10;
       
            Examples.ColorCircle(t);
        }

        private void Demo2_Click(object sender, RoutedEventArgs e)
        {
            Turtle t = new Turtle(canvas);
            t.SetPointerColor(Brushes.Red);
            t.TimerDelay = 20;

            Examples.DrawPolygons(t);
        }

        private void Demo3_Click(object sender, RoutedEventArgs e)
        {
            Turtle t = new Turtle(canvas);
            t.TimerDelay = 20;

            Examples.DrawTree(t);

        }

        /// <summary>
        /// An example of drawing a square 
        /// </summary>
        /// <param name="t">Turtle to use</param>
        /// <param name="x">X start of square</param>
        /// <param name="y">Y start of square</param>
        /// <param name="size">Size of square</param>
        private void square(Turtle t, int x, int y, int size)
        {
            t.MoveTo(x, y);
            List<Brush> brushes = new List<Brush>()
            {
                Brushes.Green, Brushes.Blue,Brushes.Red,
                Brushes.Orange
            };

            for (int i = 0; i < 4; i++)
            {
                t.SetBrush(brushes[i]);
                t.Forward(size);
                t.Right(90);
            }
        }






        #endregion Demo Stuff


    }
}
