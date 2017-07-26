using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UniRx;

public enum HttpMethod {
	GET,
	POST,
	PUT,
	HEAD
}


public class Service {
	protected readonly string m_baseUrl;

	public Service(string baseUrl) {
		m_baseUrl = baseUrl;
	}

	public UniRx.IObservable<T> Request<T>(string path, HttpMethod httpMethod) {
		return Observable.FromMicroCoroutine<T>((observer, cancellationToken) => Requester<T>(path, httpMethod, observer, cancellationToken));
	}

	public UniRx.IObservable<T[]> RequestArray<T>(string path, HttpMethod httpMethod) {
		return Observable.FromMicroCoroutine<T[]>((observer, cancellationToken) => RequesterArray<T>(path, httpMethod, observer, cancellationToken));
	}

	private IEnumerator Requester<T>(string path, HttpMethod httpMethod, UniRx.IObserver<T> observer, CancellationToken cancellationToken) {
		string url = $"{m_baseUrl}{path}";
		
		switch (httpMethod)
		{
				case HttpMethod.GET:
					using (UnityWebRequest www = UnityWebRequest.Get(url)) {
						www.Send();
						while (!www.isDone && !cancellationToken.IsCancellationRequested) {
							yield return null;
						}

						if (cancellationToken.IsCancellationRequested) {
							yield break;
						}

						if (www.isNetworkError) {
							observer.OnError(new Exception(www.error));
						} else {
							observer.OnNext(JsonUtility.FromJson<T>(www.downloadHandler.text));
							observer.OnCompleted();
						}
					}
					break;
				
				default:
					break;
		}
	}

	private IEnumerator RequesterArray<T>(string path, HttpMethod httpMethod, UniRx.IObserver<T[]> observer, CancellationToken cancellationToken) {
		string url = $"{m_baseUrl}{path}";
		
		switch (httpMethod)
		{
				case HttpMethod.GET:
					using (UnityWebRequest www = UnityWebRequest.Get(url)) {
						www.Send();
						while (!www.isDone && !cancellationToken.IsCancellationRequested) {
							yield return null;
						}

						if (cancellationToken.IsCancellationRequested) {
							yield break;
						}

						if (www.isNetworkError) {
							observer.OnError(new Exception(www.error));
						} else {
							observer.OnNext(JsonHelper.FromJsonArray<T>(www.downloadHandler.text));
							observer.OnCompleted();
						}
					}
					break;
				
				default:
					break;
		}
	}
}
