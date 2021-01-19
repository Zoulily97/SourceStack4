//作业
//完成猜数字的游戏：
// 弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
// 浏览器生成一个不大于1000的随机正整数；（Math.floor(Math.random() * 1000) ）
// 用户输入猜测；
// 如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//     只用了不到6次就猜到，弹出：碉堡了！
//     只用了不到8次就猜到，弹出：666！
//     用了8 - 10次猜到，弹出：猜到了。
//     用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^
function guessNumber() {
    var targrtNum = Math.floor(Math.random() * 1000);
    console.log(targrtNum);
    for (var i = 0; i < 20; i++) {
        var inputnum = window.prompt("猜数字的游戏开始，请输入你猜的数字")
        if (targrtNum !== inputnum) {
            if (i < 10) {
                if (targrtNum < inputnum) {
                    window.alert("大了");
                } else if (targrtNum > inputnum) {
                    window.alert("小了")
                }
            }
            else if (i > 10) {
                return window.alert('用了10次都还没猜对,弹出：^ (*￣(oo) ￣) ^');
            }
        }
        if (targrtNum == inputnum) {
            if (i <= 5) {
                return window.alert("碉堡了！");
            }
            else if (i <= 8) {
                return window.alert("666！");
            }
            else if (i <= 10) {
                return window.alert("猜到了。")
            }

        }
    }

}
//guessNumber();
//分别使用setInterval()使用setTimeout()实现：每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
function smart(n) {
    var random = Math.floor(Math.random() * 100);
    n++;
    console.log("第" + n + "周，源栈同学" + random + "人");
    setTimeout(smart, 2000, n);   
}

setTimeout(smart, 2000, 3);
//setInterval(smart, 500);