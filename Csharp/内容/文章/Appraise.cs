namespace Csharp.文章
{
    public class Appraise: IAgree,IDisagree
    {
        //每个文章和评论都有一个评价
        public Article Article { get; set; }
        public Comment Comment { get; set; }

        public void Agree(User voter)
        {
            throw new System.NotImplementedException();
        }

        public void Disagree()
        {
            throw new System.NotImplementedException();
        }
    }
}
