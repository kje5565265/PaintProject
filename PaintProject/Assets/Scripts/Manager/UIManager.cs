using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace PaintProject
{
    public class UIManager : ManagerBase
    {
        /// <summary>
        /// MainUI Root
        /// </summary>
        public GameObject UIRootMain { get; private set; }
        
        /// <summary>
        /// Popup Root
        /// </summary>
        public GameObject UIRootPopup { get; private set; }

        private List<UIWindowBase> _windows;
        private List<UIPopupBase> _popups;

        private int _sortOrderWindow;
        private int _sortOrderPopup;
        
        public override async UniTask Initialize()
        {
            if (_isInitialize)
                return;

            _windows = new List<UIWindowBase>();
            
            _sortOrderWindow = 0;
            _sortOrderPopup = 0;

            UIRootMain = await Managers.Instance.resourceMgr.CreateGameObject("UIRoot_Main");
            UIRootPopup = await Managers.Instance.resourceMgr.CreateGameObject("UIRoot_Popup");
            
            _isInitialize = true;
        }

        public override void Clear()
        {
            _isInitialize = false;
        }

        #region Window

        /// <summary>
        /// UIWindow 오픈
        /// </summary>
        /// <param name="str"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async UniTask<T> OpenWindow<T>(string str) where T : Component
        {
            if (false == _isInitialize)
            {
                await UniTask.WaitWhile(() => false == _isInitialize);
            }
            
            T returnWindow = null;
            UIWindowBase parentComponent;
            var find = _windows.FirstOrDefault(d => string.Equals(d.name, str));
            if (null != find)
            {
                parentComponent = find;
                // 이미 열려있는경우 return
                if (find.IsOpen)
                    return find.GetComponent<T>();
                
                OpenWindow(find);
                returnWindow = find.GetComponent<T>();
            }
            else
            {
                var create = await CreateWindow<T>(str);
                if (null == create)
                    return null;
                
                parentComponent = create as UIWindowBase;
                _windows.Add(parentComponent);
                OpenWindow(parentComponent);
                returnWindow = create.GetComponent<T>();
            }

            _sortOrderWindow++;
            var canvas = returnWindow.GetComponent<Canvas>();
            if (null != canvas)
            {
                canvas.overrideSorting = true;
                canvas.sortingOrder = _sortOrderWindow;
                parentComponent.SortOrder = _sortOrderWindow;
            }
            
            return returnWindow;
        }
        
        private void OpenWindow(UIWindowBase openTarget)
        {
            openTarget.OnOpen();
            openTarget.IsOpen = true;
            openTarget.gameObject.SetActive(true);
        }

        private async UniTask<T> CreateWindow<T>(string str) where T : Component
        {
            if (false == _isInitialize)
            {
                await UniTask.WaitWhile(() => false == _isInitialize);
            }

            UIWindowBase newWindow = await Managers.Instance.resourceMgr.CreateUI(str, UIRootMain.transform);
            if (null == newWindow)
                return null;
            
            return newWindow.GetComponent<T>();
        }

        /// <summary>
        /// 현재 가장 위에 열려있는 UI의 order 를 가져옴
        /// </summary>
        /// <returns></returns>
        private UIWindowBase FindLastSortOrderWindow()
        {
            List<UIWindowBase> opensWindow = _windows.Where(d => d.IsOpen).ToList();
            if (null == opensWindow || !opensWindow.Any())
            {
                return null;
            }

            UIWindowBase find = null;
            foreach (var item in opensWindow)
            {
                if (null == find)
                    find = item;

                if (find.SortOrder < item.SortOrder)
                    find = item;
            }
            return find;
        }
        
        /// <summary>
        /// UIWindow close
        /// </summary>
        /// <param name="str"></param>
        public void CloseWindow(string str) 
        {
            var closeTarget = _windows.FirstOrDefault(d => string.Equals(d.name, str));
            if (null == closeTarget)
                return;

            // 이미 닫혀 있는경우 return
            if (false == closeTarget.IsOpen)
                return;
            
            closeTarget.OnClose();
            closeTarget.IsOpen = false;
            closeTarget.gameObject.SetActive(false);
            _sortOrderWindow--;
        }
        
        #endregion
        
        #region Popup

        /// <summary>
        /// UIWindow 오픈
        /// </summary>
        /// <param name="str"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async UniTask<T> OpenPopup<T>(string str) where T : Component
        {
            if (false == _isInitialize)
            {
                await UniTask.WaitWhile(() => false == _isInitialize);
            }

            T returnWindow = null;
            UIPopupBase parentComponent;
            var find = _popups.FirstOrDefault(d => string.Equals(d.name, str));
            if (null != find)
            {
                parentComponent = find;
                // 이미 열려있는경우 return
                if (find.IsOpen)
                    return find.GetComponent<T>();
                
                OpenPopup(find);
                returnWindow = find.GetComponent<T>();
            }
            else
            {
                var create = await CreatePopup<T>(str);
                if (null == create)
                    return null;
                
                parentComponent = create as UIPopupBase;
                _popups.Add(parentComponent);
                OpenPopup(parentComponent);
                returnWindow = create.GetComponent<T>();
            }

            _sortOrderPopup++;
            var canvas = returnWindow.GetComponent<Canvas>();
            if (null != canvas)
            {
                canvas.overrideSorting = true;
                canvas.sortingOrder = _sortOrderPopup;
                parentComponent.SortOrder = _sortOrderPopup;
            }
            
            return returnWindow;
        }
        
        private void OpenPopup(UIPopupBase openTarget)
        {
            openTarget.OnOpen();
            openTarget.IsOpen = true;
            openTarget.gameObject.SetActive(true);
        }

        private async UniTask<T> CreatePopup<T>(string str) where T : Component
        {
            if (false == _isInitialize)
            {
                await UniTask.WaitWhile(() => false == _isInitialize);
            }

            UIWindowBase newWindow = await Managers.Instance.resourceMgr.CreateUI(str, UIRootPopup.transform);
            if (null == newWindow)
                return null;
            
            return newWindow.GetComponent<T>();
        }

        /// <summary>
        /// UIWindow close
        /// </summary>
        /// <param name="str"></param>
        public void ClosePopup(string str) 
        {
            var closeTarget = _windows.FirstOrDefault(d => string.Equals(d.name, str));
            if (null == closeTarget)
                return;

            // 이미 닫혀 있는경우 return
            if (false == closeTarget.IsOpen)
                return;
            
            closeTarget.OnClose();
            closeTarget.IsOpen = false;
            closeTarget.gameObject.SetActive(false);
            _sortOrderPopup--;
        }
        
        #endregion
    }
}
