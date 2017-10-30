using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
public class LoadFromFileExample : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        string path = "AssetBundles/cubewall.unity3d";
        //AssetBundle share = AssetBundle.LoadFromFile("AssetBundles/share.unity3d");//一定要是加后缀的路径
        //AssetBundle ab = AssetBundle.LoadFromFile("AssetBundles/cubewall.unity3d");

        ////UnityWebRequest.
        //GameObject obj =  ab.LoadAsset<GameObject>("CubeWall");
        //Instantiate(obj
        AssetBundle ab = null;
        //加载方式1：LoadFromMemory
        //异步
        #region LoadFromMemory
        //AssetBundleCreateRequest request =  AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(path));
        //yield return request;
        //ab = request.assetBundle;

        //{
        //    //同步
        //    ab = AssetBundle.LoadFromMemory(File.ReadAllBytes(path));
        //}
        #endregion

        //加载方式2:LoadFromFile
        //AssetBundleCreateRequest request2 = AssetBundle.LoadFromFileAsync(path);
        //yield return request2;
        //ab = request2.assetBundle;

        //加载方式3
        while (Caching.ready == false)
        {
            yield return null;
        }
        WWW www = WWW.LoadFromCacheOrDownload(@"file:///E:\gitPro\ab\AssetBundle\Assetbundle\AssetBundles\cubewall.unity3d", 1);
        yield return www;
        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.LogError("www is error");
            yield break;
        }
        ab = www.assetBundle;
        //ab使用
        GameObject obj = ab.LoadAsset<GameObject>("CubeWall");
        Instantiate(obj);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
