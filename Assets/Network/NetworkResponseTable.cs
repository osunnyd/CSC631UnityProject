using UnityEngine;

using System;
using System.Collections.Generic;

public class NetworkResponseTable {

	public static Dictionary<short, Type> responseTable { get; set; }
	
	public static void init() {
		responseTable = new Dictionary<short, Type>();
		add(Constants.SMSG_AUTH, "ResponseCreate");//201
		add(Constants.SMSG_PLAYERS, "ResponsePlayers");//203
		add(Constants.SMSG_TEST, "ResponseTest");//204
        add(Constants.SMSG_LOGIN, "ResponseLogin");//208
        add(Constants.SMSG_MOVE, "ResponseMove");//231
        add(Constants.SMSG_READY, "ResponseReady");//241
        add(Constants.SMSG_START, "ResponseStart");//242
        add(Constants.SMSG_UNREADY, "ResponseUnready");//243
        add(Constants.SMSG_CHAT, "ResponseChat");//433
        add(Constants.SMSG_LIGHT, "ResponseLight");//244
        add(Constants.SMSG_P2CORRECT, "ResponseP2Correct");//245
        add(Constants.SMSG_P2INCORRECT, "ResponseP2Incorrect");//246
        add(Constants.SMSG_TIMER, "ResponseTopScore");//434

    }
	
	public static void add(short response_id, string name) {
		responseTable.Add(response_id, Type.GetType(name));
	}
	
	public static NetworkResponse get(short response_id) {
		init ();
		NetworkResponse response = null;
		if (responseTable.ContainsKey(response_id)) {
			response = (NetworkResponse) Activator.CreateInstance(responseTable[response_id]);
			response.response_id = response_id;
		} else {
			Debug.Log("Response [" + response_id + "] Not Found");
		}
		
		return response;
	}
}
