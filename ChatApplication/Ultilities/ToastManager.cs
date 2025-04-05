using System;
using System.Windows.Forms;

namespace ChatApplication.Ultilities
{
    public static class ToastManager
    {
        public static void ShowToastNotification(string title, string message, string type, Form parentForm)
        {
            if (parentForm.InvokeRequired)
            {
                parentForm.Invoke(new Action(() => ShowToastNotification(title, message, type, parentForm)));
                return;
            }

            toastForm toast = new toastForm(title, message, type, parentForm);
            toast.Show();
        }
    }
}
