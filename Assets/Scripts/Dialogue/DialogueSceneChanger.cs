using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class DialogueSceneChanger : MonoBehaviour
{
    [SerializeField] private DialogueRunner dialogueRunner;

    private void Awake()
    {
        dialogueRunner.AddCommandHandler<string>("ChangeScene", ChangeScene);
    }

    [YarnCommand("ChangeScene")]
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
