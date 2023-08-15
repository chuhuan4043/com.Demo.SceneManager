using UnityEngine;
using UnityEngine.SceneManagement;

namespace Demo.SceneManager
{
    /// <summary>
    /// 場景管理器：切換場景與退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField, Range(0.3f, 3f), Header("音效時間")]
        private float soundDuration = 2.2f;
        /// <summary>
        /// 透過字串切換場景
        /// </summary>
        /// <param name="sceneName">場景名稱</param>

        public string sceneName;
        
        public void SceneChange(string sceneName)
        {

            this.sceneName = sceneName;
            Invoke("SceneChangeDelay", soundDuration);
        }
        public void SceneChangeDelay()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }
        public void DelayQuit()
        {
            Application.Quit();
        }
    }
}
