using System;
using System.Collections;
using System.Collections.Generic;

namespace Undefined.FriendsPopup {
	public class Reducer {

		private Func<State, Action, State> handler;

		public Reducer(Func<State, Action, State> handler) {
			this.handler = handler;
		}

		public State Do(State state, Action action) {
			return handler(state, action);
		}

	}
}
