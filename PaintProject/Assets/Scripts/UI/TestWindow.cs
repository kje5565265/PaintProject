using UnityEngine;

namespace PaintProject
{
    public class TestWindow : UIWindowBase
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
