using UnityEngine;

namespace PaintProject
{
    public class TestWindow2 : UIWindowBase
    {
        public override void OnOpen()
        {
        }

        public override void OnClose()
        {
            gameObject.SetActive(false);
        }
    }
}
