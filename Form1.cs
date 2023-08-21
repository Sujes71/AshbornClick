using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AshbornClick
{
    public partial class AshbornClick : Form
    {
    public struct POINT_API
    {
        public int X;

        public int Y;
    }

    private struct RECT
    {
        public int Left;

        public int Top;

        public int Right;

        public int Bottom;
    }

    public static int xPos;

    public static int yPos;

    public static int x;

    public static int y;

    public static int count;

    public static int timer;

    public static int dedo = 0;

    public static int random;

    public static int status;

    private Random Levi = new Random();

    public static Point newPoint;

    public static Point cursor;

    private IntPtr value;

    private IntPtr hwnd;

    private POINT_API mouse;

    private RECT infoWindow;

    private static Random num = new Random();

    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern void mouse_event(int dwflags, int dx, int dy, int cbuttons, int dwExtraInfo);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern bool GetCursorPos(out Point lpPoint);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    private static extern bool GetAsyncKeyState(Keys vkeys);

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int SendMessage(IntPtr intptr_0, int int_1, int int_2, IntPtr int_3);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    private static extern bool GetCursorPos(out POINT_API lpPoint);

    [DllImport("user32.dll")]
    private static extern IntPtr WindowFromPoint(POINT_API p);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    private static extern int GetWindowRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);
 
        public AshbornClick()
        {
            InitializeComponent();
        }

    private void GetWindow()
    {
        checked
        {
            if (Convert.ToDouble(Convert.ToString((int)GetForegroundWindow())) != 0.0)
            {
                GetCursorPos(out mouse);
                hwnd = WindowFromPoint(mouse);
                GetWindowRect(hwnd, out infoWindow);
                xPos = mouse.X - infoWindow.Left;
                yPos = mouse.Y - infoWindow.Top;
            }
            if (xPos < 0)
            {
                xPos = 0;
            }
            if (yPos < 0)
            {
                yPos = 0;
            }
            Console.Write(xPos);
            value = new IntPtr((yPos << 16) | (xPos & 0xFFFF));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            newPoint = default(Point);
            GetCursorPos(out newPoint);
            x = newPoint.X;
            y = newPoint.Y;
            Cursor.Position = new Point(xPos, yPos);
            for (int i = 0; i < Convert.ToInt16(numericUpDown2.Value); i++)
            {
                mouse_event(2, xPos, yPos, 0, 0);
                mouse_event(4, xPos, yPos, 0, 0);
                count++;
                textBox3.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) + 1);
            }
            Cursor.Position = new Point(x, y);
            Thread.Sleep(Convert.ToInt32(numericUpDown1.Value));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (GetAsyncKeyState(Keys.F1))
                {
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (GetAsyncKeyState(Keys.F1))
                {
                    timer1.Start();
                }
                if (GetAsyncKeyState(Keys.F2))
                {
                    timer1.Stop();
                }
                if (GetAsyncKeyState(Keys.F3))
                {
                    cursor = default(Point);
                    GetCursorPos(out cursor);
                    xPos = cursor.X;
                    yPos = cursor.Y;
                    GetWindow();
                    //TEMPORAL. En un futuro habra imagenes.
                    this.BackColor = Color.LimeGreen;
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
            }
        }
    }
}
