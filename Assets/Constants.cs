public class Constants {
	
	// Constants
	public static readonly string CLIENT_VERSION = "1.00";
	//public static readonly string REMOTE_HOST = "localhost";
    //public static readonly string REMOTE_HOST = "54.183.172.28";
    public static readonly string REMOTE_HOST = "52.53.172.52";
    public static readonly int REMOTE_PORT = 9252;
	
	// Request (1xx) + Response (2xx)
	public static readonly short CMSG_AUTH = 101;
	public static readonly short SMSG_AUTH = 201;
    public static readonly short CMSG_HEARTBEAT = 102;
    public static readonly short SMSG_HEARTBEAT = 202;
	public static readonly short CMSG_PLAYERS = 103;
	public static readonly short SMSG_PLAYERS = 203;
	public static readonly short CMSG_TEST = 104;
	public static readonly short SMSG_TEST = 204;
    public static readonly short CMSG_LOGIN = 108;
    public static readonly short SMSG_LOGIN = 208;
    public static readonly short CMSG_MOVE = 131;
    public static readonly short SMSG_MOVE = 231;
    public static readonly short CMSG_READY = 141;
    public static readonly short SMSG_READY = 241;
    public static readonly short CMSG_START = 142;
    public static readonly short SMSG_START = 242;
    public static readonly short CMSG_UNREADY = 143;
    public static readonly short SMSG_UNREADY = 243;
    public static readonly short CMSG_CHAT = 333;
    public static readonly short SMSG_CHAT = 433;
    public static readonly short CMSG_LIGHT = 144;
    public static readonly short SMSG_LIGHT= 244;
    public static readonly short CMSG_P2CORRECT = 145; // For puzzle 2, trigger 538
    public static readonly short SMSG_P2CORRECT = 245;
    public static readonly short CMSG_P2INCORRECT = 146;
    public static readonly short SMSG_P2INCORRECT = 246;
    public static readonly short CMSG_SAVESCORE = 335;
    public static readonly short CMSG_TIMER = 334;
    public static readonly short SMSG_TIMER = 434;


    // Other
    public static readonly string IMAGE_RESOURCES_PATH = "Images/";
	public static readonly string PREFAB_RESOURCES_PATH = "Prefabs/";
	public static readonly string TEXTURE_RESOURCES_PATH = "Textures/";
	
	// GUI Window IDs
	public enum GUI_ID {
		Login,
        Team
	};

	public static int USER_ID = -1;
}