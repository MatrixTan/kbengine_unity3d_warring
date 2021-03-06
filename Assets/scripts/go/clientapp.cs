using UnityEngine;
using System;
using System.Collections;
using KBEngine;

public class clientapp : KBEMain 
{
	public string download_res_url_port = "80";
	
	public override void initKBEngine()
	{
		// 强制设定为页游客户端，否则服务端找不到对应这个demo的场景
		clientType = KBEngineApp.CLIENT_TYPE.CLIENT_TYPE_BROWSER;
		
		// 设置动态下载资源的网址端口, 如果端口没有修改过则不需要配置
		if(download_res_url_port != "80")
			Common.urlPort = ":" + download_res_url_port;
		
		base.initKBEngine();
	}
}
