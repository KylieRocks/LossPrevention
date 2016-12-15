using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button continueText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		continueText = continueText.GetComponent<Button> ();

		quitMenu.enabled = false;
	}
	
	public void ExitPress() {
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		continueText.enabled = false;
	}

	public void NoExitPress() {
		quitMenu.enabled = false;
		startText.enabled = true;
		continueText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel() {
		Application.LoadLevel (1);
	}

	public void ExitGame() {
		Application.Quit ();
	}
}
