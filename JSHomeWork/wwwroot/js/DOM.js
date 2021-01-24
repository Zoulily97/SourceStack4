//作业
//模拟求助首页，并：
//   统计有多少个悬赏大于1的求助
//   将状态为“协助中”的求助背景改成灰黑色
//   如果总结数为0，将其从DOM树中删除
//   写一个函数getKeywordsCount() ，可以统计某个求助使用了多少关键字

//参考用户注册页面，显示错误提示：
//   密码的长度不能小于4
//    密码和确认密码必须一致
//参考用户资料页面，控制台显示出用户的：性别 / 出生年月 / 关注（关键字）/ 自我介绍
//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果


//统计有多少个悬赏大于1的求助
function pCountRewardover1() {
    var count = 0;
    var rewardNumarr = document.getElementsByName("rewardNum");
    for (var i = 0; i < rewardNumarr.length; i++) {
        if (rewardNumarr[i].innerText > 1) {
            count++;
        }
    }
    return count;
}
console.log(pCountRewardover1());
//将状态为“协助中”的求助背景改成灰黑色
function changeBackColor() {
    var statearr = document.getElementsByName("state");
    for (var i = 0; i < statearr.length; i++) {
        if (statearr[i].innerText == "协助中") {
            statearr[i].style = "background-color:darkgray"
        }
    }
}
changeBackColor();
//如果总结数为0，将其从DOM树中删除
function removesum0() {
    var summarySumarr = document.getElementsByName("summarySum");
    for (var i = 0; i < summarySumarr.length; i++) {
        if (summarySumarr[i].innerText == 0) {
            summarySumarr[i].previousElementSibling.remove();
            summarySumarr[i].remove();
        }
    }

}
removesum0();
//写一个函数getKeywordsCount() ，可以统计某个求助使用了多少关键字
function getKeywordsCount() {
    var count = 0;
    //// var problemsnode = document.getElementsByName("keywords")[0];
    // var node = problemsnode.childNodes;
    // for (var i = 0; i < node.length; i++) {



    // }
    //if (keywordsnode.nextSibling.innerText != null) {
    //    count++;

    //}
    return count;
}
console.log(getKeywordsCount());
//密码的长度不能小于4
document.getElementsByName("password")[0].onblur = function () {
    console.log(this.value);
    console.log(this.value.length);
    if (this.value.length < 4) {
        //alert("你的密码长度不能小于4位");
        this.nextElementSibling.style = "display:block;background-color:pink";
    }
}
//密码和确认密码必须一致
document.getElementsByName("password")[1].onblur = function () {
    var password = document.getElementsByName("password")[0];
    //var cofirmpassword = document.getElementsByName("password")[1];
    if (password.value != this.value) {
        this.nextElementSibling.style = "display:block;background-color:pink";
    }
}

function userdata() {
    var gender = document.getElementsByName("gender");
    for (var i = 0; i < gender.length; i++) {
        if (gender[i].checked) {
            console.log("性别" + gender[i].nextElementSibling.innerText);
        }
    }
    var year = document.getElementsByName("year")[0].selectedOptions[0].innerText;
    var month = document.getElementsByName("month")[0].selectedOptions[0].innerText;
    console.log(year + "年" + month + "月");
    var introduction = document.getElementsByName("self-introduction")[0].value;
    var keyword1 = document.getElementsByName("keyword")[0].selectedOptions[0].innerText;
    var keyword2 = document.getElementsByName("keyword")[1].selectedOptions[0].innerText;
    var keyword3 = document.getElementsByName("keyword")[2].innerText;
    console.log("关键字" + keyword1 + keyword2 + keyword3);
    console.log("自我介绍" + introduction);
}
userdata();
////实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果-->
if (document.getElementById("bell").style.color == 'purple') {
    setInterval(function () {
        if (document.getElementById("bell").style.color != 'purple') {
            document.getElementById("bell").setAttribute("style", "color:purple");
            console.log(22);
        }
        else if (document.getElementById("bell").style.color == 'purple') {
            document.getElementById("bell").setAttribute("style", "color:pink");
            console.log(233);
        }
    }, 1000);
}

//个“前一页”按钮，点击可以跳到上一页；一个“下一页”按钮，点击可以跳到下一页；
function pre() {
    document.getElementById("pre").onclick = function myfunction() {
        history.go(-1);
        console.log(111);
    }
}
pre();
function next() {
    document.getElementById("next").onclick = function myfunction() {
        // location.assign("http://17bang.ren/Article/486");
        history.forward();
    }
}
next();
//一个“转到”按钮，点击该按钮页面可跳转到文本框指定的网址页面-->
document.getElementById("goto").onclick = function () {
      location.assign("https://localhost:44300/JsHomework.html");

}