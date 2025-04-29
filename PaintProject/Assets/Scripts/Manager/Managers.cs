using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using PaintProject;

namespace PaintProject
{
    /// <summary>
    /// Manager 성격의 클래스들이 상속받아야함
    /// </summary>
    public abstract class ManagerBase
    {
        protected bool _isInitialize;

        public abstract UniTask Initialize();
        public abstract void Clear();
    }

    /// <summary>
    /// 모든 Manager 관리
    /// </summary>
    public class Managers : Singleton<Managers>
    {
        public ResourceManager resourceMgr { get; private set; }
        public UIManager uiMgr { get; private set; }
        public SceneLoadManager sceneLoadManager { get; private set; }
        public TableManager tableManager{get; private set;}

        private List<ManagerBase> _managers;
        private bool _isInitialize = false;
        
        public async UniTask Initialize()
        {
            if (_isInitialize)
                return;

            _managers = new List<ManagerBase>();
            
            CreateManager();
            await InitializeManager();
            
            _isInitialize = true;
        }

        /// <summary>
        /// 매니저 클래스 생성
        /// </summary>
        private void CreateManager()
        {
            resourceMgr = new ResourceManager();
            _managers.Add(resourceMgr);
            
            uiMgr = new UIManager();
            _managers.Add(uiMgr);

            sceneLoadManager = new SceneLoadManager();
            _managers.Add(sceneLoadManager);

            tableManager = new TableManager();
            _managers.Add(tableManager);
        }

        /// <summary>
        /// 전체 매니저 이니셜라이즈
        /// </summary>
        private async UniTask InitializeManager()
        {
            foreach (var value in _managers)
            {
                Debug.Log($"{value} Initialize Start --");
                await value.Initialize();
                Debug.Log($"{value} Initialize End --");
            }
        }

        /// <summary>
        /// 전체 매니저 초기화
        /// </summary>
        public void Clear()
        {
            foreach (var value in _managers)
            {
                value.Clear();
            }
        }
    }
}