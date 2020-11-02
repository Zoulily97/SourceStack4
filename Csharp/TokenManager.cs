namespace Csharp
{/*声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
                 声明一个令牌管理（TokenManager）类：
                使用私有的Token枚举_tokens存储所具有的权限
                 暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
                 User类中添加一个Tokens属性，类型为TokenManager*/
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
    public class TokenManager
    {
        private Token _tokens;

       
        public void   Add( Token token)
        {
            this._tokens = this._tokens | token;
            //return _tokens;

        }
        public void Remove(Token token)
        {
            this._tokens = this._tokens ^ token;
           
        }
        public void  Has(Token token)
        {
            this._tokens = this._tokens & token;
           
        }

       
    }


}
