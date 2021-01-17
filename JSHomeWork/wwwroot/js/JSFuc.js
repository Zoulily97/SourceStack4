//将每天 / 课的作业用不同的js文件分隔：
//构建一个函数has9(number) ，可以判断number中是否带有数字9；
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
//让get986()通过调用has9() / has8() / has6() ，能找出number以内有多少个数字包含：9或者8或6。
//将之前“找出素数”的代码封装成一个函数findPrime(max) ，可以打印出max以内的所有素数。
//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
//封装一个函数，建立一个函数getMaxNumber() ，可以接受任意多各种类型的参数，并找出里面最大的数（忽略数值以外的其他类型）
//封装一个函数swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
//利用上面的swap()函数，将“冒泡排序”封装成函数bubbleSort()
//封装函数deleteDuplicated()删除一个数组里面重复的元素
//不使用JavaScript内置函数
//将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
//统计出这段文字中有多少个单词：
//There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings, the parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression


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
//构建一个函数has9(number) ，可以判断number中是否带有数字9；（19 / 98）
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
function has9(number) {
    return findTargetNum(number, 9);
}
function has8(number) {
    return findTargetNum(number, 8);
}
function has6(number) {
    return findTargetNum(number, 6);
}
console.log(has9(123));//f
console.log(has8(886));//t
console.log(has6(123456));//t
//让get986()通过调用has9() / has8() / has6() ，能找出number以内有多少个数字包含：9或者8或6。
function get986() {
    var j = 0;
    for (var i = 1; i <= 1000; i++) {
        number = i;
        if (has6(number)) {
            j++;
        }
        if (has8(number)) {
            j++;
        }
        if (has9(number)) {
            j++;
        }
    }
    return j;
}
console.log(get986());
//将之前“找出素数”的代码封装成一个函数findPrime(max) ，可以打印出max以内的所有素数。
function findPrime(max) {
    var flag;
    for (var i = 2; i < max; i++) {
        flag = true;
        for (var j = 2; j < i; j++) {
            if (i % j === 0) {
                flag = false;
            }
        }
        if (flag) {
            console.log('素数' + i);
        }
    }
    return 1;
}
findPrime(100);
//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
function Sum(a0, n, d) {
    return (a0 + (a0 + (n - 1) * d)) * n / 2;
}
console.log(Sum(1, 5, 2));//25
//封装一个函数，建立一个函数getMaxNumber() ，可以接受任意多各种类型的参数，并找出里面最大的数（忽略数值以外的其他类型）

function getMaxNumber(numbers) {
    //var str = numbers.toString();
    //var arr = str.split("");
    var max = numbers[0];
    for (var i = 0; i < numbers.length; i++) {
        if (max < numbers[i]) {
            max = numbers[i];
        }
    }
    return max;
}
//console.log(    getMaxNumber([1, 3, 4, 6, 7, 8]));
console.log(getMaxNumber([1, "4", false, 34, 789, "999"]));
//封装一个函数swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
function swap(arr, i, j) {
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
    return arr;
}
console.log(swap([1, 2, 3, 4, 5], 0, 1));
//利用上面的swap()函数，将“冒泡排序”封装成函数bubbleSort()
function bubbleSort(array) {
    for (var i = 0; i < array.length; i++) {
        for (var j = 0; j < array.length - 1; j++)
            if (array[j] > array[j + 1]) {
                swap(array, j, j + 1);
            }
    }
    return array;
}
console.log(bubbleSort([1, 22, 3, 4, 5, 0, 19]));
//封装函数deleteDuplicated()删除一个数组里面重复的元素
function deleteDuplicated(numbers) {
    for (var i = 0; i < numbers.length; i++) {
        numbers[i];
        for (var j = 1; j < numbers.length; j++) {
            if (numbers[i] === numbers[j]) {
                numbers.splice(j, 1);//删除功能,第一个参数为第一项位置,第二个参数为要删除几个。 用法:array.splice(index,num),返回值为删除内容,array为结果值
            }
        }
    }
    return numbers;
}
console.log(deleteDuplicated([2, 3, 4, 4, 5, 6, 6, 7, 7, 7, 9]));
//将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
var input = 'hello,yuanzhan';
function stringReverse(str) {
    var newstr = "";
    for (var i = str.length-1; i >=0; i--) {
        newstr += str[i];       
    }
    return newstr;
}
console.log(stringReverse(input));
//统计出这段文字中有多少个单词：
//There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings, the parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression

function wordsSum(str) {
    var i, j;
   

}

