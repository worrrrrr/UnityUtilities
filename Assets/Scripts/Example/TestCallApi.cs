using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

[System.Serializable]
public struct PromotionCollection {
	public Promotion[] promotions;
}

[System.Serializable]
public struct Promotion {
	public string keyCode;
	public string tag;
	public string bonusValue;
}

public class TestCallApi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FriendReferenceService friendReferenceService = new FriendReferenceService(baseUrl: "https://cloud.digitopolisstudio.com");
		friendReferenceService.GetPromotions().Subscribe(
			promotions => {
				foreach (Promotion promotion in promotions) {
					Debug.Log(promotion.keyCode);
					Debug.Log(promotion.tag);
					Debug.Log(promotion.bonusValue);
				}
			},

			error => {
				Debug.LogError(error);
			}
		);
	}
	// 	friendReferenceService.GetQuestThatUserDoing(id: 44).Subscribe(
	// 		userDoingQuests => {
				
	// 		},
	// 		error => {

	// 		}
	// 	);
	// 	friendReferenceService.GetUserWithId(id: 44).Subscribe(
	// 		user => {
	// 			// Debug.Log(user.id);
	// 			// Debug.Log(user.reference_code);
	// 			// Debug.Log(user.status);
	// 		},
	// 		error => Debug.LogException(error));
	// }
}
