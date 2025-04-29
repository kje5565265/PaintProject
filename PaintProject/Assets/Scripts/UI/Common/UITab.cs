using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace PaintProject
{
    [RequireComponent(typeof(UIButton))]
    public class UITab : UIBase
    {
        [SerializeField] private bool _isSelected;
        
        [SerializeField] public List<GameObject> Obj_Select_Enable;
        [SerializeField] public List<GameObject> Obj_Select_Disable;
        
        [ReadOnly]
        [SerializeField] public UITabGroup TabGroup;
        
        private UIButton _button;
        private List<Action> _actions = new List<Action>();

        /// <summary>
        /// TabGroup 에서 호출
        /// - 따로 호출하지 마세요.
        /// </summary>
        private bool _isInitialize = false;
        
        public void Initialize()
        {
            if (_isInitialize)
                return;
            
            _button = GetComponent<UIButton>();
            if (null == _button)
                return;
            
            _button.AddButtonClick(ClickTab);
            
            Obj_Select_Enable.RemoveAll(d => d == null);
            Obj_Select_Disable.RemoveAll(d => d == null);
            
            TabGroup.OnChangeTabState.Add(this, (isEnable) => 
            {
                _isSelected = isEnable;
                foreach (var obj in Obj_Select_Enable)
                {
                    obj.SetActive(isEnable);
                }
                foreach (var obj in Obj_Select_Disable)
                {
                    obj.SetActive(!isEnable);
                }
            });

            _isInitialize = true;
        }

        /// <summary>
        /// Tab 클릭
        /// </summary>
        public void ClickTab()
        {
            foreach (var action in _actions)
            {
                action.Invoke();
            }

            if (null == TabGroup)
            {
                TabGroup = gameObject.GetComponentInParent<UITabGroup>(true);
            }

            if (null != TabGroup)
            {
                TabGroup.OnClickTab(this);
            }
        }
        
        /// <summary>
        /// UITab 클릭 액션 추가
        /// </summary>
        /// <param name="action"></param>
        public void AddTabClick(Action action)
        {
            var find = _actions.Find(d => d == action);
            if (null != find)
                _actions.Remove(action);
            
            _actions.Add(action);
        }

        public bool IsSelected()
        {
            return _isSelected;
        }
    }
}
