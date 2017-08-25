using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugController : MonoBehaviour {
	void Start () {
		// #if DEVELOPMENT_BUILD
		// 	Debug.unityLogger.logEnabled = true;
		// #else
		// 	Debug.unityLogger.logEnabled = false;
		// #endif	
	}
}
