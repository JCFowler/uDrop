using System;
using Android.Content;
using Android.Preferences;

[assembly: Xamarin.Forms.Dependency(typeof(uDrop.SaveController))]
namespace uDrop
{
    public class SaveController : uDrop.SaveControllerInterface
    {
		public static SaveController _instance;

		public SaveController() { }

		public static SaveController Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new SaveController();
				}
				return _instance;
			}
		}

		public static SaveController GetSaveController()
		{
			return _instance;
		}

		public void SetSavedName(string name)
		{
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Xamarin.Forms.Forms.Context);
			ISharedPreferencesEditor editor = prefs.Edit();
			editor.PutString("Name", name);
			editor.Apply();
		}

		public string GetSavedName()
		{
			ISharedPreferences pref = PreferenceManager.GetDefaultSharedPreferences(Xamarin.Forms.Forms.Context);
			string name = pref.GetString("Name", String.Empty);
            return name;
		}
	}

}
