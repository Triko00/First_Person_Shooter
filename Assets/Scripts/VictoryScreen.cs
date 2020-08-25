using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryScreen : MonoBehaviour
{
    public string mainMenuScene;

    public float timeBetweenShowing;

    public GameObject textBox, returnButton;

    public Image blackScreen;
    public float blackScreenFade;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowObjectsCo());
    }

    // Update is called once per frame
    void Update()
    {
        blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, blackScreenFade * Time.deltaTime));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public IEnumerator ShowObjectsCo()
    {
        yield return new WaitForSeconds(timeBetweenShowing);

        textBox.SetActive(true);

        yield return new WaitForSeconds(timeBetweenShowing);

        returnButton.SetActive(true);
    }
}
