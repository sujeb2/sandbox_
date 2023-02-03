using UnityEngine;
using UnityEngine.SceneManagement;

namespace IngameDebugConsole.Commands
{
	public class SceneCommands
	{
		[ConsoleMethod( "scene.load", "특정 씬을 로드합니다." ), UnityEngine.Scripting.Preserve]
		public static void LoadScene( string sceneName )
		{
			LoadSceneInternal( sceneName, false, LoadSceneMode.Single );
		}

		[ConsoleMethod( "scene.load", "씬을 로드합니다" ), UnityEngine.Scripting.Preserve]
		public static void LoadScene( string sceneName, LoadSceneMode mode )
		{
			LoadSceneInternal( sceneName, false, mode );
		}

		[ConsoleMethod( "scene.loadasync", "씬을 비동기적으로 로드합니다." ), UnityEngine.Scripting.Preserve]
		public static void LoadSceneAsync( string sceneName )
		{
			LoadSceneInternal( sceneName, true, LoadSceneMode.Single );
		}

		[ConsoleMethod( "scene.loadasync", "씬을 비동기적으로 로드합니다." ), UnityEngine.Scripting.Preserve]
		public static void LoadSceneAsync( string sceneName, LoadSceneMode mode )
		{
			LoadSceneInternal( sceneName, true, mode );
		}

		private static void LoadSceneInternal( string sceneName, bool isAsync, LoadSceneMode mode )
		{
			if( SceneManager.GetSceneByName( sceneName ).IsValid() )
			{
				Debug.Log( "씬 " + sceneName + " 은 이미 로드되어 있습니다." );
				return;
			}

			if( isAsync )
				SceneManager.LoadSceneAsync( sceneName, mode );
			else
				SceneManager.LoadScene( sceneName, mode );
		}

		[ConsoleMethod( "scene.unload", "특정 씬을 언로드 합니다." ), UnityEngine.Scripting.Preserve]
		public static void UnloadScene( string sceneName )
		{
			SceneManager.UnloadSceneAsync( sceneName );
		}

		[ConsoleMethod( "scene.restart", "현재 씬을 재시작합니다." ), UnityEngine.Scripting.Preserve]
		public static void RestartScene()
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().name, LoadSceneMode.Single );
		}
	}
}