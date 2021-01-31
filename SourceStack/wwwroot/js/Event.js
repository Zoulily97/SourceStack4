

//1.参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数
document.getElementById("keyword1").onmouseover = function (e) {
    var showcount = document.createElement("span");
    var count = 3;
    showcount.innerText = count + "次";
    this.appendChild(showcount);
} 
//2.参考消息页面：完成勾选全选功能

document.getElementById("selectall").addEventListener("change",
    function () {
        var messages = document.getElementsByName("message");
        for (let i = 0; i < messages.length; i++) {
            messages[i].checked = this.checked;
        }
    }
)
//3.
//4.参考注册页面：
//   提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
//   重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
//   当用户名或密码等有值时，关闭页面前弹出确认框