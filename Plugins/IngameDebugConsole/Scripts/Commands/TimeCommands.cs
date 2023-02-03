using UnityEngine;

namespace IngameDebugConsole.Commands
{
	public class TimeCommands
	{
		[ConsoleMethod( "time.scale", "Time.timeScale 값을 변경합니다." ), UnityEngine.Scripting.Preserve]
		public static void SetTimeScale( float value )
		{
			Time.timeScale = Mathf.Max( value, 0f );
		}

		[ConsoleMethod( "time.scale", "Time.timeScale 값을 변경합니다." ), UnityEngine.Scripting.Preserve]
		public static float GetTimeScale()
		{
			return Time.timeScale;
		}
	}
}