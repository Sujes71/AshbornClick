using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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

    public static int xJump;

    public static int yJump;

    public static int xGo;

    public static int yGo;

    public static int number;

    public static Point newPoint;

    public static Point cursor;

    private IntPtr hwnd;

    private POINT_API mouse;

    private RECT infoWindow;

    Random rnd = new Random();

    private int lastNum = -1;

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

        public AshbornClick()
        {
            InitializeComponent();
        }

        private int[] GetWindow(int x, int y)
        {
                if (Convert.ToDouble(Convert.ToString((int)GetForegroundWindow())) != 0.0)
                {
                    GetCursorPos(out mouse);
                    hwnd = WindowFromPoint(mouse);
                    GetWindowRect(hwnd, out infoWindow);
                    x = mouse.X - infoWindow.Left;
                    y = mouse.Y - infoWindow.Top;
                }
                if (x < 0)
                {
                    x = 0;
                }
                if (y < 0)
                {
                    y = 0;
                }
                int[] result = new int[2];
                result[0] = x;
                result[1] = y;

            return result;
        }
        private int[] GetWindowGo(int x, int y)
        {
            if (Convert.ToDouble(Convert.ToString((int)GetForegroundWindow())) != 0.0)
            {
                mouse.X = x;
                mouse.Y = y;
                hwnd = WindowFromPoint(mouse);
                GetWindowRect(hwnd, out infoWindow);
                x = mouse.X - infoWindow.Left;
                y = mouse.Y - infoWindow.Top;
            }
            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }
            int[] result = new int[2];
            result[0] = x;
            result[1] = y;

            return result;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr int_ = new IntPtr((yPos << 16) | (xPos & 0xFFFF));
            for (decimal num = default(decimal); num < numericUpDownMultiply.Value; ++num)
            {
                SendMessage(hwnd, 513, 0, int_);
                SendMessage(hwnd, 514, 0, int_);
                labelCounter.Text = Convert.ToString(Convert.ToInt16(labelCounter.Text) + 1);
            }
            Thread.Sleep(Convert.ToInt32(numericUpDownSpeed.Value));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBoxPress.Checked)
            {
                if (GetAsyncKeyState(Keys.F1))
                {
                    timer1.Start();
                    if (checkBoxJump.Checked)
                        timer3.Start();
                }
                else
                {
                    timer1.Stop();
                    labelCounter.Text = "0";
                    timer3.Stop();
                }
            }
            else
            {
                if (GetAsyncKeyState(Keys.F1))
                {
                    timer1.Start();
                    if(checkBoxJump.Checked)
                        timer3.Start();
                    if(checkboxGo.Checked)
                        timer4.Start();
                }
                if (GetAsyncKeyState(Keys.F2))
                {
                    timer1.Stop();
                    labelCounter.Text = "0";
                    timer3.Stop();
                    timer4.Stop();
                }
                if (GetAsyncKeyState(Keys.F3))
                {
                    cursor = default(Point);
                    GetCursorPos(out cursor);
                    xPos = cursor.X;
                    yPos = cursor.Y;
                    int[] windowCoords = GetWindow(xPos, yPos);
                    xPos = windowCoords[0];
                    yPos = windowCoords[1];

                    if (!labelCounter.Visible)
                    {
                        labelCounter.Visible = true;
                        labelMultiply.Visible = true;
                        labelSpeed.Visible = true;
                        numericUpDownMultiply.Visible = true;
                        numericUpDownSpeed.Visible = true;
                        labelCounter.Visible = true;
                        checkboxGo.Visible = true;
                        checkBoxJump.Visible = true;
                        checkBoxPress.Visible = true;
                        colorGo.Visible = true;
                        colorJump.Visible = true;
                        colorPress.Visible = true;
                    }
                }
                if (GetAsyncKeyState(Keys.F10) && checkBoxJump.Checked )
                {
                    cursor = default(Point);
                    GetCursorPos(out cursor);
                    xJump = cursor.X;
                    yJump = cursor.Y;
                    int[] windowCoords = GetWindow(xJump, yJump);
                    xJump = windowCoords[0];
                    yJump = windowCoords[1];
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            IntPtr int_ = new IntPtr((yJump << 16) | (xJump & 0xFFFF));
            SendMessage(hwnd, 513, 0, int_);
            SendMessage(hwnd, 514, 0, int_);
        }

        private void checkBoxPress_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPress.Checked)
            {
                this.colorPress.BackColor = Color.Aqua;
                checkboxGo.Checked = false;
                checkboxGo.Enabled = false;
            }
            else
            {
                this.colorPress.BackColor = Color.White;
                this.checkboxGo.Enabled = true;
            }
        }

        private void checkBoxJump_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJump.Checked)
            {
                this.colorJump.BackColor = Color.Gold;
            }
            else
            {
                this.colorJump.BackColor = Color.White; 
            }
        }

        private void checkboxGo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxGo.Checked)
            {
                this.colorGo.BackColor = Color.BlueViolet;
            }
            else
            {
                this.colorGo.BackColor = Color.White;
            }
        }

        private void AshbornClick_Load(object sender, EventArgs e)
        {
            labelCounter.Visible = false;
            labelMultiply.Visible = false;
            labelSpeed.Visible = false;
            numericUpDownMultiply.Visible = false;
            numericUpDownSpeed.Visible = false;
            labelCounter.Visible = false;
            checkboxGo.Visible = false;
            checkBoxJump.Visible = false;
            checkBoxPress.Visible = false;
            colorGo.Visible = false;
            colorJump.Visible = false;
            colorPress.Visible = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            number = 1;

            if(number == lastNum)
            {
                if(number == 0)
                {
                    number++;
                }
                else if(number == 7)
                {
                    number--;
                }
                else
                {
                    number++;
                }
            }

            if (number == 0)
            {
                xGo = 681;
                yGo = 281;
            }
            else if(number == 1)
            {
                xGo = 521;
                yGo = 281;
            }
            else if(number == 2)
            {
                xGo = 360;
                yGo = 281;
            }
            else if( number == 3)
            {
                xGo = 280;
                yGo = 327;
            }
            else if(number == 4)
            {
                xGo = 358;
                yGo = 365;
            }
            else if(number == 5)
            {
                xGo = 518;
                yGo = 365;
            }
            else if(number == 6)
            {
                xGo = 681;
                yGo = 365;
            }
            else if(number == 7)
            {
                xGo = 758;
                yGo = 328;
            }
            int[] windowCoords = GetWindow(xGo, yGo);
            xGo = windowCoords[0];
            yGo = windowCoords[1];

            IntPtr int_ = new IntPtr((xGo << 16) | (yGo & 0xFFFF));
            SendMessage(hwnd, 513, 0, int_);
            SendMessage(hwnd, 514, 0, int_);

            lastNum = number;
        }
    }
}