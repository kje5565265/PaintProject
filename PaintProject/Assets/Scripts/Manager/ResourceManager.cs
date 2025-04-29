using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace PaintProject
{
    public class ResourceManager : ManagerBase
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

        /// <summary>
        /// 게임오브젝트 생성
        /// </summary>
        /// <param name="str"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public async UniTask<GameObject> CreateGameObject(string str, Transform parent = null)
        {
            var (_, newObj) = await TryCreateGameObject(str, parent);
            return newObj;
        }

        /// <summary>
        /// 게임오브젝트 생성 시도
        /// </summary>
        /// <param name="str"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public async UniTask<(bool, GameObject)> TryCreateGameObject(string str, Transform parent = null)
        {
            var handle = Addressables.LoadAssetAsync<GameObject>($"Assets/AddressableResources/Prefabs/UI/{str}.prefab");
            var task = handle.Task;
            var newResource = await task;
            if (false == task.IsCompletedSuccessfully)
            {
                return (false, null);
            }
            
            var newObj = GameObject.Instantiate(newResource, parent);
            newObj.transform.localPosition = Vector3.zero;
            newObj.transform.localScale = Vector3.one;
            newObj.name = str;
            return (true, newObj);
        }

        /// <summary>
        /// UIWindow 생성
        /// </summary>
        /// <param name="str"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public async UniTask<UIWindowBase> CreateUI(string str, Transform root)
        {
            var (_, newObj) = await TryCreateUI(str, root);
            return newObj;
        }

        /// <summary>
        /// UIWindow 생성 시도
        /// </summary>
        /// <param name="str"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public async UniTask<(bool, UIWindowBase)> TryCreateUI(string str, Transform root)
        {
            var (success, newObj) = await TryCreateGameObject(str, root);
            if (false == success)
            {
                return (false, null);
            }

            success = newObj.TryGetComponent<UIWindowBase>(out var result);
            return (success, result);
        }
    }
}
