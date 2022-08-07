using Android.OS;
using Firebase.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfirebase.Services
{
    public class FirebaseCustomService
    {
        private FirebaseAnalytics _fire;

        public FirebaseCustomService()
        {
            _fire = FirebaseAnalytics.GetInstance(MauiApplication.Context);
        }

        public void EventLogger()
        {
            Bundle bundle = new Bundle();
            bundle.PutString("keyTest", "valueTest");
            _fire.LogEvent("eventTest", bundle);
        }
    }
}
