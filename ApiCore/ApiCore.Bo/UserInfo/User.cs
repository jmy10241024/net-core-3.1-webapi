using System;
using System.Collections.Generic;
using System.Text;
using XCode.Membership;

namespace ApiCore.Bo.UserInfo
{
   public  class BasPosMsg
    {
        public string Code { set; get; }
        public string Msg { set; get; }

    }
    public class UserInfo
    {
        public string Name { set; get; }
        public string Code { set; get; }
     

    }
    public class UserSearchRet: BasPosMsg
    {
        public List<UserInfo> Data { set; get; }
        public string Name { set; get; }
        public UserSearchRet()
        {
            Data = new List<UserInfo>();
        }

    }
}
