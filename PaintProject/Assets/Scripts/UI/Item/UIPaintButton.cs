using UnityEngine;

namespace PaintProject
{
    public class UIPaintButton : MonoBehaviour
    {
        [Header("Window")]
        private UIGameMain _uiGameMain;

        [Header("Hexa Color")]
        public string ColorHexa;

        private UIButton _btn_click;

        private void Awake()
        {
            _btn_click = GetComponent<UIButton>();
            _btn_click.AddButtonClick(OnClick_Button);
        }

        public void OnClick_Button()
        {
            if(null == _uiGameMain)
                return;

            _uiGameMain.OnClick_Color(ColorHexa);
        }
    }
}
