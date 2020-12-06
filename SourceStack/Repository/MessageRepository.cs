using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class MessageRepository
    {
        private static IList<Message> messages;
        static    MessageRepository()
        {
            messages = new List<Message>() {
             new Message() {
                     Id=1,
                     Content="欢迎你加入“一起帮”！记得完成“新手任务”获得 帮帮点 奖励哟。O(∩_∩)O~",
                     CreateTime=DateTime.Now
                 },
             new Message() {
                     Id=2,
                     Content="欢迎你加入“一起帮”！记得完成“新手任务”获得 帮帮点 奖励哟。O(∩_∩)O~",
                     CreateTime=DateTime.Now
                 },
              new Message() {
                     Id=3,
                     Content="因为注册时使用了叶飞的邀请码，系统赠送给你10点 帮帮点",
                     CreateTime=DateTime.Now
                 },
               new Message() {
                     Id=4,
                     Content="因为注册时使用了叶飞的邀请码，系统赠送给你10点 帮帮点",
                     CreateTime=DateTime.Now
                 },
            };
        }
        public IList<Message> GetMine(bool onlyNotRead = false)
        {


            var result = messages;
            if (onlyNotRead) {
                //  return messages.Where(m => !m.HasRead).ToList();
                result = messages.Where(m => !m.HasRead).ToList();//未读的
            }

            //else {
            //    return messages;
            //}
            //else nothig
            return result;

        }
        public Message Find(int id)
        {
            return messages.Where(m => m.Id == id).SingleOrDefault();

        }

    }
}
