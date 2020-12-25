using System.Collections.Generic;
using System.ComponentModel;

namespace EFCoeTest
{
    public class Problem:Content
    {
        public IList<Keyword> Keywords { get; set; }
        public ProblemStatus Statu { set; get; }
        public string Summary { get; set; }
    }
    public enum ProblemStatus
    {
        [Description("已撤销")]
        cancelled,
        [Description("已酬谢")]
        Rewarded,
        [Description("协助中")]
        inprocess,
        [Description("待协助")]
        assist
    }
}