using SystemAction = System.Action;
using System.Collections;
using System.Collections.Generic;

namespace Undefined.FriendsPopup {
	public class Store {
		
		private State m_state;
		public State State {
			get {
				return m_state;
			}
		}
		
		private Reducer m_reducer;
		private List<SystemAction> m_listeners = new List<SystemAction> ();

		public Store(Reducer reducer) {
			m_reducer = reducer;
		}

		public void Dispatch(Action action) {
			m_state = m_reducer.Do(m_state, action);
			m_listeners.ForEach(listener => listener());
		}

		public SystemAction Subscribe(SystemAction listener) {
			m_listeners.Add(listener);
			return listener;
		}
	}
}