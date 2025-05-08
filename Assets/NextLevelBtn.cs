using UnityEngine;
using UnityEngine.UI; // For UI components

public class NextLevelBtn : MonoBehaviour
{
	public void OnNextLevelClick()
	{
		if(GameDataManager.Instance.playerData.intDiamond>=3000)
		{
			GameDataManager.Instance.playerData.SubDiamond(3000);
			ui.Instance.nextlevel();
		}
		else
		{
			// Show message when not enough diamonds
			Debug.Log("KK không đủ tiền");

		}
	}
}
