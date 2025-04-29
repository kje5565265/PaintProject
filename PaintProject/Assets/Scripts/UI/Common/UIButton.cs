using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ObservableExtensions = UniRx.ObservableExtensions;

namespace PaintProject
{
    public enum ButtonPointerType
    {
        Down,
        Up,
        Enter,
        Exit
    }
    
    [RequireComponent(typeof(Button))]
    public class UIButton : UIBase, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("IsMultiClick")]
        [SerializeField] private bool _isAllowMultiClick = false;
        
        [Header("IsGlobalCoolTime")]
        [SerializeField] private bool _isGlobalCoolTime = false;
        
        [Header("DisableTargetGraphicAll")]
        [SerializeField] private bool _isTargetGraphicAll = false;

        [Header("Sound ID")]
        public int SoundID = 1;

        [Header("Effect ID")]
        public int EffectID;

        [Header("PointerEvent GameObject Active Controll")]
        [SerializeField] private SerializableDictionary<ButtonPointerType, GameObject> _dic_eventObjs = new SerializableDictionary<ButtonPointerType, GameObject>(){
            { ButtonPointerType.Down , null}, { ButtonPointerType.Up , null}, {ButtonPointerType.Enter, null}, {ButtonPointerType.Exit, null}};
        /// <summary>
        /// Actions
        /// </summary>
        public Action<PointerEventData> PointerEvent_Down;
        public Action<PointerEventData> PointerEvent_Up;
        public Action<PointerEventData> PointerEvent_Enter;
        public Action<PointerEventData> PointerEvent_Exit;
        
        private List<Action> _actions = new List<Action>();
        
        /// <summary>
        /// ui
        /// </summary>
        private Button _button;
        public Button Button => _button;

        /// <summary>
        /// 클릭 주기 관련
        /// </summary>
        private float _interval;
        private float _preClickTime;
        private float _clickInterval = 0.2f;

        /// <summary>
        /// 사운드 프리로드 여부
        /// </summary>
        private bool _isPreloaded = false;

        private Dictionary<Image, Color> _images_All = new Dictionary<Image, Color>();
        private Dictionary<TextMeshProUGUI, Color> _textMeshPro_All = new Dictionary<TextMeshProUGUI, Color>();
        private Color _disabledColor;
        private bool _beforeInteractable;
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            if (null == _button)
                return;

            _preClickTime = 0f;
            ObservableExtensions.Subscribe(_button.OnClickAsObservable(), _ => ClickButton()).AddTo(this);
            
            ColorBlock colors = _button.colors;
            if(null != colors)
                _disabledColor = colors.disabledColor;
            
            _images_All.Clear();
            _images_All = new Dictionary<Image, Color>();
            var images = GetComponentsInChildren<Image>().ToList();
            if (null != images && 0 < images.Count)
            {
                foreach (var childImage in images)
                {
                    _images_All.Add(childImage, childImage.color);    
                }
            }
            
            _textMeshPro_All.Clear();
            _textMeshPro_All = new Dictionary<TextMeshProUGUI, Color>();
            var texts = GetComponentsInChildren<TextMeshProUGUI>().ToList();
            if (null != texts && 0 < texts.Count)
            {
                foreach (var text in texts)
                {
                    _textMeshPro_All.Add(text, text.color);    
                }
            }
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }

        private void OnEnable()
        {
            _beforeInteractable = _button.interactable;
            
            // 기본 버튼사운드 일 경우 리턴
            // - 대부분의 버튼들이 기본사운드만 사용한다.
            // - 불필요하게 자주 호출될수 있는 경우 제외
            if (SoundID <= 1 || _isPreloaded)
                return;

            UnityEngine.Debug.Log($"$[UIButton] SoundPreload - ID : {SoundID}");
            //StartCoroutine(ButtonSoundPreload());
        }

        private void ClickButton()
        {
            // 연속 클릭이 불가능한 Btn 인 경우 클릭 인터벌 적용
            if (_isAllowMultiClick == false)
            {
                _interval = Time.unscaledTime - _preClickTime;
                if (_interval < _clickInterval)
                    return;
                
                // if (_isGlobalCoolTime && false == Managers.UIMgr.ButtonGlobalCoolTimeCheck())
                //     return;
            }

            // if (_isGlobalCoolTime)
            //     Managers.UIMgr.ClickButtonGlobal();
                
            _preClickTime = Time.unscaledTime;

            // if (null != Managers.Instance)
            // {
            //     // 사운드 출력
            //     if (0 < SoundID && null != Managers.SoundMgr)
            //         Managers.SoundMgr.PlaySfx(SoundID).Forget();
            //     
            //     // 이펙트 출력
            //     if(0 < EffectID && null != Managers.VFXMgr)
            //         Managers.VFXMgr.PlayTask(EffectID, transform).Forget();
            // }

            // 클릭 액션 실행
            foreach (var action in _actions)
            {
                action.Invoke();
            }
        }

        /// <summary>
        /// Add Click Listener
        /// </summary>
        /// <param name="action"></param>
        public void AddButtonClick(Action action)
        {
            // if (IsHaveTabComponent())
            // {
            //     Debug.LogError("[UIButton] CrashComponent - Plz Use Tab Component");
            //     return;
            // }
            //
            if (null == _button)
                _button = GetComponent<Button>();
            
            var find = _actions.Find(d => d == action);
            if (null != find)
                _actions.Remove(action);
            
            _actions.Add(action);
        }
        
        /// <summary>
        /// Remove Click Listener
        /// </summary>
        /// <param name="action"></param>
        public void RemoveButtonClick(Action action)
        {
            if (null == _button)
                _button = GetComponent<Button>();
            
            var find = _actions.Find(d => d == action);
            if (null != find)
                _actions.Remove(action);
        }
        
        /// <summary>
        /// Clear Click Listener
        /// </summary>
        public void ClearButtonClick()
        {
            if (null == _button)
                _button = GetComponent<Button>();
            
            _actions.Clear();
        }

        /// <summary>
        /// Button Interactable
        /// </summary>
        /// <param name="isInteractable"></param>
        private Color _changeColor;

        public void ChangeInteractable( bool isInteractable )
        {
            if (null == _button)
                _button = GetComponent<Button>();
            
            _button.interactable = isInteractable;
            
            //_isTargetGraphicAll 인 경우 하위 자식 오브젝트들 모두 DisableColor 적용
            if (_beforeInteractable != isInteractable && _isTargetGraphicAll)
            {
                _beforeInteractable = isInteractable;
                
                foreach (var image in _images_All)
                {
                    if (false == isInteractable)
                    {
                        image.Key.color = _disabledColor;
                    }
                    else
                    {
                        image.Key.color = image.Value;
                    }   
                }
                foreach (var textMesh in _textMeshPro_All)
                {
                    if (false == isInteractable)
                    {
                        textMesh.Key.color = _disabledColor;
                    }
                    else
                    {
                        textMesh.Key.color = textMesh.Value;
                    }   
                }
            }
        }

        /// <summary>
        /// 프리로드가 가능한지 체크하고 실행
        /// </summary>
        // IEnumerator ButtonSoundPreload()
        // {
        //     // 한프레임 뒤에 실행
        //     // - 최초 1번 유아이 생성시에는 작동하지 않도록 
        //     yield return new WaitForEndOfFrame();
        //
        //     if (null == Managers.Instance || false == Managers.Instance.IsInitialize)
        //         yield break;
        //     
        //     if(null == Managers.SoundMgr || false == Managers.SoundMgr.IsInitialized)
        //         yield break;
        //     
        //     Managers.SoundMgr.PreloadSounds(SoundID, false).Forget();
        //     _isPreloaded = true;
        // }

        /// <summary>
        /// 글로벌 쿨타임 설정을 변경
        /// </summary>
        /// <param name="isEnable"></param>
        public void ChangeGlobalCoomTimeSet(bool isEnable)
        {
            _isGlobalCoolTime = isEnable;
        }

        /// <summary>
        /// Button Events
        /// </summary>
        /// <param name="eventData"></param>
        #region ButtonEvents

        public void OnPointerDown(PointerEventData eventData)
        {
            PointerEvent_Down?.Invoke(eventData);
            PointerEventGameObjectControll(ButtonPointerType.Down);
        }
        
        public void OnPointerUp(PointerEventData eventData)
        {
            PointerEvent_Up?.Invoke(eventData);    
            PointerEventGameObjectControll(ButtonPointerType.Up);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            PointerEvent_Enter?.Invoke(eventData);
            PointerEventGameObjectControll(ButtonPointerType.Enter);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            PointerEvent_Exit?.Invoke(eventData);
            PointerEventGameObjectControll(ButtonPointerType.Exit);
        }

        /// <summary>
        /// 실시간 버튼 인풋 상태에 따라 오브젝트 활성/비활성
        /// </summary>
        /// <param name="pointerType"></param>
        private void PointerEventGameObjectControll(ButtonPointerType pointerType)
        {
            if (null == _dic_eventObjs || _dic_eventObjs.Count <= 0)
                return;
            
            foreach (var item in _dic_eventObjs)
            {
                if (null != item.Value)
                {
                    if(pointerType == item.Key)
                        item.Value.SetActive(true);
                    else
                        item.Value.SetActive(false);
                }
            }
        }
        
        #endregion

    }
}
