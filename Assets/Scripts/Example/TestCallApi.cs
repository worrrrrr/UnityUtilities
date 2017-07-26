using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TestCallApi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FriendReferenceService friendReferenceService = new FriendReferenceService(baseUrl: "https://friend.digitopolisstudio.com");
		friendReferenceService.GetUserWithId(id: 1).Subscribe( user => {
			Debug.Log(user.id);
			Debug.Log(user.reference_code);
			Debug.Log(user.status);
		});
	}
}
