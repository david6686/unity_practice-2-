using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class New_GameUI : MonoBehaviour
{
	public Text _User;
	//public PlayerManager playerManager;
	public GameObject _Result;
    // Start is called before the first frame update
    void Start()
    {
        //playerManager = FindObjectOfType<PlayerManager>();
		_Result.SetActive(false);
		//_User.text = playerManager.UserID;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAction._isFinal)
		{
			_Result.SetActive(true);
			//_Result.gameObject.transform.GetChild(2).GetComponent<Text>().text = playerManager.UserID;
			//_Result.gameObject.transform.GetChild(4).GetComponent<Text>().text = Follow.Timer.ToString("0.00");
		}
    }
}
