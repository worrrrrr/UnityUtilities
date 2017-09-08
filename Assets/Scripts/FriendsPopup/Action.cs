using System.Collections;
using System.Collections.Generic;

namespace Undefined.FriendsPopup {
	public enum ActionType {
		Init,
		OpenFriendsList,
		OpenFriendsReference,
	}
	
	public class Action {
		public ActionType ActionType;
	}

	public class ActionOpenFriendsList : Action {
		public string Header;
	}

	public class ActionOpenFriendsReference : Action {
		public string Header;
		public FriendsReferenceStatus Status;
	}
}
