using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloder : MonoBehaviour
{
	public Image      _loading;
	public GameObject _home;

	// Start is called before the first frame update
	void Awake()
	{
		gameObject.gameObject.SetActive(true);
		_loading.DOFillAmount(1,1.4f).From(0).OnComplete(() =>
		{
			gameObject.gameObject.SetActive(false);
			_home.SetActive(true);
		});
	}

	public void LoadScene()
	{
		gameObject.gameObject.SetActive(true);
		_loading.DOFillAmount(1,1.4f).From(0).OnComplete(() => { SceneManager.LoadScene(PlayerPrefs.GetInt("level",1)); });
	}

	// Update is called once per frame
	void Update() { }
}
