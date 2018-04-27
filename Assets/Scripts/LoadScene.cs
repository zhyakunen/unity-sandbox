using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

    public GameObject loadingScreen;

    public void loadScene(int level) {
        loadingScreen.active = true;
        Application.LoadLevel(level);
    }

    public void QuitGame() {
        Application.Quit();
        return;
    }
}
