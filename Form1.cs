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

    public static Point newPoint;

    public static Point cursor;

    private IntPtr hwnd;

    private POINT_API mouse;

    private RECT infoWindow;

    private IntPtr hwndJump;

    private POINT_API mouseJump;

    private RECT infoWindowJump;

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
            }
        }
        private void GetWindowJump()
        {
            checked
            {
                if (Convert.ToDouble(Convert.ToString((int)GetForegroundWindow())) != 0.0)
                {
                    GetCursorPos(out mouseJump);
                    hwndJump = WindowFromPoint(mouseJump);
                    GetWindowRect(hwnd, out infoWindowJump);
                    xJump = mouseJump.X - infoWindowJump.Left;
                    yJump = mouseJump.Y - infoWindowJump.Top;
                }
                if (xJump < 0)
                {
                    xJump = 0;
                }
                if (yJump < 0)
                {
                    yJump = 0;
                }
            }
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
                    if (checkBoxJump.Checked)
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
                }
                if (GetAsyncKeyState(Keys.F2))
                {
                    timer1.Stop();
                    labelCounter.Text = "0";
                    if (checkBoxJump.Checked)
                        timer3.Stop();
                }
                if (GetAsyncKeyState(Keys.F3))
                {
                    cursor = default(Point);
                    GetCursorPos(out cursor);
                    xPos = cursor.X;
                    yPos = cursor.Y;
                    GetWindow();
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
                if (GetAsyncKeyState(Keys.F10) && checkBoxJump.Checked && this.BackColor == Color.LimeGreen )
                {
                    cursor = default(Point);
                    GetCursorPos(out cursor);
                    xJump = cursor.X;
                    yJump = cursor.Y;
                    GetWindowJump();
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            IntPtr int_ = new IntPtr((yJump << 16) | (xJump & 0xFFFF));
            SendMessage(hwndJump, 513, 0, int_);
            SendMessage(hwndJump, 514, 0, int_);
        }

        private void checkBoxPress_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPress.Checked)
            {
                this.colorPress.BackColor = Color.Aqua;
            }
            else
            {
                this.colorPress.BackColor = Color.White;
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
    }
}