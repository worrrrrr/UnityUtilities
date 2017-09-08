using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Undefined.FriendsPopup {
	public enum FriendsReferenceStatus {
		Active,
		Inactive,
		New
	}

	public enum Mode {
		Normal,
		Edit
	}

	public struct State {
		public Basic Basic;
		public FriendsList FriendsList;
		public FriendsReference FriendsReference;

		public State (State friendsPopupState) {
			Basic = friendsPopupState.Basic;
			FriendsList = friendsPopupState.FriendsList;
			FriendsReference = friendsPopupState.FriendsReference;
		}

		public State(Basic basic, FriendsList friendList, FriendsReference friendsReference) {
			Basic = basic;
			FriendsList = friendList;
			FriendsReference = friendsReference;
		}
	}

	public struct Basic {
		public string Header;

		public Basic(string header) {
			Header = header;
		}
	}

	public struct FriendsList {
		public Mode Mode;
		public List<Friend> Friends;
		public bool IsShowFriendsList;

		public FriendsList(Mode mode, List<Friend> friends, bool isShowFriendsList) {
			Mode = mode;
			Friends = friends;
			IsShowFriendsList = isShowFriendsList;
		}
	}

	public struct FriendsReference {
		public FriendsReferenceStatus Status;
	}


	#region Dummy
	public struct Friend {

	}

	public class User {

		public static User m_instance;

		public FriendsReferenceStatus friendsReferenceStatus = FriendsReferenceStatus.Active;
		public List<Friend> friends = new List<Friend> ();
		public int m_friendLimits = 200; 

		public static User GetSingleton() {
			if (m_instance == null) {
				m_instance = new User();
			}

			return m_instance;
		}

		
	}
	#endregion
}