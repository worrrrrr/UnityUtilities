using UnityEditor;

[InitializeOnLoad]
public class AutomaticAddKeystoreEditor {

	public const string KEY_STORE_NAME = "Assets/Keystore/debug.keystore";
	public const string KEY_STORE_PASSWORD = "android";
	public const string KEY_ALIAS_NAME = "androiddebugkey";
	public const string KEY_ALIAS_PASSWORD = "android";

	static AutomaticAddKeystoreEditor() {
		PlayerSettings.Android.keystoreName = KEY_STORE_NAME;
		PlayerSettings.Android.keystorePass = KEY_STORE_PASSWORD;
		PlayerSettings.Android.keyaliasName = KEY_ALIAS_NAME;
		PlayerSettings.Android.keyaliasPass = KEY_ALIAS_PASSWORD;
	}
}
