using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UniRx;

public class FriendReferenceServicePlayModeTest {

	[UnityTest]
	public IEnumerator GetUserWithIdEditModeTestPasses() {
		FriendReferenceService friendReferenceService = new FriendReferenceService("https://friend.digitopolisstudio.com");

		User? userForChecked = null;

		friendReferenceService.GetUserWithId(id: 19).Subscribe(user => {
			userForChecked = user;
		});

		float waitedTime = 1f;

		while (waitedTime >= 0) {
			waitedTime = waitedTime - Time.deltaTime;
			yield return null;
		}

		Assert.That(userForChecked != null, Is.True.After(2000));

	}

	[UnityTest]
	public IEnumerator GetQuestsEditModeTestPasses() {
		FriendReferenceService friendReferenceService = new FriendReferenceService("https://friend.digitopolisstudio.com");

		Quest[] questsForChecked = null;

		friendReferenceService.GetQuests().Subscribe(quests => {
			questsForChecked = quests;
		});

		float waitedTime = 1f;

		while (waitedTime >= 0) {
			waitedTime = waitedTime - Time.deltaTime;
			yield return null;
		}

		Assert.IsNotNull(questsForChecked);
	}
}
