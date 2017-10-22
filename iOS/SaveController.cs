using System;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(uDrop.SaveController))]
namespace uDrop
{
    public class SaveController : uDrop.SaveControllerInterface
	{
		public static SaveController _instance;

        public SaveController() { }
        //private SaveController() { }

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
			var prefs = NSUserDefaults.StandardUserDefaults;
			prefs.SetString(name, "Name");
			prefs.Synchronize();
		}

		public string GetSavedName()
		{
			var prefs = NSUserDefaults.StandardUserDefaults;
			var uName = prefs.StringForKey("Name");
			return uName;
		}

		//public void ResetSavedUserName()
		//{
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	prefs.SetString("", "Name");
		//	prefs.Synchronize();
		//}

		//public void SetSavedToken()
		//{
		//	string token = UserHandler.GetUserHandler().User_token;
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	prefs.SetString(token, "token");
		//	prefs.Synchronize();
		//}

		//public string GetSavedToken()
		//{
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	var token = prefs.StringForKey("token");
		//	return token;
		//}

		//public void ResetSavedToken()
		//{
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	prefs.SetString("", "token");
		//	prefs.Synchronize();
		//}

		//public void SetSavedLastToken()
		//{
		//	string token = UserHandler.GetUserHandler().User_token;
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	prefs.SetString(token, "lasttoken");
		//	prefs.Synchronize();
		//}

		//public string GetSavedLastToken()
		//{
		//	var prefs = NSUserDefaults.StandardUserDefaults;
		//	var token = prefs.StringForKey("lasttoken");
		//	return token;
		//}
	}
}
