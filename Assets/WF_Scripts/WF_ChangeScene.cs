using UnityEngine;
using System.Collections;

public class WF_ChangeScene : MonoBehaviour {

    public static int SceneToLoad = 0;

	public void ChangeSceneTo (int newScene)
    {
        SceneToLoad = newScene;
    }
}
