using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TinyTech.UI.Control.MessageBox;

namespace TinyTech.UI.Control.TextBox
{
    public class DateControl : System.Windows.Forms.Control
    {
        public System.Windows.Forms.Control NextControl { get; set; }
        public string ShamsiNow { get; set; }
        public string NowShamsi8Character { get; set; }
        public string Value10Cahracter { get; set; }
        public bool CanGoForward { get; set; }
        public bool CanGoBackward { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var width = 120;
            var height = 20;
            Size = new Size(width, height);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }

        public DateControl()
        {
            BackColor = Color.White;
            CanGoBackward = true;
            CanGoForward = false;
            Wrapper = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight, Margin = Padding.Empty, Dock = DockStyle.Fill
            };
            Year = new NumericTextBox();
            YearMonth = new TinyTech.UI.Control.Label.Label();
            Month = new NumericTextBox();
            MonthDay = new TinyTech.UI.Control.Label.Label();
            Day = new NumericTextBox();
            Enter += DateControl_Enter;
            var text = Today();
            Year.Text = text.Substring(0, 4);
            Month.Text = text.Substring(5, 2);
            Day.Text = text.Substring(8, 2);
            Day.TextChanged += Day_TextChanged;
            Month.TextChanged += Month_TextChanged;
            Day.Leave += Day_Leave;
            Month.Leave += Month_Leave;
            Year.Leave += Year_Leave;
            Year.TabIndex = 2;
            Year.TextAlign = HorizontalAlignment.Center;
            SetTextBoxWidthAndHeight(Year, 4);
            RemoveMargin(Year);
            RemoveBorder(Year);
            Wrapper.Controls.Add(Year);
            RemoveMargin(YearMonth);
            YearMonth.TextAlign = ContentAlignment.MiddleCenter;
            YearMonth.Text = "/";
            YearMonth.BackColor = Color.White;
            YearMonth.AutoSize = true;
            Wrapper.Controls.Add(YearMonth);
            Month.TabIndex = 1;
            Month.TextAlign = HorizontalAlignment.Center;
            SetTextBoxWidthAndHeight(Month, 2);
            RemoveBorder(Month);
            RemoveMargin(Month);
            Wrapper.Controls.Add(Month);
            RemoveMargin(MonthDay);
            MonthDay.TextAlign = ContentAlignment.MiddleCenter;
            MonthDay.Height = Height;
            MonthDay.Text = "/";
            MonthDay.BackColor = Color.White;
            MonthDay.AutoSize = true;
            Wrapper.Controls.Add(MonthDay);
            Day.TabIndex = 0;
            Day.TextAlign = HorizontalAlignment.Center;
            SetTextBoxWidthAndHeight(Day, 2);
            RemoveBorder(Day);
            RemoveMargin(Day);
            Day.Height = Height;
            Wrapper.Controls.Add(Day);
            Controls.Add(Wrapper);
            FontChanged += DateControl_FontChanged;
            Day.KeyDown += Day_KeyDown;
            Month.KeyDown += Month_KeyDown;
            Year.KeyDown += Year_KeyDown;
            YearMonth.BackColor = Year.LeaveBaCkColor;
            MonthDay.BackColor = Year.LeaveBaCkColor;
            YearMonth.ForeColor = Year.LeaveForColor;
            MonthDay.ForeColor = Year.LeaveForColor;
        }

        private void Year_Leave(object sender, EventArgs e)
        {
            if (ValdateYear()) return;
            CustomMessageForm.CustomMessageBox.Show("خطا", $"سال وارد شده نامعتبر است", "e");
            Year.Focus();
        }

        private void Year_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (NextControl != null && NextControl.Visible && NextControl.Enabled)
                    {
                        NextControl.Focus();
                    }
                    else if (NextControl != null && (!NextControl.Visible | !NextControl.Enabled))
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                else
                {
                    CheckKeyUpDown(e, Year, 2200);
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"{ex.Message}", "e");
            }
        }

        public string ShamsiValue()
        {
            return string.Concat(Year.Text, "/", Month.Text, "/", Day.Text);
        }

        private void Month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Year.Focus();
                return;
            }
            CheckKeyUpDown(e, Month, 12);
        }

        private void Day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && Day.Focused)
            {
                Month.Focus();
                Month.Focus();
                Month.Select(0, 3);
                return;
            }
            CheckKeyUpDown(e, Day, 31);
        }

        private void CheckKeyUpDown(KeyEventArgs e, NumericTextBox textBox, int bound)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    isUpDowningKey = true;
                    textBox.Text = string.Concat(textBox.Value % (double)bound + 1.0);
                    textBox.SelectionStart = textBox.Text.Length;
                    isUpDowningKey = false;
                    return;
                case Keys.Down:
                    isUpDowningKey = true;
                    textBox.Text = textBox.Value <= 1.0 ? bound.ToString() : string.Concat((textBox.Value - 1.0) % (double)bound);
                    textBox.SelectionStart = textBox.Text.Length;
                    isUpDowningKey = false;
                    break;
            }
        }

        public DateTime GetDate()
        {
            DateTime result;
            try
            {
                result = new DateTime((int)Year.Value, (int)Month.Value, (int)Day.Value, new PersianCalendar());
            }
            catch
            {
                result = DateTime.MinValue;
            }
            return result;
        }

        public string GetDateStringFormat()
        {
            return $"{Year.Text}/{Month.Text}/{Day.Text}";
        }

        public void SetDate(DateTime value)
        {
            var persianCalendar = new PersianCalendar();
            var year = persianCalendar.GetYear(value);
            var month = persianCalendar.GetMonth(value);
            var dayOfMonth = persianCalendar.GetDayOfMonth(value);
            Year.Text = year.ToString("00");
            Month.Text = month.ToString("00");
            Day.Text = dayOfMonth.ToString("00");
        }

        private void Month_Leave(object sender, EventArgs e)
        {
            switch (Month.Text.Length)
            {
                case 1:
                    Month.Text = "0" + Month.Text;
                    break;
                case 0:
                    Month.Text = Today().Substring(5, 2);
                    break;
            }

            if (ValidateMonth()) return;
            CustomMessageForm.CustomMessageBox.Show("خطا", $"ماه وارد شده نامعتبر است", "e");
            Month.Focus();
        }

        private void Day_Leave(object sender, EventArgs e)
        {
            switch (Day.Text.Length)
            {
                case 1:
                    Day.Text = "0" + Day.Text;
                    break;
                case 0:
                    Day.Text = Today().Substring(8, 2);
                    break;
            }

            if (ValidateDay()) return;
            CustomMessageForm.CustomMessageBox.Show("خطا", $"روز وارد شده نامعتبر است", "e");
            Day.Focus();
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
            if (Day.Text.Length == 2 && !isUpDowningKey)
            {
                Month.Focus();
                Month.Focus();
            }
        }

        private void Month_TextChanged(object sender, EventArgs e)
        {
            if (Month.Text.Length == 2 && !isUpDowningKey)
            {
                Year.Focus();
            }
        }

        private void DateControl_Enter(object sender, EventArgs e)
        {
            Day.Focus();
        }

        public bool ValidateDay()
        {
            return int.Parse(Day.Text) <= 31 && int.Parse(Day.Text) > 0;
        }

        public bool ValidateMonth()
        {
            return int.Parse(Month.Text) <= 12 && int.Parse(Month.Text) > 0 && (int.Parse(Day.Text) != 31 || int.Parse(Month.Text) <= 6);
        }

        public bool ValdateYear()
        {
            return int.Parse(Year.Text) >= 1370;
        }

        private void DateControl_FontChanged(object sender, EventArgs e)
        {
            SetTextBoxWidthAndHeight(Year, 4);
            SetTextBoxWidthAndHeight(Month, 2);
            SetTextBoxWidthAndHeight(Day, 2);
        }

        public void RemoveMargin(System.Windows.Forms.Control con)
        {
            con.Margin = Padding.Empty;
        }

        public string Today()
        {
            var persianCalendar = new PersianCalendar();
            var month = persianCalendar.GetMonth(DateTime.Now);
            var dayOfMonth = persianCalendar.GetDayOfMonth(DateTime.Now);
            var text = persianCalendar.GetYear(DateTime.Now) + "/";
            if (month < 10)
            {
                text = text + "0" + month + "/";
            }
            else
            {
                text = text + month + "/";
            }
            if (dayOfMonth < 10)
            {
                text = text + "0" + dayOfMonth;
            }
            else
            {
                text += dayOfMonth.ToString();
            }
            ShamsiNow = text;
            return text;
        }

        public static void RefreshDateControl(ref DateControl DateControl)
        {
            var persianCalendar = new PersianCalendar();
            var month = persianCalendar.GetMonth(DateTime.Now);
            var dayOfMonth = persianCalendar.GetDayOfMonth(DateTime.Now);
            var year = persianCalendar.GetYear(DateTime.Now);
            if (month < 10)
            {
                DateControl.Month.Text = "0" + month;
            }
            else
            {
                DateControl.Month.Text = month.ToString();
            }
            if (dayOfMonth < 10)
            {
                DateControl.Day.Text = "0" + dayOfMonth;
            }
            else
            {
                DateControl.Day.Text = dayOfMonth.ToString();
            }
            DateControl.Year.Text = year.ToString();
        }

        public void SetTextBoxWidthAndHeight(System.Windows.Forms.TextBox textBox, int maxLength)
        {
            textBox.MaxLength = maxLength;
            using (textBox.CreateGraphics())
            {
                textBox.Width = 28;
            }
        }

        public void RemoveBorder(System.Windows.Forms.TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
        }

        public FlowLayoutPanel Wrapper;
        public NumericTextBox Year;
        public NumericTextBox Year2CH;
        public NumericTextBox Month;
        public NumericTextBox Day;
        public System.Windows.Forms.Label YearMonth;
        public System.Windows.Forms.Label MonthDay;
        public bool SendTabKey;
        private bool isUpDowningKey;
        public System.Windows.Forms.Control Next;
    }
}
