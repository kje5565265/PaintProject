using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace PaintProject
{
    public class UITabGroup : MonoBehaviour
    {
        [ReadOnly][SerializeField] private List<UITab> _uiTabs = new List<UITab>();
        
        public Dictionary<UITab, Action<bool>> OnChangeTabState = new Dictionary<UITab, Action<bool>>();

        /// <summary>
        /// 탭 그룹 이니셜라이즈
        /// - 현재 selected 중인 탭을 기준으로 다시한번 탭들의 상태를 강제로 변경
        /// - 다시한번 갱신을 해야하는 경우 사용하면 됨
        /// </summary>
        public void InitializeTabGroup()
        {
            FindChildTab();

            UITab selectedTab = null;
            foreach (var tab in _uiTabs)
            {
                OnChangeTabState[tab].Invoke(tab.IsSelected());
                if (tab.IsSelected())
                    selectedTab = tab;
            }

            if(selectedTab != null)
                selectedTab.ClickTab();
        }
        
        /// <summary>
        /// 인자로 들어온 UITab 을 Selected 상태로 하위 탭들의 상태를 변경
        /// - UI에서 최초 1번 호출할때 사용하면 됨
        /// </summary>
        /// <param name="selectTab"></param>
        public void InitializeTabGroup(UITab selectTab)
        {
            if (null == selectTab)
                return;
            
            FindChildTab();
            
            foreach (var tab in _uiTabs)
            {
                if (tab == selectTab)
                {
                    OnChangeTabState[tab].Invoke(true);
                }
                else
                {
                    OnChangeTabState[tab].Invoke(false);
                }
            }
            
            selectTab.ClickTab();
        }

        /// <summary>
        /// 자식 탭 검색 및 초기화
        /// </summary>
        private void FindChildTab()
        {
            var findTabs = gameObject.GetComponentsInChildren<UITab>(true);
            if (null == findTabs || findTabs.Length <= 0)
                return;

            _uiTabs.Clear();
            
            // 탭 리스트 검색 후 그룹에 추가
            foreach (var tab in findTabs)
            {
                _uiTabs.Add(tab);
                tab.TabGroup = this;
                tab.Initialize();
            }
        }
        
        /// <summary>
        /// Tab 선택 CallBack
        /// </summary>
        /// <param name="seletTab"></param>
        public void OnClickTab(UITab seletTab)
        {
            if (seletTab.IsSelected())
                return;
            
            foreach (var tab in _uiTabs)
            {
                if (tab == seletTab)
                {
                    OnChangeTabState[tab].Invoke(true);
                }
                else
                {
                    OnChangeTabState[tab].Invoke(false);
                }
            }
        }
    }
}
