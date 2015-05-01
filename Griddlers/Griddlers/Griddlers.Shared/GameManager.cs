using System;
using System.Collections.Generic;
using System.Text;
using GameLogic;

namespace Griddlers
{
    public class GameManager
    {
	    private Playboard playboard;

	    public GameManager()
	    {
#if WINDOWS_APP
			playboard = new Playboard("Windows");
#elif WINDOWS_PHONE_APP
			playboard = new Playboard("Phone");
#endif
		    string platform = playboard.Platform;
	    }
    }
}
