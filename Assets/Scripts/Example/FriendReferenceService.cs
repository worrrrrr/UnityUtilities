using UniRx;

public struct User {
	public int id;
	public string reference_code;
	public string status;
}

public struct UserDoingQuest {
	public int user_id;
	public int quest_id;
	public int progress;
	public bool is_success;
}

public struct Quest {
	public int id;
	public string name;
	public int finished_progress;
}

public class FriendReferenceService : Service {
	public FriendReferenceService(string baseUrl) : base(baseUrl) {}

	public IObservable<User> GetUserWithId(int id) 
			=> Request<User>($"/user/{id}", HttpMethod.GET);

	public IObservable<Quest> GetQuestWithId(int id)
			=> Request<Quest>($"/quest/{id}", HttpMethod.GET);

	public IObservable<UserDoingQuest[]> GetQuestThatUserDoing(int id) 
			=> RequestArray<UserDoingQuest>($"/user/{id}/quests", HttpMethod.GET);
}
