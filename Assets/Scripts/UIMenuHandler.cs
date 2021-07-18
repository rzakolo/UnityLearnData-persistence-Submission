using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIMenuHandler : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] int playerPoint;
    [SerializeField] TextMeshProUGUI bestScoreText;
    void Start()
    {
        Manager.Instance.Load();
        playerName = Manager.Instance.playerName;
        playerPoint = Manager.Instance.bestScore;
        bestScoreText.text = $"Best Score: {playerName}: {playerPoint}";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AcceptButtonClick(GameObject gameObject)
    {
        if (playerName != null)
        {
            gameObject.SetActive(false);
        }
    }
    public void InputFieldTextChanged(string text)
    {
        Manager.Instance.playerName = text;
        Debug.Log(Manager.Instance.playerName);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
