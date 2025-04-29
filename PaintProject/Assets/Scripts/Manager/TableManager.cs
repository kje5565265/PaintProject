using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using GDT;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace PaintProject
{
    public class TableManager : ManagerBase
    {
        private const string _filePath = "CommonGameDataTable";
        public CommonGDTManager CommonGDT { get; private set; }

        public List<GDT.AnimationInfoT> CharBaseAnimations = new List<AnimationInfoT>();
        private Dictionary<Tuple<ItemSubType, ItemGradeType, int>, ItemGrowthDataT> _growthDataTData = new();

        public override async UniTask Initialize()
        {
            if (_isInitialize)
                return;

            var bytes = await BytesResourcesLoad(_filePath);

            CommonGDT = new CommonGDTManager();
            CommonGDT.Init(bytes);

            _isInitialize = true;
        }

        public override void Clear()
        {
            _isInitialize = false;
        }
        
        private byte[] _BytesResourcesLoad(string filename)
        {
            //TextAsset _textAsset = Resources.Load(filename) as TextAsset;
            var _textAsset = Addressables.LoadAssetAsync<TextAsset>(filename).WaitForCompletion();
            Stream _s = new MemoryStream(_textAsset.bytes);
            BinaryReader br = new BinaryReader(_s);
            byte[] _bytes = br.ReadBytes(_textAsset.bytes.Length);
            
            br.Close();
            return _bytes;
        }

        private async UniTask<byte[]> BytesResourcesLoad(string fileName)
        {
            var locationsHandle = Addressables.LoadResourceLocationsAsync(fileName);
            var locationsTask = await locationsHandle.Task;

            // var handle = Addressables.LoadAssetAsync<TextAsset>(fileName);
            if (null == locationsTask
                || 0 == locationsTask.Count)
            {
                throw new Exception($"Failed to load resource locations - {fileName} is not found");
            }

            var handle = Addressables.LoadAssetAsync<TextAsset>(locationsTask.First());
            var task = handle.Task;

            var textAsset = await task;
            if (false == task.IsCompletedSuccessfully
                || null == textAsset)
            {
                throw new System.Exception($"Failed to load table data - Task is success? {task.IsCompletedSuccessfully}, textAsset is null? {null == textAsset}");
            }

            var stream = new MemoryStream(textAsset.bytes);
            var br = new BinaryReader(stream);
            var bytes = br.ReadBytes(textAsset.bytes.Length);

            br.Close();
            return bytes;
        }
    }
}
