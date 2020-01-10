using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XCode.Membership;

namespace ApiCore.Bo.UserInfo
{
    public class UserRepositofy
    {
        public async Task<BasPosMsg>  UserAdd()
        {
            BasPosMsg ret = new BasPosMsg();
            try
            {
                await Task.Run(() =>
                {
                    // 添加
                    var user = new UserX
                    {
                        Name = "djkgf",
                        Enable = true
                    };
                    var book = new Book
                    {
                        Name = "jsf1"
                    };

                    user.Insert();
                    book.Insert();
                    ret.Code = "200";
                    ret.Msg = "success";
                });
             
            }
            catch (Exception e)
            {

                ret.Code = "500";
                ret.Msg = e.Message;
            }
        
            return ret;
        }
        public async Task<UserSearchRet>  UserSearch()
        {
          
            UserSearchRet ret = new UserSearchRet();
            try
            {
                await Task.Run(() =>
                {

                    var userL = UserX.FindAllWithCache();
                    ret.Code = "200";
                    ret.Msg = "success";
                    foreach (UserX user in userL)
                    {
                        UserInfo userxx = new UserInfo
                        {
                            Name = user.Name,
                            Code = user.Code,
                        };
                        ret.Data.Add(userxx);
                    }

                });

            }
            catch (Exception e)
            {

                ret.Code = "500";
                ret.Msg = e.Message;
            }
            return ret;
        }

    

    }



}
