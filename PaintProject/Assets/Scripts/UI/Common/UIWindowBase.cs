using UnityEngine;

namespace PaintProject
{
    public abstract class UIWindowBase : UIBase
    {
        /// <summary>
        /// 매니저 에서 사용하는 변수이므로 임의로 수정하지 마시오
        /// </summary>
        public bool IsOpen;

        public int SortOrder;
        
        public abstract void OnOpen();
        public abstract void OnClose();
    }
}
