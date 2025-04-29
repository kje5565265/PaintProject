using UnityEngine;

namespace PaintProject
{
    public class TestWindow1 : UIWindowBase
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
