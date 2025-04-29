using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace PaintProject
{
    public static class Extentions
    {
        public static T GetComponent<T>(this GameObject root, string str) where T : Component
        {
            if (root.name.Equals(str))
                return root.GetComponent<T>();

            return root.GetComponentsInChildren<T>(true).FirstOrDefault(d => d.name.Equals(str) == true);
        }
        
        public static GameObject GetChildObject(this GameObject root, string str )
        {
            if (root.name == str)
            {
                return root.gameObject;
            }

            Transform trans = root.GetComponent<Transform>(str);
            if (null != trans)
                return trans.gameObject;

            return null;
        }
        
        public static Color32 HexToColor( this string hex )
        {
            hex = hex.Replace("#", "");
            byte a = 255;
            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if( hex.Length == 8 )
                a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);

            return new Color32(r, g, b, a);
        }

        public static string ColorToHex(this Color32 color)
        {
            string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
            return hex;
        }

        public static string ColorToHex(this Color color)
        {
            string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
            return hex;
        }
        
        /// <summary>
        /// 천단위 표시 - int
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static void SetUnitText(this TextMeshProUGUI txt, int amount)
        {
            txt.text = $"{amount:#,##0}";
        }
            
        /// <summary>
        /// 특정 재화에서 알파뱃 치환을 사용하는 재화인 경우 사용
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="amount"></param>
        public static void SetUnitTextAlphabet(this TextMeshProUGUI txt, long amount)
        {
            /*
             *
             * K 변환 : 십만 이상 ( 100,000 이상 => 100K )
             *
             * M 변환 : 천만 이상 ( 10,000,000 이상 => 10M )
             *
             * B 변환 : 백억 이상 ( 10,000,000,000 이상 => 10B )
             *
             * T 변환 : 십조 이상 ( 10000000000000 이상 => 10T )
             */

            if (amount <= 0)
            {
                txt.text = "0";
                return;
            }
            if (long.MaxValue <= amount)
            {
                txt.text = "OverRange";
                return;
            }
            
            string formattedNumber = $"{amount:#,##0}";
            
            if (amount >= 10000000000000)
            {
                formattedNumber = (amount / 1000000000000).ToString("F0") + "T";
            }
            else if (amount >= 10000000000)
            {
                formattedNumber = (amount / 1000000000).ToString("F0") + "B";
            }
            else if (amount >= 10000000)
            {
                formattedNumber = (amount / 1000000).ToString("F0") + "M";
            }
            else if( amount >= 100000)
            {
                formattedNumber = (amount / 1000).ToString("F0") + "K";
            }
            else
            {
                SetUnitText(txt, amount);
                return;
            }

            txt.text = formattedNumber;
        }

        public static string SetUnitTextAlphabet(this string txt, long amount)
        {
            if (amount <= 0)
            {
                txt = "0";
                return txt;
            }
            if (long.MaxValue <= amount)
            {
                txt = "OverRange";
                return txt;
            }
            
            string formattedNumber = $"{amount:#,##0}";
            
            if (amount >= 10000000000000)
            {
                formattedNumber = (amount / 1000000000000).ToString("F0") + "T";
            }
            else if (amount >= 10000000000)
            {
                formattedNumber = (amount / 1000000000).ToString("F0") + "B";
            }
            else if (amount >= 10000000)
            {
                formattedNumber = (amount / 1000000).ToString("F0") + "M";
            }
            else if( amount >= 100000)
            {
                formattedNumber = (amount / 1000).ToString("F0") + "K";
            }
            else
            {
                txt = $"{amount:#,##0}";
                return txt;
            }

            txt = formattedNumber;
            return txt;
        }

        /// <summary>
        /// 천단위 표시 - long
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static void SetUnitText(this TextMeshProUGUI txt, long amount)
        {
            txt.text = $"{amount:N0}";
        }

        /// <summary>
        /// 천단위 표시 - float
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static void SetPercentTex(this TextMeshProUGUI txt , float amount)
        {
            txt.text = $"{amount:F2}%";
        }

        /// <summary>
        /// 천단위 표시 - double
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static void SetUnitText(this TextMeshProUGUI txt, double amount)
        {
            txt.text = $"{amount:#,##0}";
        }
        
        /// <summary>
        /// NOTE::HANS
        /// Util 에 있던부분 옮겨옴
        /// </summary>
        /// <param name="value"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public static void IntToColor(this int value, out byte r, out byte g, out byte b)
        {
            r = (byte)(value >> 16 & 0xFF);
            g = (byte)(value >> 8 & 0xFF);
            b = (byte)(value & 0xFF);
        }
        
        /// <summary>
        /// NOTE::HANS
        /// Util 에 있던부분 옮겨옴
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int ColorToInt(this Color color)
        {
            byte r = (byte)(color.r);
            byte g = (byte)(color.g);
            byte b = (byte)(color.b);
            
            return (r << 16) | (g << 8) | b;
        }
        
        /// <summary>
        /// NOTE::HANS
        /// ColorToInt 에서 서로 다른 클래스의 Color 일때 대응하기위해 추가
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int ColorToInt(this System.Drawing.Color color)
        {
            return (color.R << 16) | (color.G << 8) | color.B;
        }
    }
    
    //https://gist.github.com/kimsama/4123043
    public static class Debug
    {
        public static bool isDebugBuild
        {
            get { return UnityEngine.Debug.isDebugBuild; }
        }

        private static void ConvertLog(
            object message,
            string memberName,
            string filePath,
            int lineNumber,
            System.Action<object> logFunction
        )
        {
            var convertPath = filePath.Replace("/", "\\");
            var lastIndexOf = convertPath.LastIndexOf('\\') + 1;
            var length = filePath.Length - lastIndexOf - 3;
            logFunction.Invoke(
                $"<b>[{filePath.Substring(lastIndexOf, length)}::{memberName}:L{lineNumber.ToString()}:T{Time.frameCount.ToString()}]</b> {message}");
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void Log(
            object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        )
        {
            ConvertLog(message, memberName, filePath, lineNumber, UnityEngine.Debug.Log);
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void LogWarning(
            object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        )
        {
            ConvertLog(message, memberName, filePath, lineNumber, UnityEngine.Debug.LogWarning);
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void LogError(
            object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        )
        {
            ConvertLog(message, memberName, filePath, lineNumber, UnityEngine.Debug.LogError);
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void DrawLine(
            UnityEngine.Vector3 start,
            UnityEngine.Vector3 end,
            UnityEngine.Color color = default(UnityEngine.Color),
            float duration = 0f,
            bool depthTest = true
        )
        {
            UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void DrawRay(
            UnityEngine.Vector3 start,
            UnityEngine.Vector3 dir,
            UnityEngine.Color color = default(UnityEngine.Color),
            float duration = 0f,
            bool depthTest = true
        )
        {
            UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
        }

        [System.Diagnostics.Conditional("DEBUG_LOG")]
        public static void Assert(
            bool condition,
            object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        )
        {
            var convertPath = filePath.Replace("/", "\\");
            var lastIndexOf = convertPath.LastIndexOf('\\') + 1;
            var length = filePath.Length - lastIndexOf - 3;
            UnityEngine.Debug.Assert(condition,
                $"<b>[{filePath.Substring(lastIndexOf, length)}::{memberName}:L{lineNumber}]</b> {message}");
        }
    }
}
