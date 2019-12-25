using Android.App;
using Android.Runtime;

namespace EasyAR
{
    public partial class Engine
    {
        /// <summary>
        /// On Android, EasyAR requires a reference to the activity in order to initialize the engine.  This method call is not available in the
        /// provided C# api so we will call it via the jar and java interop.
        /// </summary>
        /// <param name="activity">The activity that will be using EasyAR.</param>
        /// <param name="key">The license key provided by EasyAR.</param>
        /// <returns>true if the engine was initialized with the provided key.</returns>
        public static bool initialize(Activity activity, string key)
        {
            System.IntPtr easyArClass = JNIEnv.FindClass("cn/easyar/Engine");
            System.IntPtr initializeMethod = JNIEnv.GetStaticMethodID(easyArClass, "initialize", "(Landroid/app/Activity;Ljava/lang/String;)Z");
            return JNIEnv.CallStaticBooleanMethod(easyArClass, initializeMethod, new JValue[] { new JValue(activity), new JValue(new Java.Lang.String(key)) });
        }
    }
}