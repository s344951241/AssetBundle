using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateAssetbundles  {
    [MenuItem("Assets/Build AssetBundles")]
    public static void BuildAllAssetBundles()
    {
        string dir = "AssetBundles";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles("AssetBundles",BuildAssetBundleOptions.ChunkBasedCompression,BuildTarget.StandaloneWindows64);//路径，压缩方式，平台
    }
}
