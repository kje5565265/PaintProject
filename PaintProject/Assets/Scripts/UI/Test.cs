using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace PaintProject
{
    public class Test : MonoBehaviour
    {
        private void OnEnable()
        {
            Managers.Instance.Initialize().Forget();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Managers.Instance.uiMgr.OpenWindow<TestWindow>("TestWindow").Forget();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Managers.Instance.uiMgr.OpenWindow<TestWindow1>("TestWindow1").Forget();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Managers.Instance.uiMgr.OpenWindow<TestWindow2>("TestWindow2").Forget();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Managers.Instance.uiMgr.OpenWindow<TestWindow3>("TestWindow3").Forget();
            }
            
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Managers.Instance.uiMgr.CloseWindow("TestWindow");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Managers.Instance.uiMgr.CloseWindow("TestWindow1");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                Managers.Instance.uiMgr.CloseWindow("TestWindow2");
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                Managers.Instance.uiMgr.CloseWindow("TestWindow3");
            }
        }
    }
}
