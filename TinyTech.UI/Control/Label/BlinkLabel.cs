using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Label
{
    public class BlinkLabel : Label
    {
        public BlinkLabel()
        {
            _timer = new Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = 621;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!_timer.Enabled && IsHandleCreated && Visible)
            {
                StartBlink();
            }
        }

        public void StartBlink()
        {
            _blinkCount = 0;
            Visible = true;
            _oldColor = ForeColor;
            ForeColor = Color.Red;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            Visible = !Visible;
            _blinkCount++;
            if (_blinkCount < MaxNumberOfBlinks) return;
            _timer.Stop();
            Visible = true;
            ForeColor = _oldColor;
        }

        private const int MaxNumberOfBlinks = 10000;
        private int _blinkCount;
        private Timer _timer;
        private Color _oldColor;
    }
}
