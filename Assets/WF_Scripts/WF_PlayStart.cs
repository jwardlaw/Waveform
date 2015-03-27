using UnityEngine;
using System.Collections;

public class WF_PlayStart : MonoBehaviour {

	public void StartLevel()
    {
        Application.LoadLevel(WF_ChangeScene.SceneToLoad);
    }
}
