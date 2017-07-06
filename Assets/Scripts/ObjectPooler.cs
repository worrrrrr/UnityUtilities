using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPoolItem {
	public int initialAmountToPool;
	public GameObject objectToPool;
	public bool shouldExpand;
}

public class ObjectPooler : MonoBehaviour {

	public static ObjectPooler sharedInstance;
	[SerializeField]
	private List<ObjectPoolItem> itemsToPool;

	private List<GameObject> pooledObjects;


	void Awake() {
		sharedInstance = this;
	}

	void Start() {
		pooledObjects = new List<GameObject> ();
		foreach (ObjectPoolItem item in itemsToPool) {
			for (int index = 0; index < item.initialAmountToPool; index++) {
				CreateAndAddToPooledObjects(objectToInstantiate: item.objectToPool);
			}
		}
		
	}

	public GameObject GetPooledObject(string tag) {
		for (int index = 0; index <= pooledObjects.Count; index++) {
			if (!pooledObjects[index].activeInHierarchy && pooledObjects[index].CompareTag(tag)) {
				return pooledObjects[index];
			}
		}

		foreach (ObjectPoolItem item in itemsToPool) {
			if (item.objectToPool.CompareTag(tag)) {
				if (item.shouldExpand) {
					GameObject obj = CreateAndAddToPooledObjects(item.objectToPool);
					return obj;
				} 
			}
		}

		return null;
	}

	private GameObject CreateAndAddToPooledObjects(GameObject objectToInstantiate) {
		GameObject obj = Instantiate(objectToInstantiate);
		obj.SetActive(false);
		pooledObjects.Add(obj);
		return obj;
	}
}
