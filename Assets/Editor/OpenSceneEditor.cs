using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class OpenSceneEditor : MonoBehaviour {
	[MenuItem( "Open Scene/Main" )]
	public static void OpenLoginScene() {
		OpenScene("Main");
	}

	static void OpenScene(string sceneName) {
		if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo() == true) {
			EditorSceneManager.OpenScene("Assets/Scenes/" + sceneName + ".unity");
		}
	}
}
