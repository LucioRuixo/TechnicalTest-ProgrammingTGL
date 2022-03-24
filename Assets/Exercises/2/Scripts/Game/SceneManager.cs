using UnityEngine;

namespace Exercise2.Game
{
    public class SceneManager : MonoBehaviour
    {
        public void LoadScene(string sceneName) => UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

        //TODO SceneManager
    }
}