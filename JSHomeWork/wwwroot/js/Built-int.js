//  将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''，或者：<span>zyf---+---fyz</span> ……）
//利用新学到的Array函数，重新完成之前的数组相关作业

//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：将“飞哥”改成“大神”，“线下”改成“线上”。
var str = "‘源栈’：飞哥小班教学，线下免费收看";
str = str.replace('飞哥', '大神');
str = str.replace('线下', '线上');
console.log(str);
//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，让所有元素：
//  首字母大写开头，其他字母小写
//  截去超过6个字符的部分，如'community'将变成'Commun'
var arr = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
for (var i = 0; i < arr.length; i++) {
    arr[i] = arr[i][0].toUpperCase() + arr[i].substring(1, arr[i].length).toLowerCase();
    arr[i] = arr[i].substring(0, 6);
}
console.log(arr);
//使用正则表达式判断某个字符串:
//  是否是合格的Email格式
//  是否是小数（正负小数都可以）
//  将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''，或者：<span>zyf---+---fyz</span> ……）
var regex = /^[A-Za-z0-9]+@[a-zA-Z0-9_-]+(.[a-zA-Z0-9_-]+)+$/;
var input = '1151935939@qq.com';
if (regex.test(input)) {
    console.log("Email格式ok");
} else {
    console.log(" it is  error");
}
var rexDecimal = /^\d+\.+\d+$/;
if (rexDecimal.test(5589.9)) {
    console.log("OK");
} else {
    console.log("it is  error");
}




//利用新学到的Array函数，重新完成之前的数组相关作业

//在上述数组头部加上小鱼老师，末尾加上大飞哥
var arr1 = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
console.log(arr1);
arr1.push('大飞哥');
arr1.unshift('小鱼老师');
console.log(arr1);
//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
function getRandomArray(length, max) {
    var arr = [];
    for (var i = 0; i < length; i++) {

        arr[i] = Math.ceil(Math.random(0, 1) * max);
    }
    return arr;
}
console.log(getRandomArray(3, 200));
//生成一个函数toChinese() ，可将传入的日期参数（如：new Date() ）转换成中文日期格式（如：2019年10月4日 16点54分）
function toChinese(date) {
    return str = date.getFullYear() + "年"
        + date.getMonth() + 1 + "月"
        + date.getDate() + "日" + "  "
        + date.getHours() + "点"
        + date.getMinutes() + "分";
}
var date1 = new Date();
console.log(toChinese(date1));
//生成一个函数addDays(number) ，可在当前日期的基础上增加number天
function addDays(number) {
    date = new Date();
    date.setDate((date.getDate() + number));
    return date;
};
console.log(addDays(5));
// 按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示。
var datas = [
    {
        sname: 'z',
        qqname: "叶子",
        age: '18',
        isMale: true,
        hobby: '唱歌',
        introduction: '飞哥最帅'
    }, {
        sname: 'xy',
        qqname: '小鱼',
        age: '18',
        isMale: true,
        hobby: '唱歌',
        introduction: '我小鱼'
    }, {
        sname: 'atai',
        qqname: '阿泰',
        age: '18',
        isMale: true,
        hobby: '唱歌',
        introduction: '阿泰帅'
    }];
function tb() {
    for (var i = 0; i < datas.length; i++) {
        var tr = document.createElement('tr');
        tr.style.color = 'pink'; 
        document.getElementById("tbody").appendChild(tr);
        for (var k in datas[i]) {
            var td = document.createElement('td');
            tr.appendChild(td);
            td.innerText = datas[i][k];
        

        }
    }
}
tb();

