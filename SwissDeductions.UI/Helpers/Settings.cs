// Helpers/Settings.cs This file was automatically added when you installed the Settings Plugin. If you are not using a PCL then comment this file back in to use it.
using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using SwissDeductions.core;

namespace SwissDeductions.UI.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public class Settings : ILocalSettings
	{
        static ISettings AppSettings => CrossSettings.Current;

        #region Setting Constants

        const string ReturnKey = "Return_Key";
		
        #endregion


		public Return CurrentReturn
		{
            get => JsonConvert.DeserializeObject<Return>(AppSettings.GetValueOrDefault(ReturnKey, ""));
            set => AppSettings.AddOrUpdateValue(ReturnKey, JsonConvert.SerializeObject(value));
		}
	}
}