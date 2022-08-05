using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Transform diceRoll;
	public Button DiceRollButton;

    private string currentPlayer = "none";
	private string currentPlayerName = "none";

    public GameObject redPlayerI,redPlayerII,redPlayerIII,redPlayerIV;
	public GameObject greenPlayerI,greenPlayerII,greenPlayerIII,greenPlayerIV;
	public GameObject bluePlayerI,bluePlayerII,bluePlayerIII,bluePlayerIV;
	public GameObject yellowPlayerI,yellowPlayerII,yellowPlayerIII,yellowPlayerIV;

    //selection of dice numbers animation...
	private int selectDiceNumAnimation;

    public GameObject dice1_Roll_Animation;
	public GameObject dice2_Roll_Animation;
	public GameObject dice3_Roll_Animation;
	public GameObject dice4_Roll_Animation;
	public GameObject dice5_Roll_Animation;
	public GameObject dice6_Roll_Animation;

    // Random generation of dice numbers...
	private System.Random randomNo;
	public GameObject confirmScreen;
	public GameObject gameCompletedScreen;

    IEnumerator GameCompletedRoutine()
	{
		yield return new WaitForSeconds (1.5f);
		gameCompletedScreen.SetActive (true);
	}

    void InitializeDice()
	{
		DiceRollButton.interactable = true;

		dice1_Roll_Animation.SetActive (false);
		dice2_Roll_Animation.SetActive (false);
		dice3_Roll_Animation.SetActive (false);
		dice4_Roll_Animation.SetActive (false);
		dice5_Roll_Animation.SetActive (false);
		dice6_Roll_Animation.SetActive (false);	



        //======== Getting currentPlayer VALUE=======
		if (currentPlayerName.Contains ("RED PLAYER")) 
		{
			if (currentPlayerName == "RED PLAYER I") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = RedPlayerI_Script.redPlayerI_ColName;
			}
			if (currentPlayerName == "RED PLAYER II") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = RedPlayerII_Script.redPlayerII_ColName;
			}
			if (currentPlayerName == "RED PLAYER III") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = RedPlayerIII_Script.redPlayerIII_ColName;
			}
			if (currentPlayerName == "RED PLAYER IV") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = RedPlayerIV_Script.redPlayerIV_ColName;
			}
		}

		if (currentPlayerName.Contains ("BLUE PLAYER")) 
		{
			if (currentPlayerName == "BLUE PLAYER I")
				currentPlayer = BluePlayerI_Script.bluePlayerI_ColName;
			if (currentPlayerName == "BLUE PLAYER II")
				currentPlayer = BluePlayerII_Script.bluePlayerII_ColName;
			if (currentPlayerName == "BLUE PLAYER III")
				currentPlayer = BluePlayerIII_Script.bluePlayerIII_ColName;
			if (currentPlayerName == "BLUE PLAYER IV")
				currentPlayer = BluePlayerIV_Script.bluePlayerIV_ColName;
		}

		if (currentPlayerName.Contains ("GREEN PLAYER")) 
		{
			if (currentPlayerName == "GREEN PLAYER I") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = GreenPlayerI_Script.greenPlayerI_ColName;
			}
			if (currentPlayerName == "GREEN PLAYER II") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = GreenPlayerII_Script.greenPlayerII_ColName;
			}
			if (currentPlayerName == "GREEN PLAYER III") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = GreenPlayerIII_Script.greenPlayerIII_ColName;
			}
			if (currentPlayerName == "GREEN PLAYER IV") {
				Debug.Log ("currentPlayerName = " + currentPlayerName);
				currentPlayer = GreenPlayerIV_Script.greenPlayerIV_ColName;
			}
		}

		if (currentPlayerName.Contains ("YELLOW PLAYER")) 
		{
			if (currentPlayerName == "YELLOW PLAYER I")
				currentPlayer = YellowPlayerI_Script.yellowPlayerI_ColName;
			if (currentPlayerName == "YELLOW PLAYER II")
				currentPlayer = YellowPlayerII_Script.yellowPlayerII_ColName;
			if (currentPlayerName == "YELLOW PLAYER III")
				currentPlayer = YellowPlayerIII_Script.yellowPlayerIII_ColName;
			if (currentPlayerName == "YELLOW PLAYER IV")
				currentPlayer = YellowPlayerIV_Script.yellowPlayerIV_ColName;
		}

    }

    // Click on Roll Button on Dice UI
	public void DiceRoll()
	{
		//SoundManagerScript.diceAudioSource.Play ();
		DiceRollButton.interactable = false;

		selectDiceNumAnimation = randomNo.Next (1,7);

		switch (selectDiceNumAnimation) 
		{
			case 1:
				dice1_Roll_Animation.SetActive (true);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 2:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (true);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 3:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (true);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 4:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (true);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 5:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (true);
				dice6_Roll_Animation.SetActive (false);
				break;

			case 6:
				dice1_Roll_Animation.SetActive (false);
				dice2_Roll_Animation.SetActive (false);
				dice3_Roll_Animation.SetActive (false);
				dice4_Roll_Animation.SetActive (false);
				dice5_Roll_Animation.SetActive (false);
				dice6_Roll_Animation.SetActive (true);
				break;
		}

		//StartCoroutine ("PlayersNotInitialized");
	}


    private void Start()
    {
        QualitySettings.vSyncCount = 1;
		Application.targetFrameRate = 30;

		randomNo = new System.Random ();

		dice1_Roll_Animation.SetActive (false);
		dice2_Roll_Animation.SetActive (false);
		dice3_Roll_Animation.SetActive (false);
		dice4_Roll_Animation.SetActive (false);
		dice5_Roll_Animation.SetActive (false);
		dice6_Roll_Animation.SetActive (false);

		// Players initial positions.....
		redPlayerI_Pos = redPlayerI.transform.position;
		redPlayerII_Pos = redPlayerII.transform.position;
		redPlayerIII_Pos = redPlayerIII.transform.position;
		redPlayerIV_Pos = redPlayerIV.transform.position;

		greenPlayerI_Pos = greenPlayerI.transform.position;
		greenPlayerII_Pos = greenPlayerII.transform.position;
		greenPlayerIII_Pos = greenPlayerIII.transform.position;
		greenPlayerIV_Pos = greenPlayerIV.transform.position;

		bluePlayerI_Pos = bluePlayerI.transform.position;
		bluePlayerII_Pos = bluePlayerII.transform.position;
		bluePlayerIII_Pos = bluePlayerIII.transform.position;
		bluePlayerIV_Pos = bluePlayerIV.transform.position;

		yellowPlayerI_Pos = yellowPlayerI.transform.position;
		yellowPlayerII_Pos = yellowPlayerII.transform.position;
		yellowPlayerIII_Pos = yellowPlayerIII.transform.position;
		yellowPlayerIV_Pos = yellowPlayerIV.transform.position;

    }

    void Update()
    {

    }

}