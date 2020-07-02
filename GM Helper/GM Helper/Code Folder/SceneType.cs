using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class SceneType
    {
        public string SelSceneType;
        public SceneType(String sType)
        {
            SelSceneType = sType;
        }

        public void setSceneType(string sceneType)
        {
            SelSceneType = sceneType;
        }

        public string getSceneType()
        {
            return SelSceneType;
        }
    }
}