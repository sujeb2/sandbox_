using UnityEngine;

namespace IngameDebugConsole.Commands
{
	public class PlayerPrefsCommands
	{
		[ConsoleMethod( "prefs.int", "Interger PlayerPrefs 필드의 값을 내보냅니다." ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetInt( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "키 값이 없습니다.";
			return PlayerPrefs.GetInt( key ).ToString();
		}

		[ConsoleMethod( "prefs.int", "Interger PlayerPrefs의 값을 설정합니다." ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetInt( string key, int value )
		{
			PlayerPrefs.SetInt( key, value );
		}

		[ConsoleMethod( "prefs.float", "Float PlayerPrefs 필드의 값을 내보냅니다." ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetFloat( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "키 값이 없습니다.";
			return PlayerPrefs.GetFloat( key ).ToString();
		}

		[ConsoleMethod( "prefs.float", "Float PlayerPrefs의 값을 설정합니다." ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetFloat( string key, float value )
		{
			PlayerPrefs.SetFloat( key, value );
		}

		[ConsoleMethod( "prefs.string", "String PlayerPrefs 필드의 값을 내보냅니다." ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetString( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "키 값이 없습니다.";
			return PlayerPrefs.GetString( key );
		}

		[ConsoleMethod( "prefs.string", "String PlayerPrefs의 값을 설정합니다." ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetString( string key, string value )
		{
			PlayerPrefs.SetString( key, value );
		}

		[ConsoleMethod( "prefs.delete", "PlayerPrefs 필드의 값을 삭제합니다." ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsDelete( string key )
		{
			PlayerPrefs.DeleteKey( key );
		}

		[ConsoleMethod( "prefs.clear", "모든 PlayerPrefs 필드의 값을 삭제합니다." ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsClear()
		{
			PlayerPrefs.DeleteAll();
		}
	}
}