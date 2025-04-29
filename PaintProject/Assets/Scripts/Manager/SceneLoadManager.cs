using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PaintProject
{
    public class SceneLoadManager : ManagerBase
    {
        public override UniTask Initialize()
        {
            if (_isInitialize)
                return UniTask.CompletedTask;

            _isInitialize = true;
            return UniTask.CompletedTask;
        }

        public override void Clear()
        {
            _isInitialize = false;
        }

        public async UniTask LoadSceneByName(string sceneName)
        {
            // 씬이 빌드에 포함되어 있는지 확인
            if (Application.CanStreamedLevelBeLoaded(sceneName))
            {
                // 씬을 비동기로 로드
                AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

                // 씬 로드가 완료될 때까지 대기
                while (!asyncLoad.isDone)
                {
                    await UniTask.Yield();
                }
            }
            else
            {
                Debug.LogError("씬 이름이 올바르지 않거나 빌드에 포함되지 않았습니다: " + sceneName);
            }
        }
    }
}
