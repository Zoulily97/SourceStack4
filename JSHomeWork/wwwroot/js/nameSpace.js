//使用“模拟名称空间”技术，构建一个函数函数yz.fei.get(number) ；
var yz = {};
//yz.fei = {};
//yz.fei = {
//    get: function (number) {
//        console.log('函数yz.fei.get(number)-----' + number);
//    }

//}
//yz.fei.get(1);
//作业
//yz.fei.get(number, handler)除number以外，还可以接受任意多个回调函数handler做参数，得到：0到number间有多少个满足handler条件的整数。
//回调函数handler能对number进行运算，并返回bool值的，比如has6()
//get()函数调用回调函数进行运算，只要回调函数运行结果为真，就累加计数
//最后返回累加值
//让yz.fei.get(number)调用实现之前“统计含9 / 8 / 6数字个数”的作业
function findTargetNum(number, targetNum) {
    var str = number.toString();
    var arr = str.split("");
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] == targetNum) {
            return true;

        }//else

    }
    return false;

}
function has9(number) {
    return findTargetNum(number, 9);
}
function has8(number) {
    return findTargetNum(number, 8);
}
function has6(number) {
    return findTargetNum(number, 6);
}

yz.fei = {
    get: function (number,hander) {
        var sum = 0;
        for (var i = 1; i <= number; i++) {

            if (hander(i)) {
                sum++;
            }
           
        }
        return sum;
    }
}
console.log(yz.fei.get(20, has6));//2