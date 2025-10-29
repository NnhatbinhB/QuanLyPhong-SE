using System;
using System.Windows.Forms;

namespace QuanLyPhong_WinForms_Skeleton.Services
{
    public class SchedulerService : IDisposable
    {
        private System.Windows.Forms.Timer timer;
        private Action? tickAction;

        public void Start(TimeSpan interval, Action tick)
        {
            tickAction = tick;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)interval.TotalMilliseconds;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tickAction?.Invoke();
        }

        public void Dispose()
        {
            timer?.Stop();
            timer?.Dispose();
        }
    }
}

