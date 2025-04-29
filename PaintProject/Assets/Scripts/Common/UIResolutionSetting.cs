using System;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
using System.Reflection;
#endif

namespace PaintProject
{
    using UniRx;

    public class UIResolutionSetting : MonoBehaviour
    {
        [SerializeField] public RectTransform[] _SafeAreaTargetRectTrans;

        private IDisposable _disposable;

        /// <summary>
        /// 해상도 비율 대응
        /// </summary>
        /// <param name="target_Width"></param>
        /// <param name="target_Height"></param>
        public void SetCanvasScaler(float target_Width = 0, float target_Height = 0,
            ScreenOrientation orientation = ScreenOrientation.LandscapeLeft)
        {
            CanvasScaler comp = GetComponent<CanvasScaler>();
            if (null == comp)
                return;

            if (orientation == ScreenOrientation.LandscapeLeft)
            {
                comp.referenceResolution = new Vector2(1920, 1080);
                comp.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
                
                // 기준 해상도 비율
                float fixedAspectRatio = 1920f / 1080f;
                float currentAspectRatio = (float)Screen.width / (float)Screen.height;
                if (0 < target_Width && 0 < target_Height)
                {
                    Debug.Log($"Editor GameView Size : {target_Width} / {target_Height}");
                    currentAspectRatio = (float)target_Width / (float)target_Height;
                }

                //현재 해상도 가로 비율이 더 길 경우
                if (currentAspectRatio >= fixedAspectRatio)
                    comp.matchWidthOrHeight = 1;
                else
                    comp.matchWidthOrHeight = 0;
            }
            else if (orientation == ScreenOrientation.Portrait)
            {
                comp.referenceResolution = new Vector2(1080, 1920);
                comp.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
                
                // 기준 해상도 비율
                float fixedAspectRatio = 1080f / 1920f; // 세로 모드에서는 1080/1920
                float currentAspectRatio = (float)Screen.height / (float)Screen.width; // 가로/세로 비율을 뒤집어 계산
                if (target_Width > 0 && target_Height > 0)
                {
                    Debug.Log($"Editor GameView Size : {target_Width} / {target_Height}");
                    currentAspectRatio = target_Height / target_Width;
                }

                // 현재 해상도 세로 비율이 더 길 경우
                if (currentAspectRatio >= fixedAspectRatio)
                    comp.matchWidthOrHeight = 1;
                else
                    comp.matchWidthOrHeight = 0;
            }
            
#if UNITY_EDITOR
            string orientationString;
            if (orientation == ScreenOrientation.Portrait)
                orientationString = "Portrait";
            else
                orientationString = "Landscape";
            
            string ratioString = $"{comp.referenceResolution.x}x{comp.referenceResolution.y} {orientationString}";
            int index = GameViewSizeManager.FindSize(GameViewSizeGroupType.Android, ratioString);
            if (index < 0)
            {
                GameViewSizeManager.AddCustomSize(GameViewSizeManager.GameViewSizeType.FixedResolution, GameViewSizeGroupType.Android, (int)comp.referenceResolution.x, (int)comp.referenceResolution.y, ratioString);
            }
            GameViewSizeManager.SetSize(index);
#endif
        }

        /// <summary>
        /// 모바일 디바이스 노치 대응
        /// </summary>
        /// <param name="_rectTransform"></param>
        public void SetCanvasSafeArea(RectTransform[] _rectTransforms)
        {
            Vector2 minAnchor, maxAnchor;

            minAnchor = Screen.safeArea.min;
            maxAnchor = Screen.safeArea.max;

            minAnchor.x /= Screen.width;
            minAnchor.y /= Screen.height;

            maxAnchor.x /= Screen.width;
            maxAnchor.y /= Screen.height;

            foreach (var item in _rectTransforms)
            {
                if (null == item)
                    continue;

                item.anchorMin = minAnchor;
                item.anchorMax = maxAnchor;
            }
        }

        /// <summary>
        /// 모바일 디바이스 해상도에 따라 3D Camera FOV 대응
        /// </summary>
        public void SetFieldOfView()
        {
            UnityEngine.Camera gameCamera = gameObject.GetComponent<UnityEngine.Camera>();
            if (null == gameCamera)
                return;

            float WHvalue = (float)Screen.width / Screen.height;
            float value_1 = 2 - (float)WHvalue;
            float value_2 = value_1 / 0.7f;
            float result = 1 - value_2;

            if (result < 0.65f)
                result = 86;
            else
                result = 70;

            gameCamera.fieldOfView = result;
        }
    }
}


#if UNITY_EDITOR
public class GameViewSizeManager
{
    private static object gameViewSizesInstance;
    private static MethodInfo getGroupMethod;

    static GameViewSizeManager()
    {
        var sizesType = typeof(Editor).Assembly.GetType("UnityEditor.GameViewSizes");
        var singleType = typeof(ScriptableSingleton<>).MakeGenericType(sizesType);
        var instanceProp = singleType.GetProperty("instance");
        getGroupMethod = sizesType.GetMethod("GetGroup");
        gameViewSizesInstance = instanceProp.GetValue(null, null);
    }

    public enum GameViewSizeType
    {
        AspectRatio,
        FixedResolution
    }

    public static void SetSize(int index)
    {
        var gameViewType = typeof(Editor).Assembly.GetType("UnityEditor.GameView");
        var gameViewWindow = EditorWindow.GetWindow(gameViewType);
        var sizeSelectionCallback = gameViewType.GetMethod("SizeSelectionCallback");
        sizeSelectionCallback.Invoke(gameViewWindow, new object[] { index, null });
    }

    public static void AddCustomSize(GameViewSizeType viewSizeType, GameViewSizeGroupType sizeGroupType, int width, int height, string text)
    {
        Type type = typeof(Editor).Assembly.GetType("UnityEditor.GameViewSizeType");

        var group = GetGroup(sizeGroupType);
        var addCustomSize = getGroupMethod.ReturnType.GetMethod("AddCustomSize");
        var gameViewSizeType = typeof(Editor).Assembly.GetType("UnityEditor.GameViewSize");

        var constructor = gameViewSizeType.GetConstructor(new Type[] { type, typeof(int), typeof(int), typeof(string) });
        var newSize = constructor.Invoke(new object[] { (int)viewSizeType, width, height, text });

        addCustomSize.Invoke(group, new object[] { newSize });
    }

    public static bool SizeExists(GameViewSizeGroupType sizeGroupType, string text)
    {
        return FindSize(sizeGroupType, text) != -1;
    }

    public static int FindSize(GameViewSizeGroupType sizeGroupType, string text)
    {
        var group = GetGroup(sizeGroupType);
        var getDisplayTexts = group.GetType().GetMethod("GetDisplayTexts");
        var displayTexts = getDisplayTexts.Invoke(group, null) as string[];
        for (int i = 0; i < displayTexts.Length; i++)
        {
            string display = displayTexts[i];
            int pren = display.IndexOf('(');
            if (pren != -1)
                display = display.Substring(0, pren - 1);
            if (display == text)
                return i;
        }

        return -1;
    }

    public static bool SizeExists(GameViewSizeGroupType sizeGroupType, int width, int height)
    {
        return FindSize(sizeGroupType, width, height) != -1;
    }

    public static int FindSize(GameViewSizeGroupType sizeGroupType, int width, int height)
    {
        var group = GetGroup(sizeGroupType);
        var groupType = group.GetType();

        var getBuiltinCount = groupType.GetMethod("GetBuiltinCount");
        var getCustomCount = groupType.GetMethod("GetCustomCount");

        int sizesCount = (int)getBuiltinCount.Invoke(group, null) + (int)getCustomCount.Invoke(group, null);

        var getGameViewSize = groupType.GetMethod("GetGameViewSize");
        var gvsType = getGameViewSize.ReturnType;

        var widthProp = gvsType.GetProperty("width");
        var heightProp = gvsType.GetProperty("height");

        var indexValue = new object[1];
        for (int i = 0; i < sizesCount; i++)
        {
            indexValue[0] = i;
            var size = getGameViewSize.Invoke(group, indexValue);
            int sizeWidth = (int)widthProp.GetValue(size, null);
            int sizeHeight = (int)heightProp.GetValue(size, null);
            if (sizeWidth == width && sizeHeight == height)
                return i;
        }

        return -1;
    }

    static object GetGroup(GameViewSizeGroupType type)
    {
        return getGroupMethod.Invoke(gameViewSizesInstance, new object[] { (int)type });
    }

    public static GameViewSizeGroupType GetCurrentGroupType()
    {
        var getCurrentGroupTypeProp = gameViewSizesInstance.GetType().GetProperty("currentGroupType");
        return (GameViewSizeGroupType)(int)getCurrentGroupTypeProp.GetValue(gameViewSizesInstance, null);
    }
}
#endif
