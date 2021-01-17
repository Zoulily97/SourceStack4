// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//var slagon = "大神小班";
//console.log(typeof slagon);   //这时候是string类型
//slagon = 888;       //可以的！
//console.log(typeof slagon);   //这时候是number类型了

//alert("找到一个好工作，hahah");
//var problem = { Title: "首次求助测试", Body:"以下哪一种求助是“一起帮”鼓励的：", Reword:"10", NeedRemote:"??????"};
//alert(problem.Title);
//alert(problem.Body);
//alert(problem.Reword);
//alert(problem.NeedRemote);

//用JavaScript变量pBody存储这行Html代码：
//<a href='http://17bang.ren' target="_blank">源栈·一起帮</a>，助你实现 < span style = "font-size:16px;" > 编程</span > 梦想！
//用一个变量替换“编程”，以便输出更多内容。比如：助你实现{ 职业 } 梦想、助你实现{ 人生 } 梦想
//设计一段代码，实现以下逻辑：
//某用户有一定数量的帮帮豆（sum）
//每点赞一次就会消耗若干帮帮豆（consume）
//现在用户点赞若干次（count）
//计算用户剩余了多少帮帮豆（banlance）并用bool值显示他是否还有帮帮豆（isAvailable）
//以上皆需设置变量（变量名见圆括号），并代入计算。
//var pBody;
//var sum, consume, banlance,count;
//var isAvailable = false;
//for (var i = 0; i < count; i++)
//{
//    sum -= consume;

//}
//banlance = sum
//if (banlance>0) {
//    isAvailable = true
//}
////else
//var occupation = "职业";
//var target = "人生";
//console.log('助你实现' + occupation + '梦想,助你实现' + target + '梦想');

//var students = [
//    ['gty', 'lw', 'zdh', 'lzb'],
//    ['lgy', 'ht', 'zl']
//];    //数组students里有两个元素，每个元素又都是一个数组
//console.log(students[0][1]);  //0排第1个元素：lw
//for (var i = 0; i < students.length; i++) {
//    console.log("di "+(i+1)+"行");
//    for (var j = 0; j < students[i].length; j++) {
//        console.log(    students[i][j]);
//    }
//}

//作业

//写一段代码，能根据一起帮用户的帮帮点（bCredit）输出他对应的等级（可适度精简）

//一起帮用户被分为5种，每种都有一个整数代号：
//0：访客
//1：注册用户
//2：文章发布者
//3：管理员
//4：超级管理员
//写一段代码，用switch...case将代号转换成文字输出，但3和4都统称“管理员”即可

//var bCredit = 30;

//switch (bCredit) {
//    case 30:
//        console.log("入门");
//        break;
//    case 100:
//        console.log("聚气");
//        break;
//    case 200:
//        console.log("凝水");
//        break;
//    case 700:
//        console.log("萌芽");
//        break;
//    case 1500:
//        console.log("单叶");
//        break;
//    case 3000:
//        console.log("双叶");
//        break;
//    case 5000:
//        console.log("蓓蕾");
//        break;
//    case 10000:
//        console.log("花开");
//        break;
//    case 20000:
//        console.log("宝宝");
//        break;
//    case 50000:
//        console.log("金童/玉女");
//        break;


//}
//var usercode = 3;
//switch (usercode) {
//    case 0:
//        console.log("访客");
//        break;
//    case 1:
//        console.log("注册用户");
//        break;
//    case 2:
//        console.log("文章发布者");
//        break;
//    case 3:
//    case 4:
//        console.log("管理员");
//        break;
//    default:    //兜底的else 
//        console.log('什么鬼？');
//        break;
//}

//作业
//声明一个数组odds，利用循环把100以内的奇数按从小到大的顺序存入其中
//计算从odds数组中所有元素的和
//找到数组中的最小值
//去除一个数组中重复的值（提示：仔细思考需求）
//输出用空格代替0的杨辉三角形
//输出1000以内的所有“素数 / 质数”（只能被自己和1整除的数）
//完成冒泡排序（必做，参考C#）
//完成：二分查找 / 快速排序（选做，参考C#）

//声明一个数组odds，利用循环把100以内的奇数按从小到大的顺序存入其中
//var odds = [],
//    index = 0,
//    value = 1;
//do {
//    odds[index] = value;
//    index++;
//    value += 2;
//} while (value < 100);
//console.log(odds);

//计算从odds数组中所有元素的和
//var sum=0;
//for (let i = 0; i < odds.length; i++) {
//    sum += odds[i].valueOf();

//} 
//console.log(sum);

//找到数组中的最小值
//var numbers = [1, 2, 3, 44, 78, 45, 64];
//var min = numbers[0];
//for (var i = 0;
//    i < numbers.length;
//    i++) {
//    if (min >numbers[i]) {
//        min = numbers[i];
//    }
//}
//console.log(min);

//去除一个数组中重复的值（提示：仔细思考需求）
//var numbers = [2, 3, 4, 4, 5, 6, 6, 7, 7, 7, 0, 9];
//var index = 0;
//for (var i = 0; i < numbers.length; i++) {
//    numbers[i];
//    for (var j = 1; j < numbers.length; j++) {
//        if (numbers[i] === numbers[j]) {
//            numbers.splice(j, 1);//删除功能,第一个参数为第一项位置,第二个参数为要删除几个。 用法:array.splice(index,num),返回值为删除内容,array为结果值
//        }
//    }

//}
//console.log(numbers);
//输出用空格代替0的杨辉三角形
//var rows = 5,
//    columns = rows * 2 - 1;   //确定一共多少列
//var yh = [];
//for (var i = 0; i < rows; i++) {
//    yh[i] = [];             //避免undefined错误
//    var lines = '';         //为按行输出做准备
//    for (var j = 0; j < columns; j++) {
//        if (i === 0) {       //第一行只能手工做
//            yh[i][j] = (j === rows - 1) ? 1 : 0;
//        } else {
//            var preRow = i - 1,
//                边界值替换
//                preColumn = j - 1 >= 0 ? yh[preRow][j - 1] :0,
//                nextColumn = j + 1 < columns ? yh[preRow][j + 1] : 0;
//            yh[i][j] = preColumn + nextColumn;
//        }
//        lines += yh[i][j] + ' ';        
//    }

//    console.log(lines);
//}

//yh[i][j]=yh[i-1][j-1]+yh[i-1][j+1]

//var rows = 5,
//    columns = 2 * rows - 1;
//var yh = [];
//for (var i = 0; i < rows; i++) {
//    yh[i] = [];
//    var lines = '';
//    for (var j = 0; j < columns; j++) {
//        if (i === 0) {
//            yh[i][j] = (j === rows - 1) ? 1 : '';
//        }
//        else {
//            var preRow = i - 1;
//            preColumn = j - 1 >= 0 ? yh[preRow][j - 1] : 0;
//            nextColumn = j + 1 < columns ? yh[preRow][j + 1] : 0;
//            var current = preColumn + nextColumn;
//            yh[i][j] = current ? current : '';
//        } 

//        lines += yh[i][j] + '';
//    }

//    console.log(lines);
//}




//输出1000以内的所有“素数 / 质数”（只能被自己和1整除的数）
//var flag;
//for (var i = 2; i < 1001; i++) {
//    flag = true;
//    for (var j = 2; j < i; j++) {
//        if (i % j === 0) {
//            flag = false;
//            break;
//        }
//    }
//    if (flag) {
//        console.log('素数' + i);
//    }
//}
//完成冒泡排序（必做，参考C#）
//var numbers = [18, 2, 3, 4, 8, 9, 10, 89, 100, 34];
//for (var i = 0; i < numbers.length; i++) {
//    for (var j = 0; j < numbers.length - 1; j++) {
//        if (numbers[j] > numbers[j + 1]) {
//            var temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }
//    }
//}
//console.log(numbers);

//完成：二分查找(有序数组) / 快速排序（选做，参考C#）
//var target = 45;
//var numbers = [1,3,6,8,9,24,90];
//var left=0,
//    middle,
//    right = numbers.length-1;

//while (left <=right) {
//    middle = (left + right) / 2;
//    if (target > numbers[middle]) {
//        left = middle + 1;

//    }
//    else if (target < numbers[middle]) {
//        right = middle - 1;

//    }
//    else if(target === numbers[middle]){
//        console.log(middle);
//        break;
//    }  
//}
//console.log('没有找到');

//var sname = "飞哥";
//function smart() {
//    alert(`${sname}最帅`);
//}

//function reallySmart() {
//    var sname = '子祥';
//    smart();
//    //局部变量sname有更高优先级
//    console.log(sname);
//}
//reallySmart();
//    //假如var声明在后面
//var sname = "飞哥";  //提升  
