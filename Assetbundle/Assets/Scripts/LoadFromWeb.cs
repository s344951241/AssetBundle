using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class LoadFromWeb : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        //WWW www = WWW.LoadFromCacheOrDownload(@"http://120.24.170.229/AssetBundles/share.unity3d", 1);
        //yield return www;

        //if (string.IsNullOrEmpty(www.error) == false)
        //{
        //    yield break;
        //}
        //AssetBundle ab = www.assetBundle;
        //StartCoroutine(load());

        string url2 = "http://120.24.170.229/AssetBundles/share.unity3d";

        UnityWebRequest request2 = UnityWebRequest.GetAssetBundle(url2);
        yield return request2.Send();
        AssetBundle ab = (request2.downloadHandler as DownloadHandlerAssetBundle).assetBundle;
        StartCoroutine(load());

        //UnityWebRequest request = UnityWebRequest.GetAssetBundle(url);
        //yield return request.Send();
        ////AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);
        //AssetBundle ab = (request.downloadHandler as DownloadHandlerAssetBundle).assetBundle;
        //GameObject obj = ab.LoadAsset<GameObject>("CubeWall");
        //Instantiate(obj);


    }

    IEnumerator load()
    {
        string url = "http://120.24.170.229/AssetBundles/cubewall.unity3d";
        UnityWebRequest request = UnityWebRequest.GetAssetBundle(url);
        yield return request.Send();
        //AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);
        AssetBundle ab = (request.downloadHandler as DownloadHandlerAssetBundle).assetBundle;
        GameObject obj = ab.LoadAsset<GameObject>("CubeWall");
        Instantiate(obj);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
